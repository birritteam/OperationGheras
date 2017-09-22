namespace GherasEO
{
    partial class desiredJob
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
            this.expectedSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.latestSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.desiredJobGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // desiredJobGroupBox
            // 
            this.desiredJobGroupBox.Controls.Add(this.desiredJobTextBox);
            this.desiredJobGroupBox.Controls.Add(this.label25);
            this.desiredJobGroupBox.Controls.Add(this.workTimeTextBox);
            this.desiredJobGroupBox.Controls.Add(this.label24);
            this.desiredJobGroupBox.Controls.Add(this.expectedSalaryTextBox);
            this.desiredJobGroupBox.Controls.Add(this.label23);
            this.desiredJobGroupBox.Controls.Add(this.latestSalaryTextBox);
            this.desiredJobGroupBox.Controls.Add(this.label22);
            this.desiredJobGroupBox.Location = new System.Drawing.Point(0, 0);
            this.desiredJobGroupBox.Name = "desiredJobGroupBox";
            this.desiredJobGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.desiredJobGroupBox.Size = new System.Drawing.Size(195, 162);
            this.desiredJobGroupBox.TabIndex = 40;
            this.desiredJobGroupBox.TabStop = false;
            this.desiredJobGroupBox.Text = "العمل المطلوب:";
            this.desiredJobGroupBox.Enter += new System.EventHandler(this.desiredJobGroupBox_Enter);
            // 
            // desiredJobTextBox
            // 
            this.desiredJobTextBox.Location = new System.Drawing.Point(5, 112);
            this.desiredJobTextBox.Name = "desiredJobTextBox";
            this.desiredJobTextBox.Size = new System.Drawing.Size(88, 20);
            this.desiredJobTextBox.TabIndex = 16;
            this.desiredJobTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(99, 112);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(80, 13);
            this.label25.TabIndex = 15;
            this.label25.Text = "العمل المطلوب:";
            // 
            // workTimeTextBox
            // 
            this.workTimeTextBox.Location = new System.Drawing.Point(5, 86);
            this.workTimeTextBox.Name = "workTimeTextBox";
            this.workTimeTextBox.Size = new System.Drawing.Size(88, 20);
            this.workTimeTextBox.TabIndex = 14;
            this.workTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(99, 86);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 13);
            this.label24.TabIndex = 13;
            this.label24.Text = "الدوام:";
            // 
            // expectedSalaryTextBox
            // 
            this.expectedSalaryTextBox.Location = new System.Drawing.Point(5, 60);
            this.expectedSalaryTextBox.Name = "expectedSalaryTextBox";
            this.expectedSalaryTextBox.Size = new System.Drawing.Size(88, 20);
            this.expectedSalaryTextBox.TabIndex = 12;
            this.expectedSalaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(99, 60);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 13);
            this.label23.TabIndex = 11;
            this.label23.Text = "الراتب المتوقع:";
            // 
            // latestSalaryTextBox
            // 
            this.latestSalaryTextBox.Location = new System.Drawing.Point(5, 36);
            this.latestSalaryTextBox.Name = "latestSalaryTextBox";
            this.latestSalaryTextBox.Size = new System.Drawing.Size(88, 20);
            this.latestSalaryTextBox.TabIndex = 10;
            this.latestSalaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(99, 36);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 13);
            this.label22.TabIndex = 9;
            this.label22.Text = "آخر راتب تقاضاه:";
            // 
            // desiredJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.desiredJobGroupBox);
            this.Name = "desiredJob";
            this.Size = new System.Drawing.Size(199, 162);
            this.desiredJobGroupBox.ResumeLayout(false);
            this.desiredJobGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox desiredJobGroupBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        internal System.Windows.Forms.TextBox desiredJobTextBox;
        internal System.Windows.Forms.TextBox workTimeTextBox;
        internal System.Windows.Forms.TextBox expectedSalaryTextBox;
        internal System.Windows.Forms.TextBox latestSalaryTextBox;
    }
}
