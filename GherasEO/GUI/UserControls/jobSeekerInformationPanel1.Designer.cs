namespace GherasEO
{
    partial class jobSeekerInformationPanel1
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
            this.personalID1 = new GherasEO.personalID();
            this.personalData1 = new GherasEO.personalData();
            this.SuspendLayout();
            // 
            // personalID1
            // 
            this.personalID1.Location = new System.Drawing.Point(0, 0);
            this.personalID1.Name = "personalID1";
            this.personalID1.Size = new System.Drawing.Size(407, 263);
            this.personalID1.TabIndex = 1;
            // 
            // personalData1
            // 
            this.personalData1.Location = new System.Drawing.Point(0, 260);
            this.personalData1.Name = "personalData1";
            this.personalData1.Size = new System.Drawing.Size(405, 354);
            this.personalData1.TabIndex = 0;
            // 
            // jobSeekerInformationPanel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.personalID1);
            this.Controls.Add(this.personalData1);
            this.Name = "jobSeekerInformationPanel1";
            this.Size = new System.Drawing.Size(407, 617);
            this.ResumeLayout(false);

        }

        #endregion

        internal personalData personalData1;
        internal personalID personalID1;
    }
}
