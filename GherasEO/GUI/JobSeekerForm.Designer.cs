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
            this.addButton = new System.Windows.Forms.Button();
            this.SearchTabPage = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.viewAllDataButton = new System.Windows.Forms.Button();
            this.nationalNumberMaskedTB = new System.Windows.Forms.MaskedTextBox();
            this.seacrchByNationalNumberButton = new System.Windows.Forms.Button();
            this.seacrchByNameButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchResultDataGridView = new System.Windows.Forms.DataGridView();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.addNewButton = new System.Windows.Forms.Button();
            this.updateExistingButton = new System.Windows.Forms.Button();
            this.page3 = new GherasEO.GUI.UserControls.Page3();
            this.page2 = new GherasEO.GUI.UserControls.Page2();
            this.page1 = new GherasEO.GUI.UserControls.Page1();
            this.tabControl1.SuspendLayout();
            this.addTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.currentPageGroupBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SearchTabPage.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addTabPage);
            this.tabControl1.Controls.Add(this.SearchTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 662);
            this.tabControl1.TabIndex = 2;
            // 
            // addTabPage
            // 
            this.addTabPage.Controls.Add(this.panel1);
            this.addTabPage.Location = new System.Drawing.Point(4, 22);
            this.addTabPage.Name = "addTabPage";
            this.addTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addTabPage.Size = new System.Drawing.Size(876, 636);
            this.addTabPage.TabIndex = 0;
            this.addTabPage.Text = "إضافة/تعديل";
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
            this.panel1.Size = new System.Drawing.Size(870, 630);
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
            this.currentPageGroupBox.Controls.Add(this.page3);
            this.currentPageGroupBox.Controls.Add(this.page2);
            this.currentPageGroupBox.Controls.Add(this.page1);
            this.currentPageGroupBox.Location = new System.Drawing.Point(118, 3);
            this.currentPageGroupBox.Name = "currentPageGroupBox";
            this.currentPageGroupBox.Size = new System.Drawing.Size(750, 565);
            this.currentPageGroupBox.TabIndex = 13;
            this.currentPageGroupBox.TabStop = false;
            this.currentPageGroupBox.Text = "الصفحة الأولى (1 من 3)";
            this.currentPageGroupBox.Enter += new System.EventHandler(this.currentPageGroupBox_Enter);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.updateExistingButton);
            this.panel3.Controls.Add(this.addNewButton);
            this.panel3.Controls.Add(this.addButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 572);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(870, 58);
            this.panel3.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(15, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 28);
            this.addButton.TabIndex = 44;
            this.addButton.Text = "حفظ التغييرات";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // SearchTabPage
            // 
            this.SearchTabPage.Controls.Add(this.panel6);
            this.SearchTabPage.Controls.Add(this.nationalNumberMaskedTB);
            this.SearchTabPage.Controls.Add(this.seacrchByNationalNumberButton);
            this.SearchTabPage.Controls.Add(this.seacrchByNameButton);
            this.SearchTabPage.Controls.Add(this.textBox1);
            this.SearchTabPage.Controls.Add(this.label3);
            this.SearchTabPage.Controls.Add(this.label2);
            this.SearchTabPage.Controls.Add(this.groupBox1);
            this.SearchTabPage.Location = new System.Drawing.Point(4, 22);
            this.SearchTabPage.Name = "SearchTabPage";
            this.SearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTabPage.Size = new System.Drawing.Size(876, 636);
            this.SearchTabPage.TabIndex = 3;
            this.SearchTabPage.Text = "بحث";
            this.SearchTabPage.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.viewAllDataButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 575);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(870, 58);
            this.panel6.TabIndex = 16;
            // 
            // viewAllDataButton
            // 
            this.viewAllDataButton.Location = new System.Drawing.Point(383, 14);
            this.viewAllDataButton.Name = "viewAllDataButton";
            this.viewAllDataButton.Size = new System.Drawing.Size(110, 28);
            this.viewAllDataButton.TabIndex = 44;
            this.viewAllDataButton.Text = "عرض كامل البيانات";
            this.viewAllDataButton.UseVisualStyleBackColor = true;
            this.viewAllDataButton.Click += new System.EventHandler(this.viewAllDataButton_Click);
            // 
            // nationalNumberMaskedTB
            // 
            this.nationalNumberMaskedTB.Location = new System.Drawing.Point(404, 66);
            this.nationalNumberMaskedTB.Mask = "0 0 0 0 0 0 0 0 0 0 0";
            this.nationalNumberMaskedTB.Name = "nationalNumberMaskedTB";
            this.nationalNumberMaskedTB.PromptChar = '0';
            this.nationalNumberMaskedTB.RejectInputOnFirstFailure = true;
            this.nationalNumberMaskedTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nationalNumberMaskedTB.Size = new System.Drawing.Size(160, 20);
            this.nationalNumberMaskedTB.TabIndex = 13;
            this.nationalNumberMaskedTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // seacrchByNationalNumberButton
            // 
            this.seacrchByNationalNumberButton.Location = new System.Drawing.Point(235, 66);
            this.seacrchByNationalNumberButton.Name = "seacrchByNationalNumberButton";
            this.seacrchByNationalNumberButton.Size = new System.Drawing.Size(147, 23);
            this.seacrchByNationalNumberButton.TabIndex = 6;
            this.seacrchByNationalNumberButton.Text = "بحث حسب الرقم الوطني";
            this.seacrchByNationalNumberButton.UseVisualStyleBackColor = true;
            this.seacrchByNationalNumberButton.Click += new System.EventHandler(this.seacrchByNationalNumberButton_Click);
            // 
            // seacrchByNameButton
            // 
            this.seacrchByNameButton.Location = new System.Drawing.Point(235, 32);
            this.seacrchByNameButton.Name = "seacrchByNameButton";
            this.seacrchByNameButton.Size = new System.Drawing.Size(147, 23);
            this.seacrchByNameButton.TabIndex = 5;
            this.seacrchByNameButton.Text = "بحث حسب الاسم";
            this.seacrchByNameButton.UseVisualStyleBackColor = true;
            this.seacrchByNameButton.Click += new System.EventHandler(this.seacrchByNameButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(404, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "الرقم الوطني:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " الاسم:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchResultDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(8, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 454);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نتائج البحث:";
            // 
            // searchResultDataGridView
            // 
            this.searchResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchResultDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.searchResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullName,
            this.nationalNumber});
            this.searchResultDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchResultDataGridView.Location = new System.Drawing.Point(3, 16);
            this.searchResultDataGridView.Name = "searchResultDataGridView";
            this.searchResultDataGridView.Size = new System.Drawing.Size(854, 68);
            this.searchResultDataGridView.TabIndex = 0;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "الاسم الكامل";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // nationalNumber
            // 
            this.nationalNumber.HeaderText = "الرقم الوطني";
            this.nationalNumber.Name = "nationalNumber";
            this.nationalNumber.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 670);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "المستخدم الحالي:";
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.Location = new System.Drawing.Point(106, 665);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(192, 23);
            this.currentUserLabel.TabIndex = 2;
            this.currentUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(746, 13);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(102, 28);
            this.addNewButton.TabIndex = 45;
            this.addNewButton.Text = "استمارة جديدة";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // updateExistingButton
            // 
            this.updateExistingButton.Location = new System.Drawing.Point(619, 13);
            this.updateExistingButton.Name = "updateExistingButton";
            this.updateExistingButton.Size = new System.Drawing.Size(121, 28);
            this.updateExistingButton.TabIndex = 46;
            this.updateExistingButton.Text = "تعديل استمارة سابقة";
            this.updateExistingButton.UseVisualStyleBackColor = true;
            this.updateExistingButton.Click += new System.EventHandler(this.updateExistingButton_Click);
            // 
            // page3
            // 
            this.page3.AutoSize = true;
            this.page3.Cursor = System.Windows.Forms.Cursors.Default;
            this.page3.Location = new System.Drawing.Point(28, 19);
            this.page3.Name = "page3";
            this.page3.Size = new System.Drawing.Size(715, 530);
            this.page3.TabIndex = 2;
            this.page3.Visible = false;
            // 
            // page2
            // 
            this.page2.AutoSize = true;
            this.page2.Location = new System.Drawing.Point(28, 23);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(703, 540);
            this.page2.TabIndex = 1;
            this.page2.Visible = false;
            // 
            // page1
            // 
            this.page1.AutoSize = true;
            this.page1.Location = new System.Drawing.Point(29, 23);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(715, 544);
            this.page1.TabIndex = 0;
            // 
            // JobSeekerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 691);
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
            this.Load += new System.EventHandler(this.JobSeekerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.addTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.currentPageGroupBox.ResumeLayout(false);
            this.currentPageGroupBox.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.SearchTabPage.ResumeLayout(false);
            this.SearchTabPage.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addTabPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.GroupBox currentPageGroupBox;
        private UserControls.Page1 page1;
        private UserControls.Page3 page3;
        private UserControls.Page2 page2;
        private System.Windows.Forms.TabPage SearchTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Button seacrchByNationalNumberButton;
        private System.Windows.Forms.Button seacrchByNameButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView searchResultDataGridView;
        internal System.Windows.Forms.MaskedTextBox nationalNumberMaskedTB;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button viewAllDataButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalNumber;
        private System.Windows.Forms.Button updateExistingButton;
        private System.Windows.Forms.Button addNewButton;
    }
}