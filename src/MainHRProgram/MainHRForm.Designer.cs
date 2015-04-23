namespace MainHRProgram
{
    partial class MainHRForm
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
            this.HRMainLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resumeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HRMainLabel
            // 
            this.HRMainLabel.AutoSize = true;
            this.HRMainLabel.Location = new System.Drawing.Point(73, 62);
            this.HRMainLabel.Name = "HRMainLabel";
            this.HRMainLabel.Size = new System.Drawing.Size(141, 13);
            this.HRMainLabel.TabIndex = 0;
            this.HRMainLabel.Text = "HR: vacancies and resumes";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(90, 124);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(50, 13);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "version 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seach Vacancies";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resumeButton
            // 
            this.resumeButton.BackColor = System.Drawing.Color.Green;
            this.resumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resumeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.resumeButton.Location = new System.Drawing.Point(163, 228);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(103, 23);
            this.resumeButton.TabIndex = 2;
            this.resumeButton.Text = "Search resumes";
            this.resumeButton.UseVisualStyleBackColor = false;
            this.resumeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainHRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.HRMainLabel);
            this.Name = "MainHRForm";
            this.Text = "HR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HRMainLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button resumeButton;
    }
}

