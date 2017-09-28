namespace GherasEO.GUI.UserControls
{
    partial class Skills
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.skillsGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherSkillsGroupBox = new System.Windows.Forms.GroupBox();
            this.otherSkillsDataGridView = new System.Windows.Forms.DataGridView();
            this.skillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerSkillsGroupBox = new System.Windows.Forms.GroupBox();
            this.otherComputerSkillsGroupBox = new System.Windows.Forms.GroupBox();
            this.otherComputerSkillsDataGridView = new System.Windows.Forms.DataGridView();
            this.programName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerSkillsCheckList = new System.Windows.Forms.CheckedListBox();
            this.skillsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.otherSkillsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otherSkillsDataGridView)).BeginInit();
            this.computerSkillsGroupBox.SuspendLayout();
            this.otherComputerSkillsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otherComputerSkillsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // skillsGroupBox
            // 
            this.skillsGroupBox.Controls.Add(this.groupBox1);
            this.skillsGroupBox.Controls.Add(this.otherSkillsGroupBox);
            this.skillsGroupBox.Controls.Add(this.computerSkillsGroupBox);
            this.skillsGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.skillsGroupBox.Location = new System.Drawing.Point(0, 1);
            this.skillsGroupBox.Name = "skillsGroupBox";
            this.skillsGroupBox.Size = new System.Drawing.Size(645, 217);
            this.skillsGroupBox.TabIndex = 40;
            this.skillsGroupBox.TabStop = false;
            this.skillsGroupBox.Text = "المهارات:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 95);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لغات:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.language,
            this.level});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(329, 76);
            this.dataGridView1.TabIndex = 5;
            // 
            // language
            // 
            this.language.HeaderText = "اللغة";
            this.language.Name = "language";
            // 
            // level
            // 
            this.level.HeaderText = "المستوى";
            this.level.Name = "level";
            // 
            // otherSkillsGroupBox
            // 
            this.otherSkillsGroupBox.Controls.Add(this.otherSkillsDataGridView);
            this.otherSkillsGroupBox.Location = new System.Drawing.Point(3, 113);
            this.otherSkillsGroupBox.Name = "otherSkillsGroupBox";
            this.otherSkillsGroupBox.Size = new System.Drawing.Size(335, 95);
            this.otherSkillsGroupBox.TabIndex = 6;
            this.otherSkillsGroupBox.TabStop = false;
            this.otherSkillsGroupBox.Text = "مهارات أخرى";
            // 
            // otherSkillsDataGridView
            // 
            this.otherSkillsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.otherSkillsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.otherSkillsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otherSkillsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skillName});
            this.otherSkillsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otherSkillsDataGridView.Location = new System.Drawing.Point(3, 16);
            this.otherSkillsDataGridView.Name = "otherSkillsDataGridView";
            this.otherSkillsDataGridView.Size = new System.Drawing.Size(329, 76);
            this.otherSkillsDataGridView.TabIndex = 7;
            // 
            // skillName
            // 
            this.skillName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.skillName.HeaderText = "اسم المهارة";
            this.skillName.Name = "skillName";
            // 
            // computerSkillsGroupBox
            // 
            this.computerSkillsGroupBox.Controls.Add(this.otherComputerSkillsGroupBox);
            this.computerSkillsGroupBox.Controls.Add(this.computerSkillsCheckList);
            this.computerSkillsGroupBox.Location = new System.Drawing.Point(344, 15);
            this.computerSkillsGroupBox.Name = "computerSkillsGroupBox";
            this.computerSkillsGroupBox.Size = new System.Drawing.Size(295, 193);
            this.computerSkillsGroupBox.TabIndex = 0;
            this.computerSkillsGroupBox.TabStop = false;
            this.computerSkillsGroupBox.Text = "مهارات حاسوبية:";
            // 
            // otherComputerSkillsGroupBox
            // 
            this.otherComputerSkillsGroupBox.Controls.Add(this.otherComputerSkillsDataGridView);
            this.otherComputerSkillsGroupBox.Location = new System.Drawing.Point(25, 52);
            this.otherComputerSkillsGroupBox.Name = "otherComputerSkillsGroupBox";
            this.otherComputerSkillsGroupBox.Size = new System.Drawing.Size(160, 90);
            this.otherComputerSkillsGroupBox.TabIndex = 2;
            this.otherComputerSkillsGroupBox.TabStop = false;
            this.otherComputerSkillsGroupBox.Text = "برامج أخرى";
            // 
            // otherComputerSkillsDataGridView
            // 
            this.otherComputerSkillsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.otherComputerSkillsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.otherComputerSkillsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otherComputerSkillsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.programName});
            this.otherComputerSkillsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otherComputerSkillsDataGridView.Location = new System.Drawing.Point(3, 16);
            this.otherComputerSkillsDataGridView.Name = "otherComputerSkillsDataGridView";
            this.otherComputerSkillsDataGridView.Size = new System.Drawing.Size(154, 71);
            this.otherComputerSkillsDataGridView.TabIndex = 3;
            // 
            // programName
            // 
            this.programName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.programName.HeaderText = "اسم البرنامج";
            this.programName.Name = "programName";
            // 
            // computerSkillsCheckList
            // 
            this.computerSkillsCheckList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.computerSkillsCheckList.FormattingEnabled = true;
            this.computerSkillsCheckList.Items.AddRange(new object[] {
            "Photoshop",
            "Autocad",
            "Access",
            "PowerPoint",
            "Word",
            "Excel"});
            this.computerSkillsCheckList.Location = new System.Drawing.Point(191, 52);
            this.computerSkillsCheckList.Name = "computerSkillsCheckList";
            this.computerSkillsCheckList.Size = new System.Drawing.Size(87, 90);
            this.computerSkillsCheckList.TabIndex = 1;
            this.computerSkillsCheckList.UseWaitCursor = true;
            // 
            // Skills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skillsGroupBox);
            this.Name = "Skills";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(645, 221);
            this.skillsGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.otherSkillsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.otherSkillsDataGridView)).EndInit();
            this.computerSkillsGroupBox.ResumeLayout(false);
            this.otherComputerSkillsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.otherComputerSkillsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox skillsGroupBox;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn language;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        internal System.Windows.Forms.DataGridView otherSkillsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillName;
        private System.Windows.Forms.GroupBox otherComputerSkillsGroupBox;
        internal System.Windows.Forms.DataGridView otherComputerSkillsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn programName;
        internal System.Windows.Forms.CheckedListBox computerSkillsCheckList;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.GroupBox otherSkillsGroupBox;
        internal System.Windows.Forms.GroupBox computerSkillsGroupBox;
    }
}
