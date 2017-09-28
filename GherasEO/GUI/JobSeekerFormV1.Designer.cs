namespace GherasEO
{
    partial class JobSeekerFormV1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.deleteTabPage = new System.Windows.Forms.TabPage();
            this.updateTabPage = new System.Windows.Forms.TabPage();
            this.searchTabPage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.jobSeekerInformationPanel13 = new GherasEO.jobSeekerInformationPanel1();
            this.jobSeekerInformationPanel23 = new GherasEO.jobSeekerInformationPanel2();
            this.tabControl1.SuspendLayout();
            this.addTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addTabPage);
            this.tabControl1.Controls.Add(this.deleteTabPage);
            this.tabControl1.Controls.Add(this.updateTabPage);
            this.tabControl1.Controls.Add(this.searchTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1179, 662);
            this.tabControl1.TabIndex = 0;
            // 
            // addTabPage
            // 
            this.addTabPage.AutoScroll = true;
            this.addTabPage.Controls.Add(this.splitContainer2);
            this.addTabPage.Controls.Add(this.panel3);
            this.addTabPage.Location = new System.Drawing.Point(4, 22);
            this.addTabPage.Name = "addTabPage";
            this.addTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addTabPage.Size = new System.Drawing.Size(1171, 636);
            this.addTabPage.TabIndex = 0;
            this.addTabPage.Text = "إضافة";
            this.addTabPage.UseVisualStyleBackColor = true;
            this.addTabPage.Click += new System.EventHandler(this.addTabPage_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.jobSeekerInformationPanel13);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.jobSeekerInformationPanel23);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(1165, 570);
            this.splitContainer2.SplitterDistance = 485;
            this.splitContainer2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 573);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1165, 60);
            this.panel3.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(452, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 28);
            this.button5.TabIndex = 45;
            this.button5.Text = "مسح البيانات";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(563, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 28);
            this.button6.TabIndex = 44;
            this.button6.Text = "إضافة";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // deleteTabPage
            // 
            this.deleteTabPage.Location = new System.Drawing.Point(4, 22);
            this.deleteTabPage.Name = "deleteTabPage";
            this.deleteTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.deleteTabPage.Size = new System.Drawing.Size(1171, 636);
            this.deleteTabPage.TabIndex = 1;
            this.deleteTabPage.Text = "حذف";
            this.deleteTabPage.UseVisualStyleBackColor = true;
            // 
            // updateTabPage
            // 
            this.updateTabPage.Location = new System.Drawing.Point(4, 22);
            this.updateTabPage.Name = "updateTabPage";
            this.updateTabPage.Size = new System.Drawing.Size(1171, 636);
            this.updateTabPage.TabIndex = 2;
            this.updateTabPage.Text = "تعديل";
            this.updateTabPage.UseVisualStyleBackColor = true;
            // 
            // searchTabPage
            // 
            this.searchTabPage.Location = new System.Drawing.Point(4, 22);
            this.searchTabPage.Name = "searchTabPage";
            this.searchTabPage.Size = new System.Drawing.Size(1171, 636);
            this.searchTabPage.TabIndex = 3;
            this.searchTabPage.Text = "بحث";
            this.searchTabPage.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.currentUserLabel);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 660);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1179, 26);
            this.panel4.TabIndex = 1;
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.Location = new System.Drawing.Point(829, 3);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.currentUserLabel.Size = new System.Drawing.Size(235, 21);
            this.currentUserLabel.TabIndex = 49;
            this.currentUserLabel.Text = " ";
            this.currentUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(1070, 7);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(93, 13);
            this.label26.TabIndex = 48;
            this.label26.Text = "المستخدم الحالي:";
            // 
            // jobSeekerInformationPanel13
            // 
            this.jobSeekerInformationPanel13.AutoSize = true;
            this.jobSeekerInformationPanel13.Location = new System.Drawing.Point(3, 3);
            this.jobSeekerInformationPanel13.Name = "jobSeekerInformationPanel13";
            this.jobSeekerInformationPanel13.Size = new System.Drawing.Size(453, 804);
            this.jobSeekerInformationPanel13.TabIndex = 0;
            // 
            // jobSeekerInformationPanel23
            // 
            this.jobSeekerInformationPanel23.AutoSize = true;
            this.jobSeekerInformationPanel23.Location = new System.Drawing.Point(9, 4);
            this.jobSeekerInformationPanel23.Name = "jobSeekerInformationPanel23";
            this.jobSeekerInformationPanel23.Size = new System.Drawing.Size(646, 826);
            this.jobSeekerInformationPanel23.TabIndex = 0;
            // 
            // JobSeekerFormV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 686);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JobSeekerFormV1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "باحث عن عمل";
            this.Load += new System.EventHandler(this.JobSeekerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.addTabPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addTabPage;
        private System.Windows.Forms.TabPage deleteTabPage;
        private System.Windows.Forms.TabPage updateTabPage;
        private System.Windows.Forms.TabPage searchTabPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        internal jobSeekerInformationPanel1 jobSeekerInformationPanel13;
        internal jobSeekerInformationPanel2 jobSeekerInformationPanel23;
    }
}