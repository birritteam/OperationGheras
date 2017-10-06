namespace GherasEO.GUI.UserControls
{
    partial class Page1
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
            this.personalData = new GherasEO.GUI.PersonalData();
            this.personalID = new GherasEO.GUI.UserControls.PersonalID();
            this.SuspendLayout();
            // 
            // personalData
            // 
            this.personalData.Location = new System.Drawing.Point(0, 192);
            this.personalData.Name = "personalData";
            this.personalData.Size = new System.Drawing.Size(700, 324);
            this.personalData.TabIndex = 9;
            // 
            // personalID
            // 
            this.personalID.Location = new System.Drawing.Point(0, 0);
            this.personalID.Name = "personalID";
            this.personalID.Size = new System.Drawing.Size(700, 198);
            this.personalID.TabIndex = 8;
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.personalData);
            this.Controls.Add(this.personalID);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(700, 528);
            this.ResumeLayout(false);

        }

        #endregion

        internal PersonalData personalData;
        internal PersonalID personalID;
    }
}
