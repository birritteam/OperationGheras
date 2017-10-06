namespace GherasEO.GUI.UserControls
{
    partial class Page3
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
            this.desiredJob11 = new GherasEO.GUI.UserControls.DesiredJob();
            this.emergencyAndReferences11 = new GherasEO.GUI.UserControls.EmergencyAndReferences();
            this.skills11 = new GherasEO.GUI.UserControls.Skills();
            this.SuspendLayout();
            // 
            // desiredJob11
            // 
            this.desiredJob11.Location = new System.Drawing.Point(0, 220);
            this.desiredJob11.Name = "desiredJob11";
            this.desiredJob11.Size = new System.Drawing.Size(700, 94);
            this.desiredJob11.TabIndex = 1;
            // 
            // emergencyAndReferences11
            // 
            this.emergencyAndReferences11.Cursor = System.Windows.Forms.Cursors.Default;
            this.emergencyAndReferences11.Location = new System.Drawing.Point(0, 320);
            this.emergencyAndReferences11.Name = "emergencyAndReferences11";
            this.emergencyAndReferences11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.emergencyAndReferences11.Size = new System.Drawing.Size(700, 206);
            this.emergencyAndReferences11.TabIndex = 2;
            // 
            // skills11
            // 
            this.skills11.AutoSize = true;
            this.skills11.Location = new System.Drawing.Point(0, 0);
            this.skills11.Name = "skills11";
            this.skills11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.skills11.Size = new System.Drawing.Size(703, 223);
            this.skills11.TabIndex = 0;
            // 
            // Page3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.desiredJob11);
            this.Controls.Add(this.emergencyAndReferences11);
            this.Controls.Add(this.skills11);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Page3";
            this.Size = new System.Drawing.Size(700, 529);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Skills skills11;
        internal EmergencyAndReferences emergencyAndReferences11;
        internal DesiredJob desiredJob11;
    }
}
