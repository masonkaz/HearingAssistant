
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
            this.label1 = new System.Windows.Forms.Label();
            this.ReplayButton = new System.Windows.Forms.Button();
            this.SameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(62, 103);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(120, 120);
            this.LeftButton.TabIndex = 0;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(350, 103);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(120, 120);
            this.RightButton.TabIndex = 1;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(182, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Which ear is louder?";
            // 
            // ReplayButton
            // 
            this.ReplayButton.Location = new System.Drawing.Point(206, 246);
            this.ReplayButton.Name = "ReplayButton";
            this.ReplayButton.Size = new System.Drawing.Size(120, 38);
            this.ReplayButton.TabIndex = 5;
            this.ReplayButton.Text = "Replay";
            this.ReplayButton.UseVisualStyleBackColor = true;
            // 
            // SameButton
            // 
            this.SameButton.Location = new System.Drawing.Point(206, 103);
            this.SameButton.Name = "SameButton";
            this.SameButton.Size = new System.Drawing.Size(120, 120);
            this.SameButton.TabIndex = 7;
            this.SameButton.Text = "Sounds the same";
            this.SameButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 358);
            this.Controls.Add(this.SameButton);
            this.Controls.Add(this.ReplayButton);
            this.Controls.Add(this.label1);
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
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReplayButton;
        private System.Windows.Forms.Button SameButton;
    }
}

