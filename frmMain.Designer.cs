namespace JDP {
	partial class frmMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.btnAbout = new System.Windows.Forms.Button();
			this.lblInstructions = new System.Windows.Forms.Label();
			this.grpExtract = new System.Windows.Forms.GroupBox();
			this.chkAudio = new System.Windows.Forms.CheckBox();
			this.chkTimeCodes = new System.Windows.Forms.CheckBox();
			this.chkVideo = new System.Windows.Forms.CheckBox();
			this.grpExtract.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAbout
			// 
			this.btnAbout.Location = new System.Drawing.Point(132, 132);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(63, 24);
			this.btnAbout.TabIndex = 2;
			this.btnAbout.Text = "A&bout";
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// lblInstructions
			// 
			this.lblInstructions.Location = new System.Drawing.Point(8, 8);
			this.lblInstructions.Name = "lblInstructions";
			this.lblInstructions.Size = new System.Drawing.Size(188, 56);
			this.lblInstructions.TabIndex = 0;
			this.lblInstructions.Text = "Drop FLV files here.\r\n\r\nOutput files are written in the same folder as the FLVs.";
			this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// grpExtract
			// 
			this.grpExtract.Controls.Add(this.chkAudio);
			this.grpExtract.Controls.Add(this.chkTimeCodes);
			this.grpExtract.Controls.Add(this.chkVideo);
			this.grpExtract.Location = new System.Drawing.Point(8, 72);
			this.grpExtract.Name = "grpExtract";
			this.grpExtract.Size = new System.Drawing.Size(96, 84);
			this.grpExtract.TabIndex = 1;
			this.grpExtract.TabStop = false;
			this.grpExtract.Text = "Extract:";
			// 
			// chkAudio
			// 
			this.chkAudio.Checked = true;
			this.chkAudio.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAudio.Location = new System.Drawing.Point(12, 60);
			this.chkAudio.Name = "chkAudio";
			this.chkAudio.Size = new System.Drawing.Size(80, 17);
			this.chkAudio.TabIndex = 2;
			this.chkAudio.Text = "&Audio";
			this.chkAudio.UseVisualStyleBackColor = true;
			// 
			// chkTimeCodes
			// 
			this.chkTimeCodes.Checked = true;
			this.chkTimeCodes.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTimeCodes.Location = new System.Drawing.Point(12, 40);
			this.chkTimeCodes.Name = "chkTimeCodes";
			this.chkTimeCodes.Size = new System.Drawing.Size(80, 17);
			this.chkTimeCodes.TabIndex = 1;
			this.chkTimeCodes.Text = "&Timecodes";
			this.chkTimeCodes.UseVisualStyleBackColor = true;
			// 
			// chkVideo
			// 
			this.chkVideo.Checked = true;
			this.chkVideo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkVideo.Location = new System.Drawing.Point(12, 20);
			this.chkVideo.Name = "chkVideo";
			this.chkVideo.Size = new System.Drawing.Size(80, 17);
			this.chkVideo.TabIndex = 0;
			this.chkVideo.Text = "&Video";
			this.chkVideo.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AllowDrop = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(203, 164);
			this.Controls.Add(this.grpExtract);
			this.Controls.Add(this.lblInstructions);
			this.Controls.Add(this.btnAbout);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FLV Extract";
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
			this.grpExtract.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Label lblInstructions;
		private System.Windows.Forms.GroupBox grpExtract;
		private System.Windows.Forms.CheckBox chkAudio;
		private System.Windows.Forms.CheckBox chkTimeCodes;
		private System.Windows.Forms.CheckBox chkVideo;
	}
}