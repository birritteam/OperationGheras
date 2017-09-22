namespace GherasEO
{
    partial class educationAndExpertise
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
            this.trainerCoursesGroupBox = new System.Windows.Forms.GroupBox();
            this.trainerCoursesDataGridView = new System.Windows.Forms.DataGridView();
            this.courseNameT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseLocationT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDateT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingDaysT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingHoursT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traineeCoursesGroupBox = new System.Windows.Forms.GroupBox();
            this.traineeCoursesDataGridView = new System.Windows.Forms.DataGridView();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expertiseGroupBox = new System.Windows.Forms.GroupBox();
            this.expertiseDataGridView = new System.Windows.Forms.DataGridView();
            this.corporationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corporationLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonsOfLeaving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationGroupBox = new System.Windows.Forms.GroupBox();
            this.educationDataGridView = new System.Windows.Forms.DataGridView();
            this.certificate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certifcateIssuer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicYear = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.certificateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainerCoursesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainerCoursesDataGridView)).BeginInit();
            this.traineeCoursesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeCoursesDataGridView)).BeginInit();
            this.expertiseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expertiseDataGridView)).BeginInit();
            this.educationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.educationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // trainerCoursesGroupBox
            // 
            this.trainerCoursesGroupBox.Controls.Add(this.trainerCoursesDataGridView);
            this.trainerCoursesGroupBox.Location = new System.Drawing.Point(0, 330);
            this.trainerCoursesGroupBox.Name = "trainerCoursesGroupBox";
            this.trainerCoursesGroupBox.Size = new System.Drawing.Size(640, 105);
            this.trainerCoursesGroupBox.TabIndex = 41;
            this.trainerCoursesGroupBox.TabStop = false;
            this.trainerCoursesGroupBox.Text = "أهم الدورات التدريبية (مدربا):";
            // 
            // trainerCoursesDataGridView
            // 
            this.trainerCoursesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.trainerCoursesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.trainerCoursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainerCoursesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseNameT,
            this.courseLocationT,
            this.courseDateT,
            this.trainingDaysT,
            this.trainingHoursT});
            this.trainerCoursesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainerCoursesDataGridView.Location = new System.Drawing.Point(3, 16);
            this.trainerCoursesDataGridView.Name = "trainerCoursesDataGridView";
            this.trainerCoursesDataGridView.Size = new System.Drawing.Size(634, 86);
            this.trainerCoursesDataGridView.TabIndex = 1;
            this.trainerCoursesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.trainerCoursesDataGridView_CellContentClick);
            // 
            // courseNameT
            // 
            this.courseNameT.HeaderText = "اسم الدورة";
            this.courseNameT.Name = "courseNameT";
            // 
            // courseLocationT
            // 
            this.courseLocationT.HeaderText = "مكان الدورة";
            this.courseLocationT.Name = "courseLocationT";
            // 
            // courseDateT
            // 
            this.courseDateT.HeaderText = "تاريخ الدورة";
            this.courseDateT.Name = "courseDateT";
            // 
            // trainingDaysT
            // 
            this.trainingDaysT.HeaderText = "عدد أيام التدريب";
            this.trainingDaysT.Name = "trainingDaysT";
            // 
            // trainingHoursT
            // 
            this.trainingHoursT.HeaderText = "الساعات التدريبية";
            this.trainingHoursT.Name = "trainingHoursT";
            // 
            // traineeCoursesGroupBox
            // 
            this.traineeCoursesGroupBox.Controls.Add(this.traineeCoursesDataGridView);
            this.traineeCoursesGroupBox.Location = new System.Drawing.Point(0, 219);
            this.traineeCoursesGroupBox.Name = "traineeCoursesGroupBox";
            this.traineeCoursesGroupBox.Size = new System.Drawing.Size(640, 105);
            this.traineeCoursesGroupBox.TabIndex = 40;
            this.traineeCoursesGroupBox.TabStop = false;
            this.traineeCoursesGroupBox.Text = "أهم الدورات التدريبية (متدربا):";
            // 
            // traineeCoursesDataGridView
            // 
            this.traineeCoursesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.traineeCoursesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.traineeCoursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traineeCoursesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.CourseLocation,
            this.courseDate,
            this.trainingDays,
            this.trainingHours});
            this.traineeCoursesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.traineeCoursesDataGridView.Location = new System.Drawing.Point(3, 16);
            this.traineeCoursesDataGridView.Name = "traineeCoursesDataGridView";
            this.traineeCoursesDataGridView.Size = new System.Drawing.Size(634, 86);
            this.traineeCoursesDataGridView.TabIndex = 1;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "اسم الدورة";
            this.CourseName.Name = "CourseName";
            // 
            // CourseLocation
            // 
            this.CourseLocation.HeaderText = "مكان الدورة";
            this.CourseLocation.Name = "CourseLocation";
            // 
            // courseDate
            // 
            this.courseDate.HeaderText = "تاريخ الدورة";
            this.courseDate.Name = "courseDate";
            // 
            // trainingDays
            // 
            this.trainingDays.HeaderText = "عدد أيام التدريب";
            this.trainingDays.Name = "trainingDays";
            // 
            // trainingHours
            // 
            this.trainingHours.HeaderText = "الساعات التدريبية";
            this.trainingHours.Name = "trainingHours";
            // 
            // expertiseGroupBox
            // 
            this.expertiseGroupBox.Controls.Add(this.expertiseDataGridView);
            this.expertiseGroupBox.Location = new System.Drawing.Point(0, 108);
            this.expertiseGroupBox.Name = "expertiseGroupBox";
            this.expertiseGroupBox.Size = new System.Drawing.Size(640, 105);
            this.expertiseGroupBox.TabIndex = 39;
            this.expertiseGroupBox.TabStop = false;
            this.expertiseGroupBox.Text = "الخبرات العملية (ابتداء من آخر عمل): ";
            // 
            // expertiseDataGridView
            // 
            this.expertiseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expertiseDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.expertiseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expertiseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.corporationName,
            this.corporationLocation,
            this.workField,
            this.jobTitle,
            this.startDate,
            this.endDate,
            this.reasonsOfLeaving});
            this.expertiseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expertiseDataGridView.Location = new System.Drawing.Point(3, 16);
            this.expertiseDataGridView.Name = "expertiseDataGridView";
            this.expertiseDataGridView.Size = new System.Drawing.Size(634, 86);
            this.expertiseDataGridView.TabIndex = 1;
            // 
            // corporationName
            // 
            this.corporationName.HeaderText = "اسم الشركة";
            this.corporationName.Name = "corporationName";
            // 
            // corporationLocation
            // 
            this.corporationLocation.HeaderText = "موقع العمل";
            this.corporationLocation.Name = "corporationLocation";
            // 
            // workField
            // 
            this.workField.HeaderText = "مجال عمل الشركة";
            this.workField.Name = "workField";
            // 
            // jobTitle
            // 
            this.jobTitle.HeaderText = "المسمى الوظيفي";
            this.jobTitle.Name = "jobTitle";
            // 
            // startDate
            // 
            this.startDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.startDate.HeaderText = "الدخول";
            this.startDate.Name = "startDate";
            this.startDate.Width = 63;
            // 
            // endDate
            // 
            this.endDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.endDate.HeaderText = "الخروج";
            this.endDate.Name = "endDate";
            this.endDate.Width = 62;
            // 
            // reasonsOfLeaving
            // 
            this.reasonsOfLeaving.HeaderText = "أسباب ترك العمل";
            this.reasonsOfLeaving.Name = "reasonsOfLeaving";
            // 
            // educationGroupBox
            // 
            this.educationGroupBox.Controls.Add(this.educationDataGridView);
            this.educationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.educationGroupBox.Name = "educationGroupBox";
            this.educationGroupBox.Size = new System.Drawing.Size(640, 105);
            this.educationGroupBox.TabIndex = 38;
            this.educationGroupBox.TabStop = false;
            this.educationGroupBox.Text = "التحصيل العلمي:";
            // 
            // educationDataGridView
            // 
            this.educationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.educationDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.educationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.educationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.certificate,
            this.certifcateIssuer,
            this.academicYear,
            this.certificateDate});
            this.educationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.educationDataGridView.Location = new System.Drawing.Point(3, 16);
            this.educationDataGridView.Name = "educationDataGridView";
            this.educationDataGridView.Size = new System.Drawing.Size(634, 86);
            this.educationDataGridView.TabIndex = 1;
            // 
            // certificate
            // 
            this.certificate.HeaderText = "الشهادة";
            this.certificate.Name = "certificate";
            // 
            // certifcateIssuer
            // 
            this.certifcateIssuer.HeaderText = "الجهة المانحة";
            this.certifcateIssuer.Name = "certifcateIssuer";
            // 
            // academicYear
            // 
            this.academicYear.HeaderText = "السنة الدراسية";
            this.academicYear.Items.AddRange(new object[] {
            "أولى",
            "ثانية",
            "ثالثة",
            "رابعة",
            "خامسة",
            "سادسة",
            "متخرج"});
            this.academicYear.Name = "academicYear";
            this.academicYear.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.academicYear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // certificateDate
            // 
            this.certificateDate.HeaderText = "تاريخ المنح";
            this.certificateDate.Name = "certificateDate";
            // 
            // educationAndExpertise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trainerCoursesGroupBox);
            this.Controls.Add(this.traineeCoursesGroupBox);
            this.Controls.Add(this.expertiseGroupBox);
            this.Controls.Add(this.educationGroupBox);
            this.Name = "educationAndExpertise";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(640, 435);
            this.trainerCoursesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainerCoursesDataGridView)).EndInit();
            this.traineeCoursesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.traineeCoursesDataGridView)).EndInit();
            this.expertiseGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expertiseDataGridView)).EndInit();
            this.educationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.educationDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameT;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseLocationT;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDateT;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingDaysT;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingHoursT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn corporationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn corporationLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn workField;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonsOfLeaving;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificate;
        private System.Windows.Forms.DataGridViewTextBoxColumn certifcateIssuer;
        private System.Windows.Forms.DataGridViewComboBoxColumn academicYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificateDate;
        internal System.Windows.Forms.DataGridView educationDataGridView;
        internal System.Windows.Forms.GroupBox trainerCoursesGroupBox;
        internal System.Windows.Forms.DataGridView trainerCoursesDataGridView;
        internal System.Windows.Forms.GroupBox traineeCoursesGroupBox;
        internal System.Windows.Forms.DataGridView traineeCoursesDataGridView;
        internal System.Windows.Forms.GroupBox expertiseGroupBox;
        internal System.Windows.Forms.DataGridView expertiseDataGridView;
        internal System.Windows.Forms.GroupBox educationGroupBox;
    }
}
