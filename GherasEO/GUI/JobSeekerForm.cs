using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GherasEO.GUI
{
    public partial class JobSeekerForm : Form
    {
        public string currentUser { get; set; }

        private JobSeekerForm()
        {
            InitializeComponent();
        }

        public JobSeekerForm(string currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.currentUserLabel.Text = this.currentUser;

           // tabControl1.TabPages[0].Enabled = false;
            


            //page2.educationAndExpertise11.educationDataGridView.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (page1.Visible && checkfilled())
            {
                currentPageGroupBox.Text = "الصفحة الثانية (2 من 3)";
                page1.Hide();
                page2.Show();

                previousButton.Enabled = true;
                addButton.Enabled = false;
            }
            else if (page2.Visible)
            {
                currentPageGroupBox.Text = "الصفحة الثالثة (3 من 3)";
                page2.Hide();
                page3.Show();

                nextButton.Enabled = false;
                addButton.Enabled = true;
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (page3.Visible)
            {
                currentPageGroupBox.Text = "الصفحة الثانية (2 من 3)";
                page3.Visible = false;
                page2.Visible = true;

                nextButton.Enabled = true;
                addButton.Enabled = false;
            }
            else if (page2.Visible)
            {
                currentPageGroupBox.Text = "الصفحة الأولى (1 من 3)";
                page2.Visible = false;
                page1.Visible = true;

                previousButton.Enabled = false;
                addButton.Enabled = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (page3.desiredJob11.desiredJobTextBox.Text != "" && page3.desiredJob11.workTimeTextBox.Text != "")
            {

                using (var db = new employment_officeEntities())
                {


                    Job_seeker JS = new Job_seeker();
                    //personal ID and Data (Page 1)--Job_seeker

                    JS.First_name = page1.personalID.firstNameTB.Text;
                    JS.Second_name = page1.personalID.lastNameTB.Text;
                    JS.Father_name = page1.personalID.fatherNameTB.Text;
                    JS.Mother_name = page1.personalID.motherFirstNameTB.Text + " " + page1.personalID.motherLastNameTB.Text;
                    JS.Place_Of_Birth = page1.personalID.birthLocationTB.Text;
                    JS.National_ID = page1.personalID.nationalNumberMaskedTB.Text;
                    JS.PersonalCard_number = page1.personalID.idNumberMaskedTB.Text;

                    //JS.City = "not exist";//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                    //JS.District = "not exist";//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

                    if (page1.personalID.genderCB.Text.Equals("ذكر"))
                        JS.Gender = 1;
                    else
                        JS.Gender = 0;

                    JS.Face_Color = page1.personalID.faceColorTB.Text;
                    JS.eyes_Color = page1.personalID.eyeColorTB.Text;

                    JS.Current_address = page1.personalID.currentAddressTB.Text;
                    JS.Previous_address = page1.personalID.previousAddressTB.Text;
                    JS.special_Mark = page1.personalID.specialFeaturesTB.Text;
                    JS.Date_Of_Release = page1.personalID.recivingDateDTP.Text;
                    JS.municipality = page1.personalID.municipalityTextBox.Text;
                    JS.registration = page1.personalID.registrationTextBox.Text;

                    string Military_service = "";
                    if (page1.personalData.finishedRadioButton.Checked)
                    {
                        Military_service = "منتهية";
                    }
                    else if (page1.personalData.delayedRadioButton.Checked)
                    {
                        Military_service = "مؤجل بسبب: " + page1.personalData.delayReasonTB.Text;
                    }
                    else if (page1.personalData.exemptRadioButton.Checked)
                    {
                        Military_service = "معفى بسبب: " + page1.personalData.exemptionReasonTB.Text;
                    }


                    string Social_status = "عازب";
                    if (page1.personalData.unmarriedRadioButton.Checked)
                    {
                        Social_status = "عازب";
                    }
                    else if (page1.personalData.marriedRadioButton.Checked)
                    {
                        Social_status = "متزوج" + "وله" + page1.personalData.numberOfChildrenNumericUpDown.Value.ToString() + " اولاد ";
                    }
                    else if (page1.personalData.divorcedRadioButton.Checked)
                    {

                        Social_status = "مطلق" + "وله" + page1.personalData.numberOfChildrenNumericUpDown.Value.ToString() + " اولاد ";

                    }
                    else if (page1.personalData.widowedRadioButton.Checked)
                    {
                        Social_status = "أرمل" + "وله" + page1.personalData.numberOfChildrenNumericUpDown.Value.ToString() + " اولاد ";
                    }
                    JS.Social_status = Social_status;

                    JS.Driving_license = 0;

                    if (page1.personalData.drivingLicenceCheckBox.Checked)
                    {
                        JS.Driving_license = 1;
                    }
                    else
                    {
                        JS.Driving_license = 0;
                    }

                    JS.Has_car = 0;
                    if (page1.personalData.hasACarCheckBox.Checked)
                    {
                        JS.Has_car = 1;
                    }
                    else
                    {
                        JS.Has_car = 0;
                    }


                    JS.Smoking = 0;
                    if (page1.personalData.smokerRadioButton.Checked)
                    {
                        JS.Smoking = 1;
                    }
                    else
                    {
                        JS.Smoking = 0;
                    }

                    JS.Email = page1.personalData.emailTextBox.Text;
                    JS.Phone = page1.personalData.telephoneMaskedTextBox.Text;
                    JS.mobile = page1.personalData.maskedTextBox1.Text;
                    JS.Handicap = page1.personalData.disabilityTypeTextBox.Text;
                    JS.Extra_Information = page1.personalData.additionalInformationTextBox.Text;


                    // (Page 2)
                    ArrayList cer_list = new ArrayList();
                    Certificate cer = null;

                    foreach (DataGridViewRow row in page2.educationAndExpertise11.educationDataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;
                        cer = new Certificate();
                        cer.Certificate_name = Convert.ToString(row.Cells[0].Value);
                        cer.University_name = Convert.ToString(row.Cells[1].Value);
                        cer.Study_year = Convert.ToString(row.Cells[2].Value);
                        cer.Graduation = Convert.ToDateTime(row.Cells[3].Value);


                        cer_list.Add(cer);
                    }

                    ArrayList WF_list = new ArrayList();
                    Work_For WF = null;

                    foreach (DataGridViewRow row in page2.educationAndExpertise11.expertiseDataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;

                        WF = new Work_For();
                        WF.Company_Name = Convert.ToString(row.Cells[0].Value);
                        WF.Company_plcae = Convert.ToString(row.Cells[1].Value);
                        WF.Field_Of_Work = Convert.ToString(row.Cells[2].Value);
                        WF.Job_Title = Convert.ToString(row.Cells[3].Value);
                        WF.Hire_date = Convert.ToDateTime(row.Cells[4].Value);
                        WF.Quti_date = Convert.ToDateTime(row.Cells[5].Value);
                        WF.Reason = Convert.ToString(row.Cells[6].Value);
                        WF_list.Add(WF);
                    }


                    ArrayList TC_list = new ArrayList();
                    courses TC = null;
                    // (Page 2)
                    foreach (DataGridViewRow row in page2.educationAndExpertise11.traineeCoursesDataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;
                        TC = new courses();
                        TC.Course_Name = Convert.ToString(row.Cells[0].Value);
                        TC.Course_Date = Convert.ToDateTime(row.Cells[1].Value);
                        TC.Num_Of_Days = Convert.ToInt32(row.Cells[2].Value);
                        TC.Train_Hours = Convert.ToInt32(row.Cells[3].Value);
                        TC.type = Convert.ToInt32(row.Cells[4].Value);

                        TC_list.Add(TC);
                    }

                    ArrayList TeC_list = new ArrayList();
                    courses TeC = null;

                    foreach (DataGridViewRow row in page2.educationAndExpertise11.traineeCoursesDataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;
                        TeC = new courses();
                        TeC.Course_Name = Convert.ToString(row.Cells[0].Value);
                        TeC.Course_Date = Convert.ToDateTime(row.Cells[1].Value);
                        TeC.Num_Of_Days = Convert.ToInt32(row.Cells[2].Value);
                        TeC.Train_Hours = Convert.ToInt32(row.Cells[3].Value);
                        TeC.type = Convert.ToInt32(row.Cells[4].Value);

                        TeC_list.Add(TeC);
                    }

                    //page3


                    //skills
                    ArrayList Computer_skill_list = new ArrayList();
                    Skills Computer_skill = new Skills();
                    ArrayList skill_list = new ArrayList();
                    string skill = "";

                    // Determine if there are any items checked.  
                    if (page3.skills11.computerSkillsCheckList.CheckedItems.Count != 0)
                    {
                        // If so, loop through all checked items  
                        for (int x = 0; x < page3.skills11.computerSkillsCheckList.CheckedItems.Count; x++)
                        {
                            skill = page3.skills11.computerSkillsCheckList.CheckedItems[x].ToString();
                            Computer_skill_list.Add(skill);
                        }
                    }

                    foreach (DataGridViewRow row in page3.skills11.otherComputerSkillsDataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;

                        skill = Convert.ToString(row.Cells[0].Value);

                        Computer_skill_list.Add(skill);
                    }
                    string AllcomputerSkill = "مهارات حاسوبية:";
                    foreach (string s in Computer_skill_list)
                    {
                        AllcomputerSkill += " " + s;
                    }

                    if (Computer_skill_list.Count > 0)
                    {
                        Computer_skill.Name = AllcomputerSkill;
                        skill_list.Add(Computer_skill);
                    }


                    Skills Oskill = null;
                    foreach (DataGridViewRow row in page3.skills11.otherSkillsDataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;

                        Oskill = new Skills();
                        Oskill.Name = Convert.ToString(row.Cells[0].Value);

                        skill_list.Add(Oskill);
                    }

                    //Languages
                    ArrayList Languages_list = new ArrayList();
                    Language lang = null;

                    foreach (DataGridViewRow row in page3.skills11.languagesGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        lang = new Language();

                        lang.Language1 = Convert.ToString(row.Cells[0].Value);
                        lang.language_level = Convert.ToString(row.Cells[1].Value);

                        Languages_list.Add(lang);
                    }


                    //Desired Job
                    User_Job DJ = new User_Job();

                    DJ.Last_Salary = Convert.ToInt32(page3.desiredJob11.latestSalaryNumericUpDown.Value);
                    DJ.Excpected_Salary = Convert.ToInt32(page3.desiredJob11.ExpectedSalaryNumericUpDown.Value);
                    DJ.Job = Convert.ToString(page3.desiredJob11.desiredJobTextBox.Text);
                    DJ.time = Convert.ToString(page3.desiredJob11.workTimeTextBox.Text);




                    //Emergency

                    ArrayList Emer_list = new ArrayList();
                    References Emer = null;

                    foreach (DataGridViewRow row in page3.emergencyAndReferences11.emergencyDataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;

                        Emer = new References();

                        Emer.Person_Name = Convert.ToString(row.Cells[0].Value);
                        Emer.Place_of_Work = Convert.ToString(row.Cells[1].Value);
                        Emer.Position = Convert.ToString(row.Cells[2].Value);
                        Emer.Phones = Convert.ToString(row.Cells[3].Value);
                        Emer.type = Convert.ToInt32(row.Cells[4].Value);
                        Emer_list.Add(Emer);
                    }



                    //Refrence Opinion 

                    ArrayList RO_list = new ArrayList();
                    References RO = null;

                    foreach (DataGridViewRow row in page3.emergencyAndReferences11.emergencyDataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;

                        RO = new References();

                        RO.Person_Name = Convert.ToString(row.Cells[0].Value);
                        RO.Place_of_Work = Convert.ToString(row.Cells[1].Value);
                        RO.Position = Convert.ToString(row.Cells[2].Value);
                        RO.Phones = Convert.ToString(row.Cells[3].Value);
                        RO.type = Convert.ToInt32(row.Cells[4].Value);
                        RO.Opinion = Convert.ToString(row.Cells[5].Value);
                        RO_list.Add(RO);
                    }



                    //save Database

                    //cer_list
                    //WF_list
                    //TC_list
                    //TeC_list
                    //skill_list
                    //Languages_list
                    //DJ
                    //Emer_list
                    // RO_list


                    foreach (Certificate c in cer_list)
                        db.Job_seeker.Add(JS).Certificate.Add(c);

                    foreach (Work_For w in WF_list)
                        db.Job_seeker.Add(JS).Work_For.Add(w);

                    foreach (courses c in TC_list)
                        db.Job_seeker.Add(JS).courses.Add(c);

                    foreach (courses c in TeC_list)
                        db.Job_seeker.Add(JS).courses.Add(c);

                    foreach (Skills s in skill_list)
                        db.Job_seeker.Add(JS).Skills.Add(s);

                    foreach (Language l in Languages_list)
                        db.Job_seeker.Add(JS).Language.Add(l);

                    db.Job_seeker.Add(JS).User_Job.Add(DJ);

                    foreach (References r in Emer_list)
                        db.Job_seeker.Add(JS).References.Add(r);

                    foreach (References ro in RO_list)
                        db.Job_seeker.Add(JS).References.Add(ro);

                    db.SaveChanges();



                }
            }
            else
            {
                MessageBox.Show(null, "تأكد من إدخال العمل المطلوب والدوام", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool checkMilitary()
        {
            bool isright = false;
            if (page1.personalData.finishedRadioButton.Checked == false)
            {
                if (page1.personalData.delayReasonTB.Enabled == true)
                    if (page1.personalData.delayReasonTB.Text != "")
                        isright = true;
                    else
                        MessageBox.Show(null, "لم يتم إدخال سبب التأجيل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (page1.personalData.exemptionReasonTB.Enabled == true)
                    if (page1.personalData.exemptionReasonTB.Text != "")
                        isright = true;
                    else
                        MessageBox.Show(null, "لم يتم إدخال سبب الإعفاء", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                isright = true;

            return isright;

        }

        public bool checkfilled()
        {
            bool iscomplete = false;

            if (page1.personalID.firstNameTB.Text != "" && page1.personalID.lastNameTB.Text != "" && page1.personalID.fatherNameTB.Text != ""
                   && page1.personalID.motherFirstNameTB.Text != "" && page1.personalID.motherLastNameTB.Text != "" && page1.personalID.birthLocationTB.Text != "" &&
                   page1.personalID.nationalNumberMaskedTB.Text != "                    " && page1.personalID.idNumberMaskedTB.Text != "              " && page1.personalID.municipalityTextBox.Text != "" &&
                   page1.personalID.registrationTextBox.Text != "" && page1.personalID.faceColorTB.Text != "" &&
                  page1.personalID.eyeColorTB.Text != "" && page1.personalID.specialFeaturesTB.Text != "" && page1.personalID.currentAddressTB.Text != "")

                if (page1.personalData.maskedTextBox1.Text != "    -   -" || page1.personalData.telephoneMaskedTextBox.Text != "   -" || page1.personalData.emailTextBox.Text != "")
                    // personal id user control checked
                    if (checkMilitary() == false)
                        iscomplete = false;
                    else
                        iscomplete = true;

                else
                    MessageBox.Show(null, "لم يتم إدخال أي معلومة تواصل مع الشخص", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show(null, "تأكد أن معلومات البطاقة الشخصية كاملة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            // personal data user control checked

            return iscomplete;
        }

        private void currentPageGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void seacrchByNameButton_Click(object sender, EventArgs e)
        {
        }

        private void seacrchByNationalNumberButton_Click(object sender, EventArgs e)
        {

        }

        private void viewAllDataButton_Click(object sender, EventArgs e)
        {
            // if a result is selected enable edit tab
            tabControl1.TabPages[0].Enabled = true;
            tabControl1.SelectedIndex = 0;
        }



        private void updateExistingButton_Click(object sender, EventArgs e)
        {
            //SHOW CONFIRMATION MESSAGE TO SAVE/DISCARD CHANGES 
            //IF ANY FIELD HAS CHANGED BEFORE SWITCHING TO SEARCH TAB

            //Go to Search tab
            tabControl1.SelectedIndex = 1;

        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            //SHOW CONFIRMATION MESSAGE TO SAVE/DISCARD CHANGES 
            //IF ANY FIELD HAS CHANGED BEFORE CLEARING ALL THE FIELDS
            //tabControl1.TabPages[0].Enabled = true;
        }

        private void JobSeekerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
