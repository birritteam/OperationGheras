namespace GherasEO.GUI.UserControls
{
    partial class DesiredJob
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
            this.desiredJobGroupBox = new System.Windows.Forms.GroupBox();
            this.desiredJobTextBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.workTimeTextBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.latestSalaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ExpectedSalaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.desiredJobGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latestSalaryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpectedSalaryNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // desiredJobGroupBox
            // 
            this.desiredJobGroupBox.Controls.Add(this.ExpectedSalaryNumericUpDown);
            this.desiredJobGroupBox.Controls.Add(this.latestSalaryNumericUpDown);
            this.desiredJobGroupBox.Controls.Add(this.desiredJobTextBox);
            this.desiredJobGroupBox.Controls.Add(this.label25);
            this.desiredJobGroupBox.Controls.Add(this.workTimeTextBox);
            this.desiredJobGroupBox.Controls.Add(this.label24);
            this.desiredJobGroupBox.Controls.Add(this.label23);
            this.desiredJobGroupBox.Controls.Add(this.label22);
            this.desiredJobGroupBox.Location = new System.Drawing.Point(3, 3);
            this.desiredJobGroupBox.Name = "desiredJobGroupBox";
            this.desiredJobGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.desiredJobGroupBox.Size = new System.Drawing.Size(645, 90);
            this.desiredJobGroupBox.TabIndex = 41;
            this.desiredJobGroupBox.TabStop = false;
            this.desiredJobGroupBox.Text = "العمل المطلوب:";
            // 
            // desiredJobTextBox
            // 
            this.desiredJobTextBox.Location = new System.Drawing.Point(17, 50);
            this.desiredJobTextBox.Name = "desiredJobTextBox";
            this.desiredJobTextBox.Size = new System.Drawing.Size(215, 20);
            this.desiredJobTextBox.TabIndex = 16;
            this.desiredJobTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(238, 53);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(80, 13);
            this.label25.TabIndex = 15;
            this.label25.Text = "العمل المطلوب:";
            // 
            // workTimeTextBox
            // 
            this.workTimeTextBox.Location = new System.Drawing.Point(344, 50);
            this.workTimeTextBox.Name = "workTimeTextBox";
            this.workTimeTextBox.Size = new System.Drawing.Size(184, 20);
            this.workTimeTextBox.TabIndex = 14;
            this.workTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.workTimeTextBox.TextChanged += new System.EventHandler(this.workTimeTextBox_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(534, 53);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 13);
            this.label24.TabIndex = 13;
            this.label24.Text = "الدوام:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(238, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 13);
            this.label23.TabIndex = 11;
            this.label23.Text = "الراتب المتوقع:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(534, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 13);
            this.label22.TabIndex = 9;
            this.label22.Text = "آخر راتب تقاضاه:";
            // 
            // latestSalaryNumericUpDown
            // 
            this.latestSalaryNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.latestSalaryNumericUpDown.Location = new System.Drawing.Point(344, 23);
            this.latestSalaryNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.latestSalaryNumericUpDown.Name = "latestSalaryNumericUpDown";
            this.latestSalaryNumericUpDown.Size = new System.Drawing.Size(184, 20);
            this.latestSalaryNumericUpDown.TabIndex = 17;
            this.latestSalaryNumericUpDown.ThousandsSeparator = true;
            // 
            // ExpectedSalaryNumericUpDown
            // 
            this.ExpectedSalaryNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ExpectedSalaryNumericUpDown.Location = new System.Drawing.Point(17, 23);
            this.ExpectedSalaryNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ExpectedSalaryNumericUpDown.Name = "ExpectedSalaryNumericUpDown";
            this.ExpectedSalaryNumericUpDown.Size = new System.Drawing.Size(215, 20);
            this.ExpectedSalaryNumericUpDown.TabIndex = 18;
            this.ExpectedSalaryNumericUpDown.ThousandsSeparator = true;
            // 
            // DesiredJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.desiredJobGroupBox);
            this.Name = "DesiredJob";
            this.Size = new System.Drawing.Size(651, 96);
            this.desiredJobGroupBox.ResumeLayout(false);
            this.desiredJobGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latestSalaryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpectedSalaryNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox desiredJobGroupBox;
        internal System.Windows.Forms.TextBox desiredJobTextBox;
        private System.Windows.Forms.Label label25;
        internal System.Windows.Forms.TextBox workTimeTextBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        internal System.Windows.Forms.NumericUpDown latestSalaryNumericUpDown;
        internal System.Windows.Forms.NumericUpDown ExpectedSalaryNumericUpDown;
    }
}
