namespace GherasEO
{
    partial class MainUI
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
            this.jobSeekerButton = new System.Windows.Forms.Button();
            this.jobOwnerButton = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.switchUserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // jobSeekerButton
            // 
            this.jobSeekerButton.Location = new System.Drawing.Point(394, 99);
            this.jobSeekerButton.Name = "jobSeekerButton";
            this.jobSeekerButton.Size = new System.Drawing.Size(151, 62);
            this.jobSeekerButton.TabIndex = 0;
            this.jobSeekerButton.Text = "باحث عن عمل";
            this.jobSeekerButton.UseVisualStyleBackColor = true;
            this.jobSeekerButton.Click += new System.EventHandler(this.jobSeekerButton_Click);
            // 
            // jobOwnerButton
            // 
            this.jobOwnerButton.Location = new System.Drawing.Point(244, 99);
            this.jobOwnerButton.Name = "jobOwnerButton";
            this.jobOwnerButton.Size = new System.Drawing.Size(144, 62);
            this.jobOwnerButton.TabIndex = 1;
            this.jobOwnerButton.Text = "صاحب عمل";
            this.jobOwnerButton.UseVisualStyleBackColor = true;
            // 
            // statisticsButton
            // 
            this.statisticsButton.Location = new System.Drawing.Point(90, 99);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(148, 62);
            this.statisticsButton.TabIndex = 2;
            this.statisticsButton.Text = "إحصائيات وتقارير";
            this.statisticsButton.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(160, 3);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(151, 29);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "تسجيل خروج";
            this.logOutButton.UseVisualStyleBackColor = true;
            // 
            // switchUserButton
            // 
            this.switchUserButton.Location = new System.Drawing.Point(3, 3);
            this.switchUserButton.Name = "switchUserButton";
            this.switchUserButton.Size = new System.Drawing.Size(151, 29);
            this.switchUserButton.TabIndex = 4;
            this.switchUserButton.Text = "تبديل المستخدم";
            this.switchUserButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 11);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "المستخدم الحالي:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statisticsButton);
            this.panel1.Controls.Add(this.jobOwnerButton);
            this.panel1.Controls.Add(this.jobSeekerButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 266);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.currentUserLabel);
            this.panel2.Controls.Add(this.switchUserButton);
            this.panel2.Controls.Add(this.logOutButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 35);
            this.panel2.TabIndex = 7;
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.Location = new System.Drawing.Point(317, 7);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.currentUserLabel.Size = new System.Drawing.Size(235, 21);
            this.currentUserLabel.TabIndex = 6;
            this.currentUserLabel.Text = " ";
            this.currentUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 328);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامج التشغيل - الواجهة الرئيسية";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jobSeekerButton;
        private System.Windows.Forms.Button jobOwnerButton;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button switchUserButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label currentUserLabel;
    }
}

