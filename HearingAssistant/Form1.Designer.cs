
namespace HearingAssistant
{
	partial class MainWindow
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
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SameButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(34, 74);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(120, 120);
            this.LeftButton.TabIndex = 0;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(322, 74);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(120, 120);
            this.RightButton.TabIndex = 1;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Label.Location = new System.Drawing.Point(147, 31);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(183, 24);
            this.Label.TabIndex = 2;
            this.Label.Text = "Which ear is louder?";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(178, 217);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(120, 38);
            this.PlayButton.TabIndex = 5;
            this.PlayButton.Text = "Play Sound";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // SameButton
            // 
            this.SameButton.Location = new System.Drawing.Point(178, 74);
            this.SameButton.Name = "SameButton";
            this.SameButton.Size = new System.Drawing.Size(120, 120);
            this.SameButton.TabIndex = 7;
            this.SameButton.Text = "Sounds the same \r\n(Set Computer Audio)";
            this.SameButton.UseVisualStyleBackColor = true;
            this.SameButton.Click += new System.EventHandler(this.SameButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(178, 278);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(120, 38);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset Computer Audio";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 349);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SameButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Name = "MainWindow";
            this.Text = "Hearing Assistant";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button LeftButton;
		private System.Windows.Forms.Button RightButton;
		private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button SameButton;
        private System.Windows.Forms.Button ResetButton;
    }
}

