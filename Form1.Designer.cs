
namespace Stopwatch
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.lblHours = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblMinutes = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblSeconds = new System.Windows.Forms.Label();
			this.start = new System.Windows.Forms.PictureBox();
			this.resume = new System.Windows.Forms.PictureBox();
			this.stop = new System.Windows.Forms.PictureBox();
			this.reset = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.resume)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reset)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.Controls.Add(this.reset, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.stop, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.resume, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.start, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 61);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(515, 35);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// lblHours
			// 
			this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lblHours.Location = new System.Drawing.Point(85, 9);
			this.lblHours.Name = "lblHours";
			this.lblHours.Size = new System.Drawing.Size(69, 49);
			this.lblHours.TabIndex = 2;
			this.lblHours.Text = "00";
			this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label2.Location = new System.Drawing.Point(160, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 49);
			this.label2.TabIndex = 3;
			this.label2.Text = ":";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMinutes
			// 
			this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lblMinutes.Location = new System.Drawing.Point(235, 9);
			this.lblMinutes.Name = "lblMinutes";
			this.lblMinutes.Size = new System.Drawing.Size(69, 49);
			this.lblMinutes.TabIndex = 4;
			this.lblMinutes.Text = "00";
			this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label4.Location = new System.Drawing.Point(310, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 49);
			this.label4.TabIndex = 5;
			this.label4.Text = ":";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSeconds
			// 
			this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lblSeconds.Location = new System.Drawing.Point(385, 9);
			this.lblSeconds.Name = "lblSeconds";
			this.lblSeconds.Size = new System.Drawing.Size(69, 49);
			this.lblSeconds.TabIndex = 6;
			this.lblSeconds.Text = "00";
			this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// start
			// 
			this.start.BackColor = System.Drawing.SystemColors.ControlLight;
			this.start.Dock = System.Windows.Forms.DockStyle.Fill;
			this.start.Image = ((System.Drawing.Image)(resources.GetObject("start.Image")));
			this.start.Location = new System.Drawing.Point(3, 3);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(122, 29);
			this.start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.start.TabIndex = 0;
			this.start.TabStop = false;
			this.start.Click += new System.EventHandler(this.start_Click);
			// 
			// resume
			// 
			this.resume.BackColor = System.Drawing.SystemColors.Control;
			this.resume.Dock = System.Windows.Forms.DockStyle.Fill;
			this.resume.Enabled = false;
			this.resume.Image = ((System.Drawing.Image)(resources.GetObject("resume.Image")));
			this.resume.Location = new System.Drawing.Point(131, 3);
			this.resume.Name = "resume";
			this.resume.Size = new System.Drawing.Size(122, 29);
			this.resume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.resume.TabIndex = 1;
			this.resume.TabStop = false;
			this.resume.Click += new System.EventHandler(this.resume_Click);
			// 
			// stop
			// 
			this.stop.BackColor = System.Drawing.SystemColors.Control;
			this.stop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stop.Enabled = false;
			this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
			this.stop.Location = new System.Drawing.Point(259, 3);
			this.stop.Name = "stop";
			this.stop.Size = new System.Drawing.Size(122, 29);
			this.stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.stop.TabIndex = 2;
			this.stop.TabStop = false;
			this.stop.Click += new System.EventHandler(this.stop_Click);
			// 
			// reset
			// 
			this.reset.BackColor = System.Drawing.SystemColors.Control;
			this.reset.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reset.Enabled = false;
			this.reset.Image = ((System.Drawing.Image)(resources.GetObject("reset.Image")));
			this.reset.Location = new System.Drawing.Point(387, 3);
			this.reset.Name = "reset";
			this.reset.Size = new System.Drawing.Size(125, 29);
			this.reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.reset.TabIndex = 3;
			this.reset.TabStop = false;
			this.reset.Click += new System.EventHandler(this.reset_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 107);
			this.Controls.Add(this.lblSeconds);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblMinutes);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblHours);
			this.Controls.Add(this.tableLayoutPanel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(351, 146);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "Stopwatch";
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.resume)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reset)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label lblHours;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblMinutes;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblSeconds;
		private System.Windows.Forms.PictureBox start;
		private System.Windows.Forms.PictureBox reset;
		private System.Windows.Forms.PictureBox stop;
		private System.Windows.Forms.PictureBox resume;
	}
}

