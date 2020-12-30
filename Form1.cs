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

			updater.Tick += (sender, e) =>
			{
				hours = stopwatch.Elapsed.Hours;
				minutes = stopwatch.Elapsed.Minutes;
				seconds = stopwatch.Elapsed.Seconds;

				if (hours > 24 && (minutes == 60 && seconds == 60))
				{
					MessageBox.Show("Time limit exceeded. Please reset Stopwatch to continue.", "Time Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				lblHours.Text = string.Format("{0:D2}", hours);
				lblMinutes.Text = string.Format("{0:D2}", minutes);
				lblSeconds.Text = string.Format("{0:D2}", seconds);

				Application.DoEvents();
			};
		}

		private stopwatch stopwatch;
		private Timer updater;
		private ITransitionType linear = new TransitionType_Linear(100);

		private int hours = 0;
		private int minutes = 0;
		private int seconds = 0;

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

			stopwatch.Reset();

			lblHours.Text = hours.ToString("00");
			lblMinutes.Text = minutes.ToString("00");
			lblSeconds.Text = seconds.ToString("00");
		}
	}
}
