using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GherasEO.GUI
{
    public partial class JobSeekerForm : Form
    {
      public  employment_officeEntities db = new employment_officeEntities();
        public Job_seeker JS;
        public bool checkeditoradd = false;//fasle => add(not edit)
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

                // if true this mean I add new Job_seeker else I edit Old Job_seeker
                if (!checkeditoradd)
                    JS = new Job_seeker();
                else
                {
                    //before edit I reomve old data
                    removeOldData(JS);
                }

                    //personal ID and Data (Page 1)--Job_seeker
                    JS.First_name = page1.personalID.firstNameTB.Text;
                    JS.Second_name = page1.personalID.lastNameTB.Text;
                    JS.Father_name = page1.personalID.fatherNameTB.Text;
                    JS.Mother_Fname = page1.personalID.motherFirstNameTB.Text;
                    JS.Mother_Lname=page1.personalID.motherLastNameTB.Text;
                    JS.Place_Of_Birth = page1.personalID.birthLocationTB.Text;
                    JS.National_ID = page1.personalID.nationalNumberMaskedTB.Text;
                    JS.PersonalCard_number = page1.personalID.idNumberMaskedTB.Text;

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
                     JS.Military_service = Military_service;

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
                        TC.Course_Location = Convert.ToString(row.Cells[1].Value);
                        TC.Course_Date = Convert.ToDateTime(row.Cells[2].Value);
                        TC.Num_Of_Days = Convert.ToInt32(row.Cells[3].Value);
                        TC.Train_Hours = Convert.ToInt32(row.Cells[4].Value);
                        TC.type = Convert.ToInt32(0);//  trainee <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<attention

                    TC_list.Add(TC);
                    }

                    ArrayList TeC_list = new ArrayList();
                    courses TeC = null;

                    foreach (DataGridViewRow row in page2.educationAndExpertise11.trainerCoursesDataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;
                        TeC = new courses();
                        TeC.Course_Name = Convert.ToString(row.Cells[0].Value);
                        TeC.Course_Location = Convert.ToString(row.Cells[1].Value);
                        TeC.Course_Date = Convert.ToDateTime(row.Cells[2].Value);
                        TeC.Num_Of_Days = Convert.ToInt32(row.Cells[3].Value);
                        TeC.Train_Hours = Convert.ToInt32(row.Cells[4].Value);
                        TeC.type = Convert.ToInt32(1);//1  trainer <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<attention

                        TeC_list.Add(TeC);
                    }

                    //page3


                    //skills
                   // ArrayList Computer_skill_list = new ArrayList();
                    Skills newskill = new Skills();
                    ArrayList skill_list = new ArrayList();

                    // Determine if there are any items checked.  
                    if (page3.skills11.computerSkillsCheckList.CheckedItems.Count != 0)
                    {
                        // If so, loop through all checked items  
                        for (int x = 0; x < page3.skills11.computerSkillsCheckList.CheckedItems.Count; x++)
                        {
                        newskill = new Skills();
                        newskill.Name = page3.skills11.computerSkillsCheckList.CheckedItems[x].ToString();
                        skill_list.Add(newskill);
                        }
                    }

                    foreach (DataGridViewRow row in page3.skills11.otherComputerSkillsDataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;

                    newskill = new Skills();
                    newskill.Name = Convert.ToString("برامج اخرى:"+row.Cells[0].Value);
                    skill_list.Add(newskill);

                    }

                    //string AllcomputerSkill = "مهارات حاسوبية:";
                    //foreach (string s in Computer_skill_list)
                    //{
                    //    AllcomputerSkill += " " + s;
                    //}

                    //if (Computer_skill_list.Count > 0)
                    //{
                    //    Computer_skill.Name = AllcomputerSkill;
                    //    skill_list.Add(Computer_skill);
                    //}

                    Skills Oskill = null;
                    foreach (DataGridViewRow row in page3.skills11.otherSkillsDataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;

                        Oskill = new Skills();
                        Oskill.Name = Convert.ToString("مهارات اخرى:" + row.Cells[0].Value);

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
                        Emer.type = Convert.ToInt32(0);// 0 emergency <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< attention
                    Emer_list.Add(Emer);
                    }
                    //Refrence Opinion 

                    ArrayList RO_list = new ArrayList();
                    References RO = null;

                    foreach (DataGridViewRow row in page3.emergencyAndReferences11.referenceDataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;

                        RO = new References();

                        RO.Person_Name = Convert.ToString(row.Cells[0].Value);
                        RO.Place_of_Work = Convert.ToString(row.Cells[1].Value);
                        RO.Position = Convert.ToString(row.Cells[2].Value);
                        RO.Phones = Convert.ToString(row.Cells[3].Value);
                    RO.Opinion = Convert.ToString(row.Cells[4].Value);
                    RO.type = Convert.ToInt32(1);//1 References <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< attention
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
                       JS.Certificate.Add(c);

                    foreach (Work_For w in WF_list)
                        JS.Work_For.Add(w);

                    foreach (courses c in TC_list)
                       JS.courses.Add(c);

                    foreach (courses c in TeC_list)
                        JS.courses.Add(c);

                    foreach (Skills s in skill_list)
                        JS.Skills.Add(s);

                    foreach (Language l in Languages_list)
                        JS.Language.Add(l);

                    JS.User_Job.Add(DJ);

                    foreach (References r in Emer_list)
                        JS.References.Add(r);

                    foreach (References ro in RO_list)
                        JS.References.Add(ro);

                if (!checkeditoradd)
                {
                    db.Job_seeker.Add(JS);

                }

                db.SaveChanges();

                //Clear data in controls
                resetViewData();


                if (!checkeditoradd)
                {
                    MessageBox.Show(null, "تم الإضافة بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(null, "تم التعديل بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                checkeditoradd = false;

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
                  page1.personalID.eyeColorTB.Text != "" && page1.personalID.specialFeaturesTB.Text != "" && page1.personalID.currentAddressTB.Text != "" && page1.personalID.genderCB.Text != "")

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
            searchResultDataGridView.Rows.Clear();
            if (FullNametextBox.Text != "")
            {
                string name = Convert.ToString(FullNametextBox.Text);
                var Job_seekers = db.Job_seeker.Where(x => x.First_name.Contains( name) || x.Second_name.Contains(name)).ToList();
                if (Job_seekers != null && Job_seekers.Count>0)
                    foreach (Job_seeker js in Job_seekers)
                    searchResultDataGridView.Rows.Add(js.First_name + " " + js.Father_name + " " + js.Second_name, js.National_ID,js.Phone,js.mobile,js.Email);
                else
                    MessageBox.Show(null, "لا يوجد تطابق", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show(null, "لم يتم إدخال الاسم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void seacrchByNationalNumberButton_Click(object sender, EventArgs e)
        {
            searchResultDataGridView.Rows.Clear();
            if (nationalNumberMaskedTB.Text != "                    ")
            {
                string id = Convert.ToString(nationalNumberMaskedTB.Text);
                Job_seeker js= db.Job_seeker.SingleOrDefault(x => x.National_ID == id);
                if(js !=null)
                searchResultDataGridView.Rows.Add( js.First_name + " " + js.Father_name + " " + js.Second_name, js.National_ID,js.Phone, js.mobile, js.Email);
                else
                    MessageBox.Show(null, "لا يوجد تطابق", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show(null, "لم يتم إدخال الرقم الوطني", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void viewAllDataButton_Click(object sender, EventArgs e)
        {
            // if a result is selected enable edit tab
            if (searchResultDataGridView.SelectedRows.Count > 0)
            {
                string fullname = searchResultDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string National_id= searchResultDataGridView.SelectedRows[0].Cells[1].Value.ToString();

                resetViewData();

                FillData(National_id);
                tabControl1.TabPages[0].Enabled = true;
                tabControl1.SelectedIndex = 0;
            }
            else
            {

                MessageBox.Show(null, "يجب اختيار سطر  من الجدول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

               
        }
        public void removeOldData(Job_seeker Js)
        {
            int i = 0;
            ICollection<Certificate> cer_list = JS.Certificate;
            foreach (Certificate cer in cer_list.ToList())
            {
                db.Certificate.Remove(cer);
            }

            ICollection<Work_For> WF_list = JS.Work_For;
            foreach (Work_For WF in WF_list.ToList())
            {
                db.Work_For.Remove(WF);
            }

            ICollection<courses> TC_list = JS.courses;
            // (Page 2)
            foreach (courses TC in TC_list.ToList())
            {
                db.courses.Remove(TC);
            }

            //page3
            //Skills
            //computer Skills
            ICollection<Skills> skill_list = JS.Skills;
            foreach (Skills s in skill_list.ToList())
            {

                db.Skills.Remove(s);

            }
            // Languages
            ICollection<Language> Languages_list = JS.Language;
            foreach (Language lang in Languages_list.ToList())
            {
                db.Language.Remove(lang);
            }


            //Desired Job

            ICollection<User_Job> DJ = JS.User_Job;
            db.User_Job.Remove(DJ.ElementAt(0));

            //Emergency
            ICollection<References> Emer_list = JS.References;
            foreach (References refe in Emer_list.ToList())
            {
                db.References.Remove(refe);

            }

            db.SaveChanges();

        }
      public void  FillData(string National_id)
        {
            JS = db.Job_seeker.SingleOrDefault(x => x.National_ID == National_id);

            //personal ID and Data (Page 1)--Job_seeker
            
            page1.personalID.firstNameTB.Text= JS.First_name ;
            page1.personalID.lastNameTB.Text = JS.Second_name;
            page1.personalID.fatherNameTB.Text= JS.Father_name;
            page1.personalID.motherFirstNameTB.Text = JS.Mother_Fname;
            page1.personalID.motherLastNameTB.Text= JS.Mother_Lname;
            page1.personalID.birthLocationTB.Text=JS.Place_Of_Birth ;
            page1.personalID.nationalNumberMaskedTB.Text=JS.National_ID  ;
            page1.personalID.idNumberMaskedTB.Text= JS.PersonalCard_number;

            if (JS.Gender == 1)
                page1.personalID.genderCB.Text = "ذكر";
            else
                page1.personalID.genderCB.Text = "أنثى";

            page1.personalID.faceColorTB.Text= JS.Face_Color ;
            page1.personalID.eyeColorTB.Text= JS.eyes_Color ;

            page1.personalID.currentAddressTB.Text=JS.Current_address  ;
              page1.personalID.previousAddressTB.Text= JS.Previous_address;
              page1.personalID.specialFeaturesTB.Text= JS.special_Mark;
              page1.personalID.recivingDateDTP.Text= JS.Date_Of_Release;
              page1.personalID.municipalityTextBox.Text= JS.municipality;
              page1.personalID.registrationTextBox.Text= JS.registration;

            if (JS.Military_service.Contains("منتهية")  )
            {
                page1.personalData.finishedRadioButton.Checked=true;
            }
            else if (JS.Military_service.Contains("مؤجل بسبب"))
            {
                page1.personalData.delayedRadioButton.Checked = true;
                page1.personalData.delayReasonTB.Text= JS.Military_service.Substring(10);
            }
            else if (JS.Military_service.Contains("معفى بسبب"))
            {
                page1.personalData.exemptRadioButton.Checked = true;
                page1.personalData.exemptionReasonTB.Text = JS.Military_service.Substring(10);
            }



            if (JS.Social_status.Contains("عازب") )
            {
                page1.personalData.unmarriedRadioButton.Checked = true;
            }
            else if (JS.Social_status.Contains("متزوج"))
            {
                page1.personalData.marriedRadioButton.Checked = true;
                page1.personalData.numberOfChildrenNumericUpDown.Value= Int32.Parse(Regex.Match(JS.Social_status, @"\d+").Value); 
            }
            else if (JS.Social_status.Contains("مطلق"))
            {
                page1.personalData.divorcedRadioButton.Checked = true;
               page1.personalData.numberOfChildrenNumericUpDown.Value = Int32.Parse(Regex.Match(JS.Social_status, @"\d+").Value); 

            }
            else if (JS.Social_status.Contains("أرمل"))
            {
                page1.personalData.widowedRadioButton.Checked = true;
                 page1.personalData.numberOfChildrenNumericUpDown.Value = Int32.Parse(Regex.Match(JS.Social_status, @"\d+").Value); 
            }

            if (JS.Driving_license == 1)
            {
                page1.personalData.drivingLicenceCheckBox.Checked = true;
             
            }
            else
            {
                page1.personalData.drivingLicenceCheckBox.Checked = false;
            }


            if (JS.Has_car == 1)
            {
                page1.personalData.hasACarCheckBox.Checked = true;
                
            }
            else
            {
                page1.personalData.hasACarCheckBox.Checked = false;
            }


            if (JS.Smoking == 1)
            {
                page1.personalData.smokerRadioButton.Checked = true;
            }
            else
            {
                page1.personalData.nonSmokerRadioButton.Checked = true;

            }

            page1.personalData.emailTextBox.Text = JS.Email;
            page1.personalData.telephoneMaskedTextBox.Text = JS.Phone;
            page1.personalData.maskedTextBox1.Text = JS.mobile;
            page1.personalData.disabilityTypeTextBox.Text = JS.Handicap;
            page1.personalData.additionalInformationTextBox.Text = JS.Extra_Information;


            // (Page 2)
            int i = 0;
             ICollection<Certificate>  cer_list = JS.Certificate;
            foreach (Certificate cer in cer_list)
            {
                
                page2.educationAndExpertise11.educationDataGridView.Rows.Add( cer.Certificate_name, cer.University_name, cer.Study_year, cer.Graduation);
            }

            i = 0;
            ICollection < Work_For> WF_list = JS.Work_For;
            foreach ( Work_For WF in WF_list)
            {

                page2.educationAndExpertise11.expertiseDataGridView.Rows.Add(WF.Company_Name, WF.Company_plcae, WF.Field_Of_Work, WF.Job_Title, WF.Hire_date, WF.Quti_date, WF.Reason);

            }

            ICollection < courses> TC_list = JS.courses.Where(x=>x.type == 0).ToList();//0 .trainee <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< attention
            // (Page 2)
            foreach (courses TC in TC_list)
            {
                
                page2.educationAndExpertise11.traineeCoursesDataGridView.Rows.Add(TC.Course_Name, TC.Course_Location, TC.Course_Date , TC.Num_Of_Days, TC.Train_Hours);

            }

            ICollection<courses> TeC_list = JS.courses.Where(x => x.type == 1).ToList();//1 .trainer <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< attention
            // (Page 2)
            foreach (courses TeC in TeC_list)
            {
              
                page2.educationAndExpertise11.trainerCoursesDataGridView.Rows.Add(TeC.Course_Name, TeC.Course_Location, TeC.Course_Date, TeC.Num_Of_Days, TeC.Train_Hours);

            }

            //page3

            //Skills
            //computer Skills
            ICollection< Skills> skill_list =JS.Skills;
            for (int j = 0; j < page3.skills11.computerSkillsCheckList.Items.Count; j++)
            {
                           
                foreach (Skills s in skill_list)
                if (page3.skills11.computerSkillsCheckList.Items[j].ToString() == s.Name)
                {
                  page3.skills11.computerSkillsCheckList.SetItemChecked(j, true);
                // skill_list.Remove(s);
                  break;
                }
               
            }
            //other Computer Skills
            foreach (Skills s in skill_list)
            {

                if (s.Name.Contains("برامج اخرى"))
                {
                    page3.skills11.otherComputerSkillsDataGridView.Rows.Add(s.Name.Substring(12));
                }
            }
            //other skill
            foreach (Skills s in skill_list )
            {

                if (s.Name.Contains("مهارات اخرى"))
                {
                    page3.skills11.otherSkillsDataGridView.Rows.Add(s.Name.Substring(13));
                }

            }
            // Languages
            ICollection < Language> Languages_list = JS.Language;    
            foreach (Language lang in Languages_list)
            {
               
                page3.skills11.languagesGridView1.Rows.Add(lang.Language1, lang.language_level);
            }


            //Desired Job

             ICollection <User_Job> DJ = JS.User_Job;
            page3.desiredJob11.latestSalaryNumericUpDown.Value= Convert.ToInt32(DJ.ElementAt(0).Last_Salary)  ;
            page3.desiredJob11.ExpectedSalaryNumericUpDown.Value=Convert.ToInt32(DJ.ElementAt(0).Excpected_Salary);
            page3.desiredJob11.desiredJobTextBox.Text=DJ.ElementAt(0).Job ;
            page3.desiredJob11.workTimeTextBox.Text= DJ.ElementAt(0).time;

            //Emergency
            ICollection < References> Emer_list = JS.References.Where(x => x.type == 0).ToList();//0 emergency <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< attention
            foreach (References Emer in Emer_list )
            {
               
                page3.emergencyAndReferences11.emergencyDataGridView.Rows.Add(Emer.Person_Name, Emer.Place_of_Work, Emer.Position, Emer.Phones);
             //   page3.emergencyAndReferences11.emergencyDataGridView.Rows[i].Cells[4].Value = Emer.type;
                i++;
            }

            //Refrence Opinion 
            i = 0;
            ICollection<References>  RO_list =JS.References.Where(x => x.type == 1).ToList();//1 References <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< attention
            foreach (References RO in RO_list )
            {
               
                page3.emergencyAndReferences11.referenceDataGridView.Rows.Add(RO.Person_Name, RO.Place_of_Work, RO.Position , RO.Phones, RO.Opinion);

            }



            checkeditoradd = true;//=> allow edit 
        }

        public void clearContorlsData(Control.ControlCollection page)
        {
            foreach (Control c in page)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is DataGridView)
                    ((DataGridView)c).Rows.Clear();
                else if (c is CheckedListBox)
                    for (int i = 0; i < ((CheckedListBox)c).Items.Count; i++)
                        ((CheckedListBox)c).SetItemChecked(i,false);
                else if (c is DateTimePicker)//yyyy/MM/dd
                    ((DateTimePicker)c).Value = new DateTime(2000,01,01);
                else if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Clear();
                else if (c is NumericUpDown)
                    ((NumericUpDown)c).Value=0;
                else if (c is CheckBox)
                    ((CheckBox)c).Checked=false;
                else if (c is GroupBox)
                    clearContorlsData(c.Controls);
                else if (c is UserControl)
                    clearContorlsData(c.Controls);

            }


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
           DialogResult result =MessageBox.Show(null, "هل تريد استمارة جديدة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                resetViewData();
                //you can add not edit
                checkeditoradd = false;
            }
        }

        private void JobSeekerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employment_officeDataSet.Job_seeker' table. You can move, or remove it, as needed.
         

        }

        public void resetViewData() {
            clearContorlsData(page1.Controls);
            clearContorlsData(page2.Controls);
            clearContorlsData(page3.Controls);

            if (page3.Visible)
            {
                currentPageGroupBox.Text = "الصفحة الأولى (1 من 3)";
                page3.Visible = false;
                page1.Visible = true;

                nextButton.Enabled = true;
                previousButton.Enabled = false;
                addButton.Enabled = false;
            }
            else if (page2.Visible)
            {
                currentPageGroupBox.Text = "الصفحة الأولى (1 من 3)";
                page2.Visible = false;
                page1.Visible = true;

                nextButton.Enabled = true;
                previousButton.Enabled = false;
                addButton.Enabled = false;
            }
        }

        private void seacrchBydesiredJobButton_Click(object sender, EventArgs e)
        {
            searchResultDataGridView.Rows.Clear();
            if (desiredJobTextBox.Text != "")
            {
                string desiredJob = Convert.ToString(desiredJobTextBox.Text);
                var Job_seekers = (from t1 in db.Job_seeker
                        join t2 in db.User_Job on t1.National_ID equals t2.User_ID
                        where(t2.Job.Contains(desiredJob))
                        select new { t1 }).ToList();

                // var Job_seekers = db.Job_seeker.Where(x => x.User_Job.Skip(1).Take(1).FirstOrDefault().Job ==desiredJob).ToList();
                if (Job_seekers != null && Job_seekers.Count > 0)
                    foreach (var js in Job_seekers)
                    {
                        searchResultDataGridView.Rows.Add(js.t1.First_name + " " + js.t1.Father_name + " " + js.t1.Second_name, js.t1.National_ID, js.t1.Phone, js.t1.mobile, js.t1.Email);
                    }
                else
                    MessageBox.Show(null, "لا يوجد تطابق", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show(null, "لم يتم إدخال العمل المطلوب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
