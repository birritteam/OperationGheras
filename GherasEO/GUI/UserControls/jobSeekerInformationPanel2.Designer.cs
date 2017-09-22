namespace GherasEO
{
    partial class jobSeekerInformationPanel2
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
            this.emergencyAndReferences1 = new GherasEO.emergencyAndReferences();
            this.desiredJob1 = new GherasEO.desiredJob();
            this.skills1 = new GherasEO.skills();
            this.educationAndExpertise1 = new GherasEO.educationAndExpertise();
            this.SuspendLayout();
            // 
            // emergencyAndReferences1
            // 
            this.emergencyAndReferences1.Location = new System.Drawing.Point(-2, 609);
            this.emergencyAndReferences1.Name = "emergencyAndReferences1";
            this.emergencyAndReferences1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.emergencyAndReferences1.Size = new System.Drawing.Size(642, 214);
            this.emergencyAndReferences1.TabIndex = 3;
            // 
            // desiredJob1
            // 
            this.desiredJob1.Location = new System.Drawing.Point(0, 441);
            this.desiredJob1.Name = "desiredJob1";
            this.desiredJob1.Size = new System.Drawing.Size(201, 162);
            this.desiredJob1.TabIndex = 2;
            this.desiredJob1.Load += new System.EventHandler(this.desiredJob1_Load);
            // 
            // skills1
            // 
            this.skills1.Location = new System.Drawing.Point(207, 441);
            this.skills1.Name = "skills1";
            this.skills1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.skills1.Size = new System.Drawing.Size(432, 162);
            this.skills1.TabIndex = 1;
            // 
            // educationAndExpertise1
            // 
            this.educationAndExpertise1.Location = new System.Drawing.Point(0, 0);
            this.educationAndExpertise1.Name = "educationAndExpertise1";
            this.educationAndExpertise1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.educationAndExpertise1.Size = new System.Drawing.Size(640, 435);
            this.educationAndExpertise1.TabIndex = 0;
            this.educationAndExpertise1.Load += new System.EventHandler(this.educationAndExpertise1_Load);
            // 
            // jobSeekerInformationPanel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.emergencyAndReferences1);
            this.Controls.Add(this.desiredJob1);
            this.Controls.Add(this.skills1);
            this.Controls.Add(this.educationAndExpertise1);
            this.Name = "jobSeekerInformationPanel2";
            this.Size = new System.Drawing.Size(642, 820);
            this.ResumeLayout(false);

        }

        #endregion

        internal educationAndExpertise educationAndExpertise1;
        internal skills skills1;
        internal desiredJob desiredJob1;
        internal emergencyAndReferences emergencyAndReferences1;
    }
}
