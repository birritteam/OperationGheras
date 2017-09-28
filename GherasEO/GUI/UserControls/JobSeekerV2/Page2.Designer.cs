namespace GherasEO.GUI.UserControls
{
    partial class Page2
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
            this.educationAndExpertise11 = new GherasEO.GUI.UserControls.EducationAndExpertise();
            this.SuspendLayout();
            // 
            // educationAndExpertise11
            // 
            this.educationAndExpertise11.Location = new System.Drawing.Point(0, 0);
            this.educationAndExpertise11.Name = "educationAndExpertise11";
            this.educationAndExpertise11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.educationAndExpertise11.Size = new System.Drawing.Size(645, 528);
            this.educationAndExpertise11.TabIndex = 0;
            // 
            // Page2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.educationAndExpertise11);
            this.Name = "Page2";
            this.Size = new System.Drawing.Size(645, 528);
            this.ResumeLayout(false);

        }

        #endregion

        private EducationAndExpertise educationAndExpertise11;
    }
}
