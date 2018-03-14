using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GherasEO.GUI.UserControls
{
    public partial class EducationAndExpertise : UserControl
    {
        DateTimePicker dtpeducation;
        DateTimePicker dtptrainer;
        DateTimePicker dtptrainee;
        DateTimePicker dtpenter;
        //DateTimePicker dtpouter;

        public EducationAndExpertise()
        {
            InitializeComponent();
        }

        private void educationGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void EducationAndExpertise_Load(object sender, EventArgs e)
        {
            dtpeducation = new DateTimePicker();
            dtpeducation.Format = DateTimePickerFormat.Custom;
            dtpeducation.CustomFormat = "dd-MM-yyyy";
            dtpeducation.Visible = false;
            dtpeducation.Width = 150;

            dtptrainer = new DateTimePicker();
            dtptrainer.Format = DateTimePickerFormat.Custom;
            dtptrainer.CustomFormat = "dd-MM-yyyy";
            dtptrainer.Visible = false;
            dtptrainer.Width = 150;

            dtptrainee = new DateTimePicker();
            dtptrainee.Format = DateTimePickerFormat.Custom;
            dtptrainee.CustomFormat = "dd-MM-yyyy";
            dtptrainee.Visible = false;
            dtptrainee.Width = 150;

            dtpenter = new DateTimePicker();
            dtpenter.Format = DateTimePickerFormat.Custom;
            dtpenter.CustomFormat = "dd-MM-yyyy";
            dtpenter.Visible = false;
            dtpenter.Width = 150;

            //dtpouter = new DateTimePicker();
            //dtpouter.Format = DateTimePickerFormat.Custom;
            //dtpouter.CustomFormat = "dd-MM-yyyy";
            //dtpouter.Visible = false;
            //dtpouter.Width = 150;

            educationDataGridView.Controls.Add(dtpeducation);
            trainerCoursesDataGridView.Controls.Add(dtptrainer);
            traineeCoursesDataGridView.Controls.Add(dtptrainee);
            expertiseDataGridView.Controls.Add(dtpenter);
            //expertiseDataGridView.Controls.Add(dtpouter);


            dtpeducation.ValueChanged += this.dtpeducation_ValueChanged;
            dtptrainer.ValueChanged += this.dtptrainer_ValueChanged;
            dtptrainee.ValueChanged += this.dtptrainee_ValueChanged;
            dtpenter.ValueChanged += this.dtpenter_ValueChanged;
            //dtpouter.ValueChanged += this.dtpouter_ValueChanged;

            educationDataGridView.CellBeginEdit += this.educationDataGridView_CellBeginEdit;
            educationDataGridView.CellEndEdit += this.educationDataGridView_CellEndEdit;

            trainerCoursesDataGridView.CellBeginEdit += this.trainerCoursesDataGridView_CellBeginEdit;
            trainerCoursesDataGridView.CellEndEdit += this.trainerCoursesDataGridView_CellEndEdit;

            traineeCoursesDataGridView.CellBeginEdit += this.traineeCoursesDataGridView_CellBeginEdit;
            traineeCoursesDataGridView.CellEndEdit += this.traineeCoursesDataGridView_CellEndEdit;

            expertiseDataGridView.CellBeginEdit += this.expertiseDataGridView_CellBeginEdit;
            expertiseDataGridView.CellEndEdit += this.expertiseDataGridView_CellEndEdit;


        }

        private void dtpeducation_ValueChanged(object sender, EventArgs e)
        {
            educationDataGridView.CurrentCell.Value = dtpeducation.Text;
        }
        private void dtptrainer_ValueChanged(object sender, EventArgs e)
        {
            trainerCoursesDataGridView.CurrentCell.Value = dtptrainer.Text;
        }

        private void dtptrainee_ValueChanged(object sender, EventArgs e)
        {
            traineeCoursesDataGridView.CurrentCell.Value = dtptrainee.Text;
        }

        private void dtpenter_ValueChanged(object sender, EventArgs e)
        {
            expertiseDataGridView.CurrentCell.Value = dtpenter.Text;
        }

        //private void dtpouter_ValueChanged(object sender, EventArgs e)
        //{
        //    expertiseDataGridView.CurrentCell.Value = dtpouter.Text;
        //}

        private void educationDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (educationDataGridView.Focused && educationDataGridView.CurrentCell.ColumnIndex == 3)
                {
                    dtpeducation.Location = educationDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                    dtpeducation.Visible = true;
                    if (educationDataGridView.CurrentCell.Value != DBNull.Value)
                    {
                        dtpeducation.Value = (DateTime)educationDataGridView.CurrentCell.Value;

                    }
                    else
                    {
                        dtpeducation.Value = DateTime.Today;
                    }
                }
                else
                {
                    dtpeducation.Visible = false;
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }


        private void trainerCoursesDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (trainerCoursesDataGridView.Focused && trainerCoursesDataGridView.CurrentCell.ColumnIndex == 2)
                {
                    dtptrainer.Location = trainerCoursesDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                    dtptrainer.Visible = true;
                    if (trainerCoursesDataGridView.CurrentCell.Value != DBNull.Value)
                    {
                        dtptrainer.Value = (DateTime)trainerCoursesDataGridView.CurrentCell.Value;

                    }
                    else
                    {
                        dtptrainer.Value = DateTime.Today;
                    }
                }
                else
                {
                    dtptrainer.Visible = false;
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void traineeCoursesDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (traineeCoursesDataGridView.Focused && traineeCoursesDataGridView.CurrentCell.ColumnIndex == 2)
                {
                    dtptrainee.Location = traineeCoursesDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                    dtptrainee.Visible = true;
                    if (traineeCoursesDataGridView.CurrentCell.Value != DBNull.Value)
                    {
                        dtptrainee.Value = (DateTime)traineeCoursesDataGridView.CurrentCell.Value;

                    }
                    else
                    {
                        dtptrainee.Value = DateTime.Today;
                    }
                }
                else
                {
                    dtptrainee.Visible = false;
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void expertiseDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if ((expertiseDataGridView.Focused && expertiseDataGridView.CurrentCell.ColumnIndex == 4) || (expertiseDataGridView.Focused && expertiseDataGridView.CurrentCell.ColumnIndex == 5))
                {
                    dtpenter.Location = expertiseDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                    dtpenter.Visible = true;
                    if (expertiseDataGridView.CurrentCell.Value != DBNull.Value)
                    {
                        dtpenter.Value = (DateTime)expertiseDataGridView.CurrentCell.Value;

                    }
                    else
                    {
                        dtpenter.Value = DateTime.Today;
                    }
                }
                else
                {
                    dtpenter.Visible = false;
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }
        private void educationDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (educationDataGridView.Focused && educationDataGridView.CurrentCell.ColumnIndex == 3)
                {
                    educationDataGridView.CurrentCell.Value = dtpeducation.Value.Date.ToShortDateString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void trainerCoursesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (trainerCoursesDataGridView.Focused && trainerCoursesDataGridView.CurrentCell.ColumnIndex == 2)
                {
                    trainerCoursesDataGridView.CurrentCell.Value = dtptrainer.Value.Date.ToShortDateString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void traineeCoursesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (traineeCoursesDataGridView.Focused && traineeCoursesDataGridView.CurrentCell.ColumnIndex == 2)
                {
                    traineeCoursesDataGridView.CurrentCell.Value = dtptrainee.Value.Date.ToShortDateString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void expertiseDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((expertiseDataGridView.Focused && expertiseDataGridView.CurrentCell.ColumnIndex == 4) || (expertiseDataGridView.Focused && expertiseDataGridView.CurrentCell.ColumnIndex == 5))
                {
                    expertiseDataGridView.CurrentCell.Value = dtpenter.Value.Date.ToShortDateString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
