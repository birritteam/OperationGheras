namespace GherasEO.GUI
{
    partial class JobSeekerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.currentPageGroupBox = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteTabPage = new System.Windows.Forms.TabPage();
            this.UpdateTabPage = new System.Windows.Forms.TabPage();
            this.SearchTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.page3 = new GherasEO.GUI.UserControls.Page3();
            this.page2 = new GherasEO.GUI.UserControls.Page2();
            this.page1 = new GherasEO.GUI.UserControls.Page1();
            this.tabControl1.SuspendLayout();
            this.addTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.currentPageGroupBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addTabPage);
            this.tabControl1.Controls.Add(this.deleteTabPage);
            this.tabControl1.Controls.Add(this.UpdateTabPage);
            this.tabControl1.Controls.Add(this.SearchTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 638);
            this.tabControl1.TabIndex = 0;
            // 
            // addTabPage
            // 
            this.addTabPage.Controls.Add(this.panel1);
            this.addTabPage.Location = new System.Drawing.Point(4, 22);
            this.addTabPage.Name = "addTabPage";
            this.addTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addTabPage.Size = new System.Drawing.Size(779, 612);
            this.addTabPage.TabIndex = 0;
            this.addTabPage.Text = "إضافة";
            this.addTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.currentPageGroupBox);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 606);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nextButton);
            this.panel2.Controls.Add(this.previousButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 565);
            this.panel2.TabIndex = 14;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(16, 271);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = "التالي";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Enabled = false;
            this.previousButton.Location = new System.Drawing.Point(16, 300);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 9;
            this.previousButton.Text = "السابق";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // currentPageGroupBox
            // 
            this.currentPageGroupBox.AutoSize = true;
            this.currentPageGroupBox.Controls.Add(this.page3);
            this.currentPageGroupBox.Controls.Add(this.page2);
            this.currentPageGroupBox.Controls.Add(this.page1);
            this.currentPageGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.currentPageGroupBox.Location = new System.Drawing.Point(109, 0);
            this.currentPageGroupBox.Name = "currentPageGroupBox";
            this.currentPageGroupBox.Size = new System.Drawing.Size(664, 565);
            this.currentPageGroupBox.TabIndex = 13;
            this.currentPageGroupBox.TabStop = false;
            this.currentPageGroupBox.Text = "الصفحة الأولى (1 من 3)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.addButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 565);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 41);
            this.panel3.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(275, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 28);
            this.button5.TabIndex = 45;
            this.button5.Text = "مسح البيانات";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(386, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 28);
            this.addButton.TabIndex = 44;
            this.addButton.Text = "إضافة";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteTabPage
            // 
            this.deleteTabPage.Location = new System.Drawing.Point(4, 22);
            this.deleteTabPage.Name = "deleteTabPage";
            this.deleteTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.deleteTabPage.Size = new System.Drawing.Size(779, 612);
            this.deleteTabPage.TabIndex = 1;
            this.deleteTabPage.Text = "حذف";
            this.deleteTabPage.UseVisualStyleBackColor = true;
            // 
            // UpdateTabPage
            // 
            this.UpdateTabPage.Location = new System.Drawing.Point(4, 22);
            this.UpdateTabPage.Name = "UpdateTabPage";
            this.UpdateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateTabPage.Size = new System.Drawing.Size(779, 612);
            this.UpdateTabPage.TabIndex = 2;
            this.UpdateTabPage.Text = "تعديل";
            this.UpdateTabPage.UseVisualStyleBackColor = true;
            // 
            // SearchTabPage
            // 
            this.SearchTabPage.Location = new System.Drawing.Point(4, 22);
            this.SearchTabPage.Name = "SearchTabPage";
            this.SearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTabPage.Size = new System.Drawing.Size(779, 612);
            this.SearchTabPage.TabIndex = 3;
            this.SearchTabPage.Text = "بحث";
            this.SearchTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 641);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "المستخدم الحالي:";
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.Location = new System.Drawing.Point(103, 637);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(192, 23);
            this.currentUserLabel.TabIndex = 2;
            this.currentUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // page3
            // 
            this.page3.Cursor = System.Windows.Forms.Cursors.Default;
            this.page3.Location = new System.Drawing.Point(3, 19);
            this.page3.Name = "page3";
            this.page3.Size = new System.Drawing.Size(650, 530);
            this.page3.TabIndex = 2;
            this.page3.Visible = false;
            // 
            // page2
            // 
            this.page2.Location = new System.Drawing.Point(8, 19);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(645, 540);
            this.page2.TabIndex = 1;
            this.page2.Visible = false;
            // 
            // page1
            // 
            this.page1.Location = new System.Drawing.Point(13, 19);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(645, 544);
            this.page1.TabIndex = 0;
            // 
            // JobSeekerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 661);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JobSeekerForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "استمارة باحث عن عمل";
            this.tabControl1.ResumeLayout(false);
            this.addTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.currentPageGroupBox.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addTabPage;
        private System.Windows.Forms.TabPage deleteTabPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.GroupBox currentPageGroupBox;
        private UserControls.Page1 page1;
        private UserControls.Page3 page3;
        private UserControls.Page2 page2;
        private System.Windows.Forms.TabPage UpdateTabPage;
        private System.Windows.Forms.TabPage SearchTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentUserLabel;
    }
}