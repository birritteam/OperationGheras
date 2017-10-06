namespace GherasEO.GUI.UserControls
{
    partial class EmergencyAndReferences
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
            this.referenceGroupBox = new System.Windows.Forms.GroupBox();
            this.referenceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceOpinion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyGroupBox = new System.Windows.Forms.GroupBox();
            this.emergencyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referenceDataGridView)).BeginInit();
            this.emergencyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // referenceGroupBox
            // 
            this.referenceGroupBox.Controls.Add(this.referenceDataGridView);
            this.referenceGroupBox.Location = new System.Drawing.Point(2, 103);
            this.referenceGroupBox.Name = "referenceGroupBox";
            this.referenceGroupBox.Size = new System.Drawing.Size(698, 100);
            this.referenceGroupBox.TabIndex = 45;
            this.referenceGroupBox.TabStop = false;
            this.referenceGroupBox.Text = "أشخاص عملت معهم:";
            // 
            // referenceDataGridView
            // 
            this.referenceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.referenceDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.referenceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.referenceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.referenceOpinion});
            this.referenceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.referenceDataGridView.Location = new System.Drawing.Point(3, 16);
            this.referenceDataGridView.Name = "referenceDataGridView";
            this.referenceDataGridView.Size = new System.Drawing.Size(692, 81);
            this.referenceDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "اسم الشخص";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "مكان العمل";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "المنصب";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "هاتف";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // referenceOpinion
            // 
            this.referenceOpinion.HeaderText = "رأي المرجع";
            this.referenceOpinion.Name = "referenceOpinion";
            // 
            // emergencyGroupBox
            // 
            this.emergencyGroupBox.Controls.Add(this.emergencyDataGridView);
            this.emergencyGroupBox.Location = new System.Drawing.Point(0, 0);
            this.emergencyGroupBox.Name = "emergencyGroupBox";
            this.emergencyGroupBox.Size = new System.Drawing.Size(700, 100);
            this.emergencyGroupBox.TabIndex = 44;
            this.emergencyGroupBox.TabStop = false;
            this.emergencyGroupBox.Text = "رقم طوارئ:";
            // 
            // emergencyDataGridView
            // 
            this.emergencyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.emergencyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.emergencyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emergencyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.emergencyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emergencyDataGridView.Location = new System.Drawing.Point(3, 16);
            this.emergencyDataGridView.Name = "emergencyDataGridView";
            this.emergencyDataGridView.Size = new System.Drawing.Size(694, 81);
            this.emergencyDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "اسم الشخص";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "مكان العمل";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "المنصب";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "هاتف";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // EmergencyAndReferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.referenceGroupBox);
            this.Controls.Add(this.emergencyGroupBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "EmergencyAndReferences";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(700, 207);
            this.referenceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.referenceDataGridView)).EndInit();
            this.emergencyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emergencyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox referenceGroupBox;
        internal System.Windows.Forms.DataGridView referenceDataGridView;
        internal System.Windows.Forms.GroupBox emergencyGroupBox;
        internal System.Windows.Forms.DataGridView emergencyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceOpinion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
