namespace GherasEO.GUI.UserControls
{
    partial class PersonalID
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
            this.idGroupBox = new System.Windows.Forms.GroupBox();
            this.nationalNumberMaskedTB = new System.Windows.Forms.MaskedTextBox();
            this.idNumberMaskedTB = new System.Windows.Forms.MaskedTextBox();
            this.motherFirstNameTB = new System.Windows.Forms.TextBox();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.recivingDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.specialFeaturesTB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.previousAddressTB = new System.Windows.Forms.TextBox();
            this.currentAddressTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.eyeColorTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.faceColorTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.registrationTextBox = new System.Windows.Forms.TextBox();
            this.municipalityTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.birthdayDTP = new System.Windows.Forms.DateTimePicker();
            this.birthLocationTB = new System.Windows.Forms.TextBox();
            this.motherLastNameTB = new System.Windows.Forms.TextBox();
            this.fatherNameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // idGroupBox
            // 
            this.idGroupBox.AutoSize = true;
            this.idGroupBox.Controls.Add(this.nationalNumberMaskedTB);
            this.idGroupBox.Controls.Add(this.idNumberMaskedTB);
            this.idGroupBox.Controls.Add(this.motherFirstNameTB);
            this.idGroupBox.Controls.Add(this.genderCB);
            this.idGroupBox.Controls.Add(this.recivingDateDTP);
            this.idGroupBox.Controls.Add(this.label16);
            this.idGroupBox.Controls.Add(this.specialFeaturesTB);
            this.idGroupBox.Controls.Add(this.label15);
            this.idGroupBox.Controls.Add(this.previousAddressTB);
            this.idGroupBox.Controls.Add(this.currentAddressTB);
            this.idGroupBox.Controls.Add(this.label13);
            this.idGroupBox.Controls.Add(this.label14);
            this.idGroupBox.Controls.Add(this.eyeColorTB);
            this.idGroupBox.Controls.Add(this.label12);
            this.idGroupBox.Controls.Add(this.faceColorTB);
            this.idGroupBox.Controls.Add(this.label10);
            this.idGroupBox.Controls.Add(this.label11);
            this.idGroupBox.Controls.Add(this.registrationTextBox);
            this.idGroupBox.Controls.Add(this.municipalityTextBox);
            this.idGroupBox.Controls.Add(this.label9);
            this.idGroupBox.Controls.Add(this.label8);
            this.idGroupBox.Controls.Add(this.label7);
            this.idGroupBox.Controls.Add(this.label6);
            this.idGroupBox.Controls.Add(this.birthdayDTP);
            this.idGroupBox.Controls.Add(this.birthLocationTB);
            this.idGroupBox.Controls.Add(this.motherLastNameTB);
            this.idGroupBox.Controls.Add(this.fatherNameTB);
            this.idGroupBox.Controls.Add(this.lastNameTB);
            this.idGroupBox.Controls.Add(this.firstNameTB);
            this.idGroupBox.Controls.Add(this.label5);
            this.idGroupBox.Controls.Add(this.label4);
            this.idGroupBox.Controls.Add(this.label3);
            this.idGroupBox.Controls.Add(this.label2);
            this.idGroupBox.Controls.Add(this.label1);
            this.idGroupBox.Location = new System.Drawing.Point(0, 0);
            this.idGroupBox.Name = "idGroupBox";
            this.idGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.idGroupBox.Size = new System.Drawing.Size(699, 190);
            this.idGroupBox.TabIndex = 3;
            this.idGroupBox.TabStop = false;
            this.idGroupBox.Text = "البطاقة الشخصية";
            // 
            // nationalNumberMaskedTB
            // 
            this.nationalNumberMaskedTB.Location = new System.Drawing.Point(418, 112);
            this.nationalNumberMaskedTB.Mask = "0 0 0 0 0 0 0 0 0 0 0";
            this.nationalNumberMaskedTB.Name = "nationalNumberMaskedTB";
            this.nationalNumberMaskedTB.PromptChar = '0';
            this.nationalNumberMaskedTB.RejectInputOnFirstFailure = true;
            this.nationalNumberMaskedTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nationalNumberMaskedTB.Size = new System.Drawing.Size(104, 20);
            this.nationalNumberMaskedTB.TabIndex = 12;
            // 
            // idNumberMaskedTB
            // 
            this.idNumberMaskedTB.Location = new System.Drawing.Point(259, 112);
            this.idNumberMaskedTB.Mask = "0 0 0 0 0 0 0 0";
            this.idNumberMaskedTB.Name = "idNumberMaskedTB";
            this.idNumberMaskedTB.PromptChar = '0';
            this.idNumberMaskedTB.RejectInputOnFirstFailure = true;
            this.idNumberMaskedTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.idNumberMaskedTB.Size = new System.Drawing.Size(77, 20);
            this.idNumberMaskedTB.TabIndex = 13;
            // 
            // motherFirstNameTB
            // 
            this.motherFirstNameTB.Location = new System.Drawing.Point(276, 49);
            this.motherFirstNameTB.Name = "motherFirstNameTB";
            this.motherFirstNameTB.Size = new System.Drawing.Size(80, 20);
            this.motherFirstNameTB.TabIndex = 8;
            // 
            // genderCB
            // 
            this.genderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Items.AddRange(new object[] {
            "ذكر",
            "أنثى"});
            this.genderCB.Location = new System.Drawing.Point(13, 18);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(76, 21);
            this.genderCB.TabIndex = 17;
            // 
            // recivingDateDTP
            // 
            this.recivingDateDTP.CustomFormat = "yyyy/MM/dd";
            this.recivingDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.recivingDateDTP.Location = new System.Drawing.Point(200, 144);
            this.recivingDateDTP.Name = "recivingDateDTP";
            this.recivingDateDTP.Size = new System.Drawing.Size(117, 20);
            this.recivingDateDTP.TabIndex = 16;
            this.recivingDateDTP.Value = new System.DateTime(2000, 1, 1, 12, 47, 0, 0);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(323, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "تاريخ المنح:";
            // 
            // specialFeaturesTB
            // 
            this.specialFeaturesTB.Location = new System.Drawing.Point(13, 94);
            this.specialFeaturesTB.Name = "specialFeaturesTB";
            this.specialFeaturesTB.Size = new System.Drawing.Size(77, 20);
            this.specialFeaturesTB.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(96, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "العلامات المميزة:";
            // 
            // previousAddressTB
            // 
            this.previousAddressTB.Location = new System.Drawing.Point(13, 147);
            this.previousAddressTB.Name = "previousAddressTB";
            this.previousAddressTB.Size = new System.Drawing.Size(77, 20);
            this.previousAddressTB.TabIndex = 22;
            // 
            // currentAddressTB
            // 
            this.currentAddressTB.Location = new System.Drawing.Point(13, 121);
            this.currentAddressTB.Name = "currentAddressTB";
            this.currentAddressTB.Size = new System.Drawing.Size(76, 20);
            this.currentAddressTB.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(101, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "السكن السابق:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(105, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "السكن الحالي:";
            // 
            // eyeColorTB
            // 
            this.eyeColorTB.Location = new System.Drawing.Point(13, 68);
            this.eyeColorTB.Name = "eyeColorTB";
            this.eyeColorTB.Size = new System.Drawing.Size(76, 20);
            this.eyeColorTB.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "لون العينين:";
            // 
            // faceColorTB
            // 
            this.faceColorTB.Location = new System.Drawing.Point(13, 43);
            this.faceColorTB.Name = "faceColorTB";
            this.faceColorTB.Size = new System.Drawing.Size(76, 20);
            this.faceColorTB.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(128, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "لون الوجه:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(139, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "الجنس:";
            // 
            // registrationTextBox
            // 
            this.registrationTextBox.Location = new System.Drawing.Point(389, 147);
            this.registrationTextBox.Name = "registrationTextBox";
            this.registrationTextBox.Size = new System.Drawing.Size(133, 20);
            this.registrationTextBox.TabIndex = 15;
            // 
            // municipalityTextBox
            // 
            this.municipalityTextBox.Location = new System.Drawing.Point(567, 147);
            this.municipalityTextBox.Name = "municipalityTextBox";
            this.municipalityTextBox.Size = new System.Drawing.Size(81, 20);
            this.municipalityTextBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(528, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "القيد:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(654, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "الأمانة:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "رقم الهوية:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "الرقم الوطني:";
            // 
            // birthdayDTP
            // 
            this.birthdayDTP.CustomFormat = "yyyy/MM/dd";
            this.birthdayDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayDTP.Location = new System.Drawing.Point(200, 80);
            this.birthdayDTP.Name = "birthdayDTP";
            this.birthdayDTP.Size = new System.Drawing.Size(245, 20);
            this.birthdayDTP.TabIndex = 11;
            this.birthdayDTP.Value = new System.DateTime(2018, 3, 14, 22, 37, 0, 0);
            // 
            // birthLocationTB
            // 
            this.birthLocationTB.Location = new System.Drawing.Point(461, 80);
            this.birthLocationTB.Name = "birthLocationTB";
            this.birthLocationTB.Size = new System.Drawing.Size(135, 20);
            this.birthLocationTB.TabIndex = 10;
            // 
            // motherLastNameTB
            // 
            this.motherLastNameTB.Location = new System.Drawing.Point(200, 49);
            this.motherLastNameTB.Name = "motherLastNameTB";
            this.motherLastNameTB.Size = new System.Drawing.Size(70, 20);
            this.motherLastNameTB.TabIndex = 9;
            // 
            // fatherNameTB
            // 
            this.fatherNameTB.Location = new System.Drawing.Point(461, 49);
            this.fatherNameTB.Name = "fatherNameTB";
            this.fatherNameTB.Size = new System.Drawing.Size(135, 20);
            this.fatherNameTB.TabIndex = 7;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(200, 19);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(199, 20);
            this.lastNameTB.TabIndex = 6;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(461, 20);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(135, 20);
            this.firstNameTB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "اسم ونسبة الأم:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "اسم الأب:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "محل وتاريخ الولادة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "النسبة:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاسم:";
            // 
            // PersonalID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.idGroupBox);
            this.Name = "PersonalID";
            this.Size = new System.Drawing.Size(700, 190);
            this.idGroupBox.ResumeLayout(false);
            this.idGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox motherFirstNameTB;
        internal System.Windows.Forms.ComboBox genderCB;
        internal System.Windows.Forms.DateTimePicker recivingDateDTP;
        private System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox specialFeaturesTB;
        private System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox previousAddressTB;
        internal System.Windows.Forms.TextBox currentAddressTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox eyeColorTB;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox faceColorTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox registrationTextBox;
        internal System.Windows.Forms.TextBox municipalityTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.DateTimePicker birthdayDTP;
        internal System.Windows.Forms.TextBox birthLocationTB;
        internal System.Windows.Forms.TextBox motherLastNameTB;
        internal System.Windows.Forms.TextBox fatherNameTB;
        internal System.Windows.Forms.TextBox lastNameTB;
        internal System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.GroupBox idGroupBox;
        internal System.Windows.Forms.MaskedTextBox nationalNumberMaskedTB;
        internal System.Windows.Forms.MaskedTextBox idNumberMaskedTB;
    }
}
