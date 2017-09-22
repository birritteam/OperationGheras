namespace GherasEO.GUI
{
    partial class allInformation
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
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.jobSeekerInformationPanel12 = new GherasEO.jobSeekerInformationPanel1();
            this.jobSeekerInformationPanel22 = new GherasEO.jobSeekerInformationPanel2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.AutoScroll = true;
            this.splitContainer3.Panel1.Controls.Add(this.jobSeekerInformationPanel12);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.AutoScroll = true;
            this.splitContainer3.Panel2.Controls.Add(this.jobSeekerInformationPanel22);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(1100, 600);
            this.splitContainer3.SplitterDistance = 427;
            this.splitContainer3.TabIndex = 4;
            // 
            // jobSeekerInformationPanel12
            // 
            this.jobSeekerInformationPanel12.Location = new System.Drawing.Point(3, 0);
            this.jobSeekerInformationPanel12.Name = "jobSeekerInformationPanel12";
            this.jobSeekerInformationPanel12.Size = new System.Drawing.Size(407, 627);
            this.jobSeekerInformationPanel12.TabIndex = 0;
            // 
            // jobSeekerInformationPanel22
            // 
            this.jobSeekerInformationPanel22.Location = new System.Drawing.Point(4, 4);
            this.jobSeekerInformationPanel22.Name = "jobSeekerInformationPanel22";
            this.jobSeekerInformationPanel22.Size = new System.Drawing.Size(642, 808);
            this.jobSeekerInformationPanel22.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.currentUserLabel);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 60);
            this.panel2.TabIndex = 3;
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.Location = new System.Drawing.Point(739, 16);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.currentUserLabel.Size = new System.Drawing.Size(235, 21);
            this.currentUserLabel.TabIndex = 47;
            this.currentUserLabel.Text = " ";
            this.currentUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(980, 20);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(93, 13);
            this.label26.TabIndex = 46;
            this.label26.Text = "المستخدم الحالي:";
            // 
            // allInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.panel2);
            this.Name = "allInformation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1100, 660);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer3;
        private jobSeekerInformationPanel1 jobSeekerInformationPanel12;
        private jobSeekerInformationPanel2 jobSeekerInformationPanel22;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Label label26;
    }
}
