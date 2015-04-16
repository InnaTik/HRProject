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
            // MainHRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
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
    }
}

