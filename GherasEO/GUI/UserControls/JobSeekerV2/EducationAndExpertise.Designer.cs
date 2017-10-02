namespace GherasEO.GUI.UserControls
{
    partial class EducationAndExpertise
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
            this.educationDataGridView = new System.Windows.Forms.DataGridView();
            this.reasonsOfLeaving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corporationLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corporationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expertiseDataGridView = new System.Windows.Forms.DataGridView();
            this.trainerCoursesGroupBox = new System.Windows.Forms.GroupBox();
            this.trainerCoursesDataGridView = new System.Windows.Forms.DataGridView();
            this.courseNameT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseLocationT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDateT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingDaysT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingHoursT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traineeCoursesDataGridView = new System.Windows.Forms.DataGridView();
            this.trainingHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traineeCoursesGroupBox = new System.Windows.Forms.GroupBox();
            this.educationGroupBox = new System.Windows.Forms.GroupBox();
            this.expertiseGroupBox = new System.Windows.Forms.GroupBox();
            this.certificate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certifcateIssuer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.educationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertiseDataGridView)).BeginInit();
            this.trainerCoursesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainerCoursesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeCoursesDataGridView)).BeginInit();
            this.traineeCoursesGroupBox.SuspendLayout();
            this.educationGroupBox.SuspendLayout();
            this.expertiseGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.educationDataGridView.RowTemplate.Height = 30;
            this.educationDataGridView.Size = new System.Drawing.Size(639, 106);
            this.educationDataGridView.TabIndex = 1;
            // 
            // reasonsOfLeaving
            // 
            this.reasonsOfLeaving.HeaderText = "أسباب ترك العمل";
            this.reasonsOfLeaving.Name = "reasonsOfLeaving";
            // 
            // endDate
            // 
            this.endDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.endDate.HeaderText = "الخروج";
            this.endDate.Name = "endDate";
            this.endDate.Width = 62;
            // 
            // startDate
            // 
            this.startDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.startDate.HeaderText = "الدخول";
            this.startDate.Name = "startDate";
            this.startDate.Width = 63;
            // 
            // jobTitle
            // 
            this.jobTitle.HeaderText = "المسمى الوظيفي";
            this.jobTitle.Name = "jobTitle";
            // 
            // workField
            // 
            this.workField.HeaderText = "مجال عمل الشركة";
            this.workField.Name = "workField";
            // 
            // corporationLocation
            // 
            this.corporationLocation.HeaderText = "موقع العمل";
            this.corporationLocation.Name = "corporationLocation";
            // 
            // corporationName
            // 
            this.corporationName.HeaderText = "اسم الشركة";
            this.corporationName.Name = "corporationName";
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
            this.expertiseDataGridView.Size = new System.Drawing.Size(639, 106);
            this.expertiseDataGridView.TabIndex = 1;
            // 
            // trainerCoursesGroupBox
            // 
            this.trainerCoursesGroupBox.AutoSize = true;
            this.trainerCoursesGroupBox.Controls.Add(this.trainerCoursesDataGridView);
            this.trainerCoursesGroupBox.Location = new System.Drawing.Point(0, 400);
            this.trainerCoursesGroupBox.Name = "trainerCoursesGroupBox";
            this.trainerCoursesGroupBox.Size = new System.Drawing.Size(645, 125);
            this.trainerCoursesGroupBox.TabIndex = 45;
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
            this.trainerCoursesDataGridView.Size = new System.Drawing.Size(639, 106);
            this.trainerCoursesDataGridView.TabIndex = 1;
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
            // trainingDays
            // 
            this.trainingDays.HeaderText = "عدد أيام التدريب";
            this.trainingDays.Name = "trainingDays";
            // 
            // courseDate
            // 
            this.courseDate.HeaderText = "تاريخ الدورة";
            this.courseDate.Name = "courseDate";
            // 
            // CourseLocation
            // 
            this.CourseLocation.HeaderText = "مكان الدورة";
            this.CourseLocation.Name = "CourseLocation";
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "اسم الدورة";
            this.CourseName.Name = "CourseName";
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
            this.traineeCoursesDataGridView.Size = new System.Drawing.Size(639, 106);
            this.traineeCoursesDataGridView.TabIndex = 1;
            // 
            // trainingHours
            // 
            this.trainingHours.HeaderText = "الساعات التدريبية";
            this.trainingHours.Name = "trainingHours";
            // 
            // traineeCoursesGroupBox
            // 
            this.traineeCoursesGroupBox.AutoSize = true;
            this.traineeCoursesGroupBox.Controls.Add(this.traineeCoursesDataGridView);
            this.traineeCoursesGroupBox.Location = new System.Drawing.Point(0, 266);
            this.traineeCoursesGroupBox.Name = "traineeCoursesGroupBox";
            this.traineeCoursesGroupBox.Size = new System.Drawing.Size(645, 125);
            this.traineeCoursesGroupBox.TabIndex = 44;
            this.traineeCoursesGroupBox.TabStop = false;
            this.traineeCoursesGroupBox.Text = "أهم الدورات التدريبية (متدربا):";
            // 
            // educationGroupBox
            // 
            this.educationGroupBox.AutoSize = true;
            this.educationGroupBox.Controls.Add(this.educationDataGridView);
            this.educationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.educationGroupBox.Name = "educationGroupBox";
            this.educationGroupBox.Size = new System.Drawing.Size(645, 125);
            this.educationGroupBox.TabIndex = 42;
            this.educationGroupBox.TabStop = false;
            this.educationGroupBox.Text = "التحصيل العلمي:";
            this.educationGroupBox.Enter += new System.EventHandler(this.educationGroupBox_Enter);
            // 
            // expertiseGroupBox
            // 
            this.expertiseGroupBox.AutoSize = true;
            this.expertiseGroupBox.Controls.Add(this.expertiseDataGridView);
            this.expertiseGroupBox.Location = new System.Drawing.Point(0, 135);
            this.expertiseGroupBox.Name = "expertiseGroupBox";
            this.expertiseGroupBox.Size = new System.Drawing.Size(645, 125);
            this.expertiseGroupBox.TabIndex = 43;
            this.expertiseGroupBox.TabStop = false;
            this.expertiseGroupBox.Text = "الخبرات العملية (ابتداء من آخر عمل): ";
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
            this.academicYear.Name = "academicYear";
            this.academicYear.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // certificateDate
            // 
            this.certificateDate.HeaderText = "تاريخ المنح";
            this.certificateDate.Name = "certificateDate";
            // 
            // EducationAndExpertise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trainerCoursesGroupBox);
            this.Controls.Add(this.traineeCoursesGroupBox);
            this.Controls.Add(this.educationGroupBox);
            this.Controls.Add(this.expertiseGroupBox);
            this.Name = "EducationAndExpertise";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(647, 525);
            this.Load += new System.EventHandler(this.EducationAndExpertise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.educationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertiseDataGridView)).EndInit();
            this.trainerCoursesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainerCoursesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeCoursesDataGridView)).EndInit();
            this.traineeCoursesGroupBox.ResumeLayout(false);
            this.educationGroupBox.ResumeLayout(false);
            this.expertiseGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonsOfLeaving;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn workField;
        private System.Windows.Forms.DataGridViewTextBoxColumn corporationLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn corporationName;
        internal System.Windows.Forms.DataGridView expertiseDataGridView;
        internal System.Windows.Forms.GroupBox trainerCoursesGroupBox;
        internal System.Windows.Forms.DataGridView trainerCoursesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameT;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseLocationT;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDateT;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingDaysT;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingHoursT;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        internal System.Windows.Forms.DataGridView traineeCoursesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingHours;
        internal System.Windows.Forms.GroupBox traineeCoursesGroupBox;
        internal System.Windows.Forms.GroupBox educationGroupBox;
        internal System.Windows.Forms.GroupBox expertiseGroupBox;
        internal System.Windows.Forms.DataGridView educationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificate;
        private System.Windows.Forms.DataGridViewTextBoxColumn certifcateIssuer;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificateDate;
    }
}
