using System;
using System.Drawing;
using System.Windows.Forms;

using Transitions;

using stopwatch = System.Diagnostics.Stopwatch;

namespace Stopwatch
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			stopwatch = new stopwatch();
			updater = new Timer { Interval = 1 };
			toggleMilliseconds_Click(this, null);

			updater.Tick += (sender, e) =>
			{
				hours = stopwatch.Elapsed.Hours;
				minutes = stopwatch.Elapsed.Minutes;
				seconds = stopwatch.Elapsed.Seconds;
				milliseconds = stopwatch.Elapsed.Milliseconds;

				if (hours > 24 && (minutes == 59 && seconds == 59 && milliseconds == 999 ))
				{
					MessageBox.Show("Time limit exceeded. Please reset Stopwatch to continue.", "Time Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				lblHours.Text = string.Format("{0:D2}", hours);
				lblMinutes.Text = string.Format("{0:D2}", minutes);
				lblSeconds.Text = string.Format("{0:D2}", seconds);
				lblMilliseconds.Text = string.Format("{0:D3}", milliseconds);

				Application.DoEvents();
			};
		}

		private stopwatch stopwatch;
		private Timer updater;
		private ITransitionType linear = new TransitionType_Linear(100);

		private int hours = 0;
		private int minutes = 0;
		private int seconds = 0;
		private int milliseconds = 0;

		private void start_Click(object sender, System.EventArgs e)
		{
			updater.Start();
			stopwatch.Start();

			start.Enabled = false;
			resume.Enabled = false;
			stop.Enabled = true;
			reset.Enabled = false;

			Transition.run(start, "BackColor", SystemColors.Control, linear);
			Transition.run(resume, "BackColor", SystemColors.Control, linear);
			Transition.run(stop, "BackColor", SystemColors.ControlLight, linear);
			Transition.run(reset, "BackColor", SystemColors.Control, linear);
		}
		private void resume_Click(object sender, System.EventArgs e)
		{
			updater.Start();
			stopwatch.Start();

			start.Enabled = false;
			resume.Enabled = false;
			stop.Enabled = true;
			reset.Enabled = false;

			Transition.run(start, "BackColor", SystemColors.Control, linear);
			Transition.run(resume, "BackColor", SystemColors.Control, linear);
			Transition.run(stop, "BackColor", SystemColors.ControlLight, linear);
			Transition.run(reset, "BackColor", SystemColors.Control, linear);
		}
		private void stop_Click(object sender, System.EventArgs e)
		{
			updater.Enabled = false;
			stopwatch.Stop();

			start.Enabled = false;
			resume.Enabled = true;
			stop.Enabled = false;
			reset.Enabled = true;

			Transition.run(start, "BackColor", SystemColors.Control, linear);
			Transition.run(resume, "BackColor", SystemColors.ControlLight, linear);
			Transition.run(stop, "BackColor", SystemColors.Control, linear);
			Transition.run(reset, "BackColor", SystemColors.ControlLight, linear);
		}
		private void reset_Click(object sender, System.EventArgs e)
		{
			updater.Enabled = false;
			stopwatch.Stop();

			start.Enabled = true;
			resume.Enabled = false;
			stop.Enabled = false;
			reset.Enabled = false;

			Transition.run(start, "BackColor", SystemColors.ControlLight, linear);
			Transition.run(resume, "BackColor", SystemColors.Control, linear);
			Transition.run(stop, "BackColor", SystemColors.Control, linear);
			Transition.run(reset, "BackColor", SystemColors.Control, linear);

			hours = 0;
			minutes = 0;
			seconds = 0;
			milliseconds = 0;

			stopwatch.Reset();

			lblHours.Text = hours.ToString("00");
			lblMinutes.Text = minutes.ToString("00");
			lblSeconds.Text = seconds.ToString("00");
			lblMilliseconds.Text = milliseconds.ToString("000");
		}

		private bool millisecondsShowing = true;

		private void toggleMilliseconds_Click(object sender, EventArgs e)
		{
			if (millisecondsShowing)
			{
				Transition toggle1 = new Transition(new TransitionType_Linear(1000));
				toggle1.add(lblHours, "Left", 85);
				toggle1.add(colon1, "Left", 160);
				toggle1.add(lblMinutes, "Left", 235);
				toggle1.add(colon2, "Left", 310);
				toggle1.add(lblSeconds, "Left", 385);
				toggle1.add(lblMilliseconds, "ForeColor", SystemColors.Control);

				Transition toggle2 = new Transition(new TransitionType_Linear(500));
				toggle2.add(colon3, "ForeColor", SystemColors.Control);
				
				toggle2.run();
				toggle1.run();

				millisecondsShowing = false;
			}
			else if (!millisecondsShowing)
			{
				Transition toggle3 = new Transition(new TransitionType_Linear(1000));
				toggle3.add(lblHours, "Left", 11);
				toggle3.add(colon1, "Left", 86);
				toggle3.add(lblMinutes, "Left", 161);
				toggle3.add(colon2, "Left", 236);
				toggle3.add(lblSeconds, "Left", 311);
				toggle3.add(lblMilliseconds, "ForeColor", SystemColors.ControlText);

				Transition toggle4 = new Transition(new TransitionType_Linear(500));
				toggle4.add(colon3, "ForeColor", SystemColors.ControlText);

				toggle3.TransitionCompletedEvent += (sender_, e_) =>
				{
					toggle4.run();
				};

				toggle3.run();

				millisecondsShowing = true;
			}
		}
	}
}
