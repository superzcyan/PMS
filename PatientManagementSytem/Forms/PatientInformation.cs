﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    
    public partial class PatientInfo : Form
    {
        MySqlConnection connect = new MySqlConnection("Server = localhost; Uid =root; Password=root; Database =pms; Port =3306; Allow User Variables = True");
        MySqlCommand command = new MySqlCommand();
        String allergies = "", medical = "", surgical = "", fammedhistory = "", reviews = "", regularity = "", gender = "", result = "", patientid = "";
        int From, To;


        public PatientInfo()
        {
            InitializeComponent();
            command.Connection = connect;           
        }

        public  void clearAll()
        {




            foreach (Control obj in groupBox1.Controls)
            {

                if (obj is TextBox)
                {
                    obj.Text = "";
                }
                if (obj is RichTextBox)
                {
                    obj.Text = "";
                }

                radFemale.Checked = false;
                radMale.Checked = false;
            }
           

            foreach(int i in chkListMedical.CheckedIndices)
            {
                chkListMedical.SetItemCheckState(i, CheckState.Unchecked);
            }

            foreach (int i in chkListSurgical.CheckedIndices)
            {
                chkListSurgical.SetItemCheckState(i, CheckState.Unchecked);
            }

            foreach (int i in chkListAllergy.CheckedIndices)
            {
                chkListAllergy.SetItemCheckState(i, CheckState.Unchecked);
            }

            foreach (int i in chkListGeneral.CheckedIndices)
            {
                chkListGeneral.SetItemCheckState(i, CheckState.Unchecked);

            }
            foreach (int i in chkListNeuro.CheckedIndices)
            {
                chkListNeuro.SetItemCheckState(i, CheckState.Unchecked);

            }

            foreach (int i in chkListSkin.CheckedIndices)
            {
                chkListSkin.SetItemCheckState(i, CheckState.Unchecked);

            }

            foreach (int i in chkListCardio.CheckedIndices)
            {
                chkListCardio.SetItemCheckState(i, CheckState.Unchecked);

            }

            foreach (int i in chkListGastro.CheckedIndices)
            {
                chkListGastro.SetItemCheckState(i, CheckState.Unchecked);

            }
            foreach (int i in chkListKidney.CheckedIndices)
            {
                chkListKidney.SetItemCheckState(i, CheckState.Unchecked);

            }
            foreach (int i in chkListRepro.CheckedIndices)
            {
                chkListRepro.SetItemCheckState(i, CheckState.Unchecked);

            }
            foreach (int i in chkListEyes.CheckedIndices)
            {
                chkListEyes.SetItemCheckState(i, CheckState.Unchecked);

            }
            foreach (int i in chkListRespi.CheckedIndices)
            {
                chkListRespi.SetItemCheckState(i, CheckState.Unchecked);

            }
            foreach (int i in chkListEndo.CheckedIndices)
            {
                chkListEndo.SetItemCheckState(i, CheckState.Unchecked);

            }
            foreach (int i in chkListHema.CheckedIndices)
            {
                chkListHema.SetItemCheckState(i, CheckState.Unchecked);

            }
            foreach (int i in chkListSkel.CheckedIndices)
            {
                chkListSkel.SetItemCheckState(i, CheckState.Unchecked);

            }
            foreach (int i in chkListPsych.CheckedIndices)
            {
                chkListPsych.SetItemCheckState(i, CheckState.Unchecked);

            }            

            foreach (Control obj in grpboxfam.Controls)
            {
                if (obj is TextBox)
                {
                    obj.Text = "";
                }
            }
            foreach (Control obj in grpboxHistory.Controls)
            {
                if (obj is TextBox)
                {
                    obj.Text = "";
                }
            }


            dtBirthday.ResetText();
            chkboxOther.Checked = false;
            chkboxOther2.Checked = false;
            txtothersmed.Text = "";
            txtotherssurgical.Text = "";
            txtgoals.Text = "";
            txtchallenges.Text = "";

            dataGridCurrentMeds.DataSource = null;
            dataGridSupMeds.DataSource = null;
            datagridpersonalhistory.DataSource = null;



        }


        private void txtage_TextChanged(object sender, EventArgs e)
        {

            //if (txtage.Text != "Age")
            //{
            //    int age = 0;
            //    age = Convert.ToInt32(txtage.Text);
            //    if (age > 0)
            //    {

            //        txtaddress.Focus();
            //    }

            //    else
            //    {
            //        MessageBox.Show("Invalid Birthday");
            //        txtage.Text = "Age";
            //        dtBirthday.Focus();
            //    }
            //}



        }

            private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            command.Parameters.Clear();
            DateTime from = dtBirthday.Value;
            DateTime to = DateTime.Now;
            TimeSpan span = to - from;
            double days = span.TotalDays;
            txtage.Text = Math.Truncate(days / 365).ToString("0");
           
           

        }
        
        private void PersonalInfo_Load(object sender, EventArgs e)
        {
            txtpatientID.Focus();
            radAdd.Checked = true;
            connect.Open();
            command.Connection = connect;

            MySqlDataAdapter adapterpatients = new MySqlDataAdapter("Select *, CONCAT(firstname,' ',middlename,' ',lastname) AS patientname FROM patients", connect);


            DataTable tablepatients = new DataTable();
            adapterpatients.Fill(tablepatients);
            datagridPatients.AutoGenerateColumns = false;
            datagridPatients.DataSource = tablepatients;


            command.CommandText = "Select COUNT(*) from patients";
            int count = Convert.ToInt16(command.ExecuteScalar()) + 1;
            txtpatientID.Text = "P00" + count.ToString();
            connect.Close();



            int a = datagridpersonalhistory.Rows.Add();
            int b = datagridpersonalhistory.Rows.Add();
            int c = datagridpersonalhistory.Rows.Add();
            int d = datagridpersonalhistory.Rows.Add();
            int f = datagridpersonalhistory.Rows.Add();
            datagridpersonalhistory.RowCount = 5;
            datagridpersonalhistory.Rows[a].Cells[0].Value = "Alcohol";
            datagridpersonalhistory.Rows[b].Cells[0].Value = "Tobacco/Cigar";
            datagridpersonalhistory.Rows[c].Cells[0].Value = "Caffeine";
            datagridpersonalhistory.Rows[d].Cells[0].Value = "Drugs";
            datagridpersonalhistory.Rows[f].Cells[0].Value = "Excercise";
            datagridpersonalhistory.Columns["colActivity"].ReadOnly = true;

          



        }
              
        private void btnExt_Click(object sender, EventArgs e)
        {

            Forms.Dashboard menu = new Forms.Dashboard();
            {
                menu.lblname.Text = lblname.Text;
                
                this.Close();
                menu.Show();
            }

        }
        

        private void txtsurname_LostFocus(object sender, EventArgs e)
        {
            
            connect.Open();
            command.Connection = connect;
            command.Parameters.Clear();
            command.CommandText = "Select * from patients where (firstname = @firstname AND middlename = middlename AND lastname = lastname AND birthday = @birthday)";            
            command.Parameters.AddWithValue("@firstname", txtname.Text);
            command.Parameters.AddWithValue("@middlename", txtmidname.Text);
            command.Parameters.AddWithValue("@surname", txtsurname.Text);
            command.Parameters.AddWithValue("@birthday", dtBirthday.Text);
            try
            {
                MySqlDataReader msqlReader = command.ExecuteReader();
                if (msqlReader.Read())
                {

                    MessageBox.Show("Patient Already Exist");

                }

            }
            catch (Exception er)
            {
                //do something with the exception
                MessageBox.Show(er.Message);

            }
            finally
            {
                //always close the connection
                this.connect.Close();
            }
        }

        
        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && (e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtmidname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && (e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtsurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && (e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtreligion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && (e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && (e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            {
                e.Handled = true;
            }           
        }

        private void txthome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && (e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            {
                e.Handled = true;
            }           
        }

        private void txtnamemergency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && (e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtrelationship_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && (e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtcontactemergency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && (e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            {
                e.Handled = true;
            }
           
        }
             

        

        private void txtmobile_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtmobileno.SelectionStart > txtmobileno.Text.Length)
            {
                txtmobileno.Select(txtmobileno.Text.Length, 0);
            }
        }

        private void txthome_MouseUp(object sender, MouseEventArgs e)
        {
            if (txthome.SelectionStart > txthome.Text.Length)
            {
                txthome.Select(txthome.Text.Length, -4);
            }
        }

        private void radFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radFemale.Checked == true)
            {
                foreach (Control textbox in groupBox9.Controls)
                {

                    if (textbox is TextBox)
                    {
                        textbox.Enabled = true;
                    }
                }
                radirreg.Enabled = true;
                radregular.Enabled = true;
            }
            else
            {
                foreach (Control textbox in groupBox9.Controls)
                {

                    if (textbox is TextBox)
                    {
                        textbox.Enabled = false;
                        textbox.Text = "";
                    }
                }
                radirreg.Enabled = false;
                radregular.Enabled = false;
                radirreg.Checked = false;
                radregular.Checked = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSubmit.Text = "Save";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Object itemChecked in chkListMedical.CheckedItems)
            {
                medical += itemChecked.ToString() + ", ";
            }
            medical += txtothersmed.Text;
            txtothersmed.Text = medical;
        }

        private void chkboxOther_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxOther.Checked == true)
            {
                txtothersmed.Enabled = true;
            }
            else
            {
                txtothersmed.Enabled = false;
            }
        }

       
        /*private void listviewFam_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            
            if (listviewFam.Items[1].Checked == true)
            {
                txthb.Enabled = true;
            }
            if (listviewFam.Items[1].Checked == true)
            {
                txtstroke.Enabled = true;
            }

            if (listviewFam.Items[2].Checked == true)
            {
                txtbleeding.Enabled = true;
            }
            if (listviewFam.Items[3].Checked == true)
            {
                txtdiabetes.Enabled = true;
            }
            if (listviewFam.Items[4].Checked == true)
            {
                txtthyroid.Enabled = true;
            }
            else
            {
                txthb.Enabled = false;
                txtstroke.Enabled = false;
                txtbleeding.Enabled = false;
                txtdiabetes.Enabled = false;
                txtthyroid.Enabled = false;
            }


        }*/


        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Object item in chkListGeneral.CheckedItems)
            {
                reviews += item.ToString() + ", ";

            }
            foreach (Object item in chkListNeuro.CheckedItems)
            {
                reviews += item.ToString() + ", ";

            }

            foreach (Object item in chkListSkin.CheckedItems)
            {
                reviews += item.ToString() + ", ";

            }

            foreach (Object item in chkListCardio.CheckedItems)
            {
                reviews += item.ToString() + ", ";

            }

            foreach (Object item in chkListGastro.CheckedItems)
            {
                reviews += item.ToString() + ", ";

            }
            foreach (Object item in chkListKidney.CheckedItems)
            {
                reviews += item.ToString() + ", ";

            }
            foreach (Object item in chkListRepro.CheckedItems)
            {
                reviews += item.ToString() + ", ";

            }
            foreach (Object item in chkListEyes.CheckedItems)
            {
                reviews += item.ToString() + ", ";

            }
            foreach (Object item in chkListRespi.CheckedItems)
            {
                reviews += item.ToString() + ", ";

            }
            foreach (Object item in chkListEndo.CheckedItems)
            {
                reviews += item.ToString() + ", ";

            }
            foreach (Object item in chkListHema.CheckedItems)
            {
                reviews += item.ToString() + ", ";

            }
            foreach (Object item in chkListSkel.CheckedItems)
            {
                reviews += item.ToString() + ", ";

            }
            foreach (Object item in chkListPsych.CheckedItems)
            {
                reviews += item.ToString() + ", ";

            }
            reviews = reviews.TrimEnd(',', ' ');
            txtwork.Text = reviews;
        }

        private void chkOther1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxOther2.Checked == true)
            {
                txtotherssurgical.Enabled = true;
            }
            else
            {
                txtotherssurgical.Enabled = false;
            }
        }

        private void checkBox95_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox95.Checked == true)
            {
                txtchildnum.Enabled = true;
            }
            else
            {
                txtchildnum.Enabled = false;
                txtchildnum.Text = "";
            }
        }

        private void radUpdate_CheckedChanged(object sender, EventArgs e)
        {
            clearAll();
            btnSubmit.Text = "Save";
        }

       

        private void datagridPatients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            patientid = datagridPatients.CurrentRow.Cells[0].Value.ToString();            
            radUpdate.Checked = true;
            txtpatientID.Text = patientid;
            btnSearch.PerformClick();
        }                      

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (int check in chkListMedical.CheckedIndices)
            {
                chkListMedical.SetItemCheckState(check, CheckState.Unchecked);
            }

            connect.Open();


            MySqlDataAdapter adaptercurrentmed = new MySqlDataAdapter("Select * FROM currentmedication WHERE currentmedication.patientid = '" + txtpatientID.Text + "'", connect);
            DataTable tablecurrentmed = new DataTable();
            adaptercurrentmed.Fill(tablecurrentmed);
            dataGridCurrentMeds.AutoGenerateColumns = false;
            dataGridCurrentMeds.DataSource = tablecurrentmed;


            MySqlDataAdapter adaptersupplements = new MySqlDataAdapter("Select * FROM supplements WHERE supplements.patientid = '" + txtpatientID.Text + "'", connect);
            DataTable tablesupplements = new DataTable();
            adaptersupplements.Fill(tablesupplements);
            dataGridSupMeds.AutoGenerateColumns = false;
            dataGridSupMeds.DataSource = tablesupplements;

            MySqlDataAdapter adapterpersonalhistory = new MySqlDataAdapter("Select * FROM personalandsocialhistory WHERE personalandsocialhistory.patientid = '" + txtpatientID.Text + "'", connect);
            DataTable tablepersonalhistory = new DataTable();
            adapterpersonalhistory.Fill(tablepersonalhistory);
            datagridpersonalhistory.AutoGenerateColumns = false;
            datagridpersonalhistory.DataSource = tablepersonalhistory;

            
            command.CommandText = "Select * FROM patients, medicationhistory, healthandwellnessgoals, menstrual WHERE patients.patientid = '" + txtpatientID.Text + "' AND medicationhistory.patientid = '" + txtpatientID.Text + "'  AND menstrual.patientid = '" + txtpatientID.Text + "'"  ;


                MySqlDataReader msqlReader = command.ExecuteReader();
            if (msqlReader.Read())
            {
                txtname.Text = msqlReader["firstname"].ToString();
                txtmidname.Text = msqlReader["middlename"].ToString();
                txtsurname.Text = msqlReader["lastname"].ToString();
                gender = msqlReader["gender"].ToString();
                txtaddress.Text = msqlReader["address"].ToString();
                dtBirthday.Value = Convert.ToDateTime(msqlReader["birthday"]);
                txtage.Text = msqlReader["age"].ToString();
                txtemail.Text = msqlReader["email"].ToString();
                txtmobileno.Text = msqlReader["mobileno"].ToString();
                txthome.Text = msqlReader["homeno"].ToString();
                txtreligion.Text = msqlReader["religion"].ToString();
                txtnamemergency.Text = msqlReader["emergencyname"].ToString();
                txtEmobile.Text = msqlReader["emergencycontact"].ToString();
                txtrelationship.Text = msqlReader["emergencyrelationship"].ToString();
                txthistory.Text = (msqlReader["historyofillness"].ToString());
                txtgoals.Text = (msqlReader["goals"].ToString());
                txtchallenges.Text = (msqlReader["challenges"].ToString());
                txtsleep.Text = (msqlReader["avesleep"].ToString());
                txtwork.Text = (msqlReader["work"].ToString());
                txtoccupation.Text = (msqlReader["occupation"].ToString());
                txtprevoccupation.Text = (msqlReader["prevoccupation"].ToString());
                txtchildnum.Text = (msqlReader["numberofchildren"].ToString());
                txtagemens.Text = (msqlReader["ageofmens"].ToString());
                txtpads.Text = (msqlReader["padperday"].ToString());
                txtdaysmens.Text = (msqlReader["daysofmens"].ToString());
                txtageofmenopause.Text = (msqlReader["agemenopause"].ToString());
                txtnoofpreg.Text = (msqlReader["nopregnancies"].ToString());
                txtnoofchild.Text = (msqlReader["nochildren"].ToString());
                txtnomiscar.Text = (msqlReader["nomiscarriage"].ToString());
                txtmenscycle.Text = (msqlReader["menscycle"].ToString());
                regularity = (msqlReader["regularity"].ToString());

                if(regularity  == "Regular")
                {
                    radregular.Checked = true;
                }
                else
                {
                    radirreg.Checked = true;
                }


                if (gender == "Male")
                {
                    radMale.Checked = true;
                }
                else
                {
                    radFemale.Checked = true;
                }

                if(txtchildnum.Text == "")
                {
                    txtchildnum.Enabled = false;
                    txtchildnum.Text = "";
                    checkBox95.Checked = false;
                }
                else
                {
                    txtchildnum.Enabled = true;
                    checkBox95.Checked = true;
                }

                medical = msqlReader["medicalhistory"].ToString();
                String[] meds = medical.Split(',');
                for (int i = 0; i < meds.Length; i++)
                {
                    medical += meds[i];
                }
                for (int i = 0; i < chkListMedical.Items.Count; i++)
                {

                    if (medical.Contains((string)chkListMedical.Items[i]))
                    {
                        chkListMedical.SetItemChecked(i, true);
                    }

                }
                if (medical.Contains("Other"))
                {
                    chkboxOther.Checked = true;
                    From = medical.IndexOf("Other(") + "Other(".Length;
                    To = medical.IndexOf(")", From);
                    result = medical.Substring(From, To - From);
                    txtothersmed.Text = result;
                }
                else
                {
                    result = "";
                }

                surgical = msqlReader["surgicalhistory"].ToString();
                String[] surg = surgical.Split(',');
                for (int i = 0; i < surg.Length; i++)
                {
                    surgical += surg[i];
                }
                for (int i = 0; i < chkListSurgical.Items.Count; i++)
                {

                    if (surgical.Contains((string)chkListSurgical.Items[i]))
                    {
                        chkListSurgical.SetItemChecked(i, true);
                    }

                }
                if (surgical.Contains("Other"))
                {
                    chkboxOther2.Checked = true;
                    From = surgical.IndexOf("Other(") + "Other(".Length;
                    To = surgical.IndexOf(")", From);
                    result = surgical.Substring(From, To - From);
                    txtotherssurgical.Text = result;
                }
                else
                {
                    result = "";
                }

                allergies = msqlReader["medicationsuppallergyhistory"].ToString();
                String[] allerg = allergies.Split(',');
                for (int i = 0; i < allerg.Length; i++)
                {
                    allergies += allerg[i];
                }
                for (int i = 0; i < chkListAllergy.Items.Count; i++)
                {

                    if (allergies.Contains((string)chkListAllergy.Items[i]))
                    {
                        chkListAllergy.SetItemChecked(i, true);
                    }

                }                
                
                fammedhistory = msqlReader["familymedicalhistory"].ToString();
                if (fammedhistory.Contains("High Blood Pressure"))
                {
                    From = fammedhistory.IndexOf("High Blood Pressure(") + "High Blood Pressure(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txthb.Text = result;
                }
                if (fammedhistory.Contains("Stroke"))
                {
                    From = fammedhistory.IndexOf("Stroke(") + "Stroke(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtstroke.Text = result;
                }
                if (fammedhistory.Contains("Bleeding Disorder"))
                {
                    From = fammedhistory.IndexOf("Bleeding Disorder(") + "Bleeding Disorder(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtbleeding.Text = result;
                }
                if (fammedhistory.Contains("Diabetes"))
                {
                    From = fammedhistory.IndexOf("Diabetes(") + "Diabetes(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtdiabetes.Text = result;
                }
                if (fammedhistory.Contains("Thyroid Disease"))
                {
                    From = fammedhistory.IndexOf("Thyroid Disease(") + "Thyroid Disease(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtthyroid.Text = result;
                }
                if (fammedhistory.Contains("Heart Disease"))
                {
                    From = fammedhistory.IndexOf("Heart Disease(") + "Heart Disease(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtheartd.Text = result;
                }
                if (fammedhistory.Contains("Lung Disease"))
                {
                    From = fammedhistory.IndexOf("Lung Disease(") + "Lung Disease(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtlungd.Text = result;
                    result = "";
                }
                if (fammedhistory.Contains("Lung Cancer"))
                {
                    From = fammedhistory.IndexOf("Lung Cancer(") + "Lung Cancer(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtlungc.Text = result;
                }
                if (fammedhistory.Contains("Gastrointestinal Disease"))
                {
                    From = fammedhistory.IndexOf("Gastrointestinal Disease(") + "Gastrointestinal Disease(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtgastro.Text = result;
                }
                if (fammedhistory.Contains("Colon Cancer"))
                {
                    From = fammedhistory.IndexOf("Colon Cancer(") + "Colon Cancer(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtcolonc.Text = result;
                }
                if (fammedhistory.Contains("Pancreatic Cancer"))
                {
                    From = fammedhistory.IndexOf("Pancreatic Cancer(") + "Pancreatic Cancer(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtpancrea.Text = result;
                }
                if (fammedhistory.Contains("Kidney Disease"))
                {
                    From = fammedhistory.IndexOf("Kidney Disease(") + "Kidney Disease(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtkidneyd.Text = result;
                }
                if (fammedhistory.Contains("Kidney Cancer"))
                {
                    From = fammedhistory.IndexOf("Kidney Cancer(") + "Kidney Cancer(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtkidneyc.Text = result;
                }
                if (fammedhistory.Contains("Bladder Disease"))
                {
                    From = fammedhistory.IndexOf("Bladder Disease(") + "Bladder Disease(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtbladderd.Text = result;
                }
                if (fammedhistory.Contains("Bladder Cancer"))
                {
                    From = fammedhistory.IndexOf("Bladder Cancer(") + "Bladder Cancer(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtbladderc.Text = result;
                }
                if (fammedhistory.Contains("Reproductive Disease"))
                {
                    From = fammedhistory.IndexOf("Reproductive Disease(") + "Reproductive Disease(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtreprod.Text = result;
                }
                if (fammedhistory.Contains("Ovarian Cancer"))
                {
                    From = fammedhistory.IndexOf("Ovarian Cancer(") + "Ovarian Cancer(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtovarianc.Text = result;
                }
                if (fammedhistory.Contains("Endometrial Cancer"))
                {
                    From = fammedhistory.IndexOf("Endometrial Cancer(") + "Endometrial Cancer(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtendoc.Text = result;
                }
                if (fammedhistory.Contains("Cervical Cancer"))
                {
                    From = fammedhistory.IndexOf("Cervical Cancer(") + "Cervical Cancer(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtcervc.Text = result;
                }
                if (fammedhistory.Contains("Osteoporosis"))
                {
                    From = fammedhistory.IndexOf("Osteoporosis(") + "Osteoporosis(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtosteo.Text = result;
                }
                if (fammedhistory.Contains("Other Disease/Cancer"))
                {
                    From = fammedhistory.IndexOf("Other Disease/Cancer(") + "Other Disease/Cancer(".Length;
                    To = fammedhistory.IndexOf(")", From);
                    result = fammedhistory.Substring(From, To - From);
                    txtotherdc.Text = result;
                }
                else
                {
                    result = "";
                }

                reviews = msqlReader["reviewpast6months"].ToString();
                String[] rev = reviews.Split(',');
                for (int i = 0; i < rev.Length; i++)
                {
                    reviews += rev[i];
                }

                for (int i = 0; i < chkListGeneral.Items.Count; i++)
                {

                    if (reviews.Contains((string)chkListGeneral.Items[i]))
                    {
                        chkListGeneral.SetItemChecked(i, true);
                    }

                }

                for (int i = 0; i < chkListGastro.Items.Count; i++)
                {

                    if (reviews.Contains((string)chkListGastro.Items[i]))
                    {
                        chkListGastro.SetItemChecked(i, true);
                    }

                }

                for (int i = 0; i < chkListNeuro.Items.Count; i++)
                {

                    if (reviews.Contains((string)chkListNeuro.Items[i]))
                    {
                        chkListNeuro.SetItemChecked(i, true);
                    }

                }

                for (int i = 0; i < chkListSkin.Items.Count; i++)
                {

                    if (reviews.Contains((string)chkListSkin.Items[i]))
                    {
                        chkListSkin.SetItemChecked(i, true);
                    }

                }


                for (int i = 0; i < chkListCardio.Items.Count; i++)
                {

                    if (reviews.Contains((string)chkListCardio.Items[i]))
                    {
                        chkListCardio.SetItemChecked(i, true);
                    }

                }

                 for (int i = 0; i < chkListGastro.Items.Count; i++)
                {

                    if (reviews.Contains((string)chkListGastro.Items[i]))
                    {
                        chkListGastro.SetItemChecked(i, true);
                    }

                }

                for (int i = 0; i < chkListKidney.Items.Count; i++)
                {

                    if (reviews.Contains((string)chkListKidney.Items[i]))
                    {
                        chkListKidney.SetItemChecked(i, true);
                    }

                }

                for (int i = 0; i < chkListRepro.Items.Count; i++)
                {

                    if (reviews.Contains((string)chkListRepro.Items[i]))
                    {
                        chkListRepro.SetItemChecked(i, true);
                    }

                }

                for (int i = 0; i < chkListEyes.Items.Count; i++)
                {

                    if (reviews.Contains((string)chkListEyes.Items[i]))
                    {
                        chkListEyes.SetItemChecked(i, true);
                    }

                }

                for (int i = 0; i < chkListRespi.Items.Count; i++)
                {

                    if (reviews.Contains((string)chkListRespi.Items[i]))
                    {
                        chkListRespi.SetItemChecked(i, true);
                    }

                }

                for (int i = 0; i < chkListEndo.Items.Count; i++)
                {

                    if (reviews.Contains((string)chkListEndo.Items[i]))
                    {
                        chkListEndo.SetItemChecked(i, true);
                    }

                }

                for (int i = 0; i < chkListHema.Items.Count; i++)
                {

                    if (reviews.Contains((string)chkListHema.Items[i]))
                    {
                        chkListHema.SetItemChecked(i, true);
                    }

                }

                for (int i = 0; i < chkListSkel.Items.Count; i++)
                {

                    if (reviews.Contains((string)chkListSkel.Items[i]))
                    {
                        chkListSkel.SetItemChecked(i, true);
                    }

                }

                for (int i = 0; i < chkListPsych.Items.Count; i++)
                {

                    if (reviews.Contains((string)chkListPsych.Items[i]))
                    {
                        chkListPsych.SetItemChecked(i, true);
                    }

                }
                
            }
            else if (txtpatientID.Text == "")
            {
                MessageBox.Show("Please input patient ID number");

            }
            else
            {
                MessageBox.Show("Patient don't exist");
            }
            
           
           connect.Close();
          
    }

        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radAdd.Checked == true)
            {
                btnSearch.Visible = false;
                txtpatientID.Enabled = false;              
                connect.Open();
                command.Connection = connect;
                command.CommandText = "Select COUNT(*) from patients";
                int count = Convert.ToInt16(command.ExecuteScalar()) + 1;
                txtpatientID.Text = "P00" + count.ToString();
                connect.Close();
            }
            else
            {
                btnSearch.Visible = true;
                txtpatientID.Enabled = true;
                txtpatientID.Text = "";
                clearAll();

            }
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        

        private void txtsurname_Validated(object sender, EventArgs e)
        {
            connect.Open();
            command.Connection = connect;
            command.Parameters.Clear();
            command.CommandText = "Select * from patients where firstname = @firstname and middlename = @middlename and lastname = @lastname and birthday = @birthday";
            command.Parameters.AddWithValue("@firstname", txtname.Text);
            command.Parameters.AddWithValue("@middlename", txtmidname.Text);
            command.Parameters.AddWithValue("@surname", txtsurname.Text);
            command.Parameters.AddWithValue("@birthday", dtBirthday.Text);
          
                MySqlDataReader msqlReader = command.ExecuteReader();
                if (msqlReader.Read())
                {

                    MessageBox.Show("Patient Already Exist");

                }


            connect.Close();
        }

        private void dateTimePicker1_Validated(object sender, EventArgs e)
        {
            connect.Open();
            command.Connection = connect;
            command.Parameters.Clear();
            command.CommandText = "Select * from patients where firstname = @firstname and middlename = @middlename and lastname = @lastname and birthday = @birthday";
            command.Parameters.AddWithValue("@firstname", txtname.Text);
            command.Parameters.AddWithValue("@middlename", txtmidname.Text);
            command.Parameters.AddWithValue("@surname", txtsurname.Text);
            command.Parameters.AddWithValue("@birthday", dtBirthday.Text);

            MySqlDataReader msqlReader = command.ExecuteReader();
            if (msqlReader.Read())
            {

                MessageBox.Show("Patient Already Exist");

            }


            connect.Close();
        }

        private void txtagemens_TextChanged(object sender, EventArgs e)
        {
            if (!(txtagemens.Text == ""))
            {
                radirreg.Enabled = true;
                radregular.Enabled = true;
            }
            else
            {
                radirreg.Enabled = false;
                radregular.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
          
            this.Controls.Clear();
            this.InitializeComponent();

        }
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "Submit")
            {
                foreach (RadioButton rad in grpGender.Controls)
                {
                    if (rad.Checked)
                    {
                        gender = rad.Text;
                    }
                }
                connect.Open();
                command.Connection = connect;
                command.Parameters.Clear();
                command.CommandText = "Select * from patients where firstname = @firstname and middlename = @middlename and lastname = @lastname and birthday = @birthday";
                command.Parameters.AddWithValue("@firstname", txtname.Text);
                command.Parameters.AddWithValue("@middlename", txtmidname.Text);
                command.Parameters.AddWithValue("@surname", txtsurname.Text);
                command.Parameters.AddWithValue("@birthday", dtBirthday.Text);

                MySqlDataReader msqlReader = command.ExecuteReader();
                if (msqlReader.Read())
                {

                    MessageBox.Show("Patient Already Exist");

                }

                connect.Close();

                if ((txtname.Text == "Name") || (txtmidname.Text == "MiddleName") || (txtsurname.Text == "Surname") || (txtmobileno.Text == " ") || (txthome.Text == " ") || (txtage.Text == "Age") || (txtaddress.Text == "Address") || (txtnamemergency.Text == "Name")
                    || (txtEmobile.Text == "Contact") || (txtrelationship.Text == "Relationship") || (gender == "Gender"))
                {
                    MessageBox.Show("Please complete details on personal informations");
                }

                else
                {

                    connect.Open();

                    foreach (Object itemChecked in chkListMedical.CheckedItems)
                    {
                        medical += itemChecked.ToString() + ", ";
                    }
                    medical += "Other( "+ txtothersmed.Text +" )";
                    medical = medical.TrimEnd(',', ' ');

                    foreach (Object itemChecked in chkListSurgical.CheckedItems)
                    {
                        surgical += itemChecked.ToString() + ", ";
                    }
                    surgical += "Other( " +txtotherssurgical.Text + " )";
                    surgical = surgical.TrimEnd(',', ' ');


                    foreach (Object itemChecked in chkListAllergy.CheckedItems)
                    {

                        allergies += itemChecked.ToString() + ", ";

                    }
                    allergies = allergies.TrimEnd(',', ' ');
                    

                    foreach (Control textbox in grpboxfam.Controls)
                    {

                        if ((textbox is TextBox) && (!(String.IsNullOrEmpty(textbox.Text))))
                        {
                            fammedhistory += textbox.Tag + "(" + textbox.Text + ")" + ", ";

                        }

                    }
                    fammedhistory = fammedhistory.TrimEnd(',', ' ');

                    foreach (Object item in chkListGeneral.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";                    

                    }
                    foreach (Object item in chkListNeuro.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    
                    foreach (Object item in chkListSkin.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    
                    foreach (Object item in chkListCardio.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    
                    foreach (Object item in chkListGastro.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    foreach (Object item in chkListKidney.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    foreach (Object item in chkListRepro.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    foreach (Object item in chkListEyes.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    foreach (Object item in chkListRespi.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    foreach (Object item in chkListEndo.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    foreach (Object item in chkListHema.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    foreach (Object item in chkListSkel.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    foreach (Object item in chkListPsych.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    reviews = reviews.TrimEnd(',', ' ');


                    foreach (Control radbox in grpboxregularity.Controls)
                    {

                        if ((radbox is RadioButton) && ((RadioButton)radbox).Checked)
                            regularity = radbox.Text;
                    }
                    
                    command.Parameters.Clear();
                    command.CommandText = "Select COUNT(*) from patients";
                    int count = Convert.ToInt16(command.ExecuteScalar()) + 1;
                    txtpatientID.Text = "P00" + count.ToString();

                    command.CommandText = @"INSERT INTO patients(patientid, firstname, middlename, lastname, gender, birthday, age, address, email, religion, mobileno, homeno, emergencyname, emergencycontact, emergencyrelationship, avesleep, work, occupation, prevoccupation, numberofchildren) 
                                                    VALUES (@patientid, @firstname, @middlename, @lastname, @gender, @birthday, @age, @address, @email, @religion, @mobileno, @homeno, @txtnamemergency, @txtrelationship, @mEmergencyMobile, @avesleep, @work, @occupation, @prevoccupation, @numberofchildren);
                                    INSERT INTO medicationhistory(patientid, historyofillness, medicalhistory, surgicalhistory, medicationsuppallergyhistory, familymedicalhistory, reviewpast6months) 
                                                    VALUES(@patientid, @historyofillness, @medicalhistory, @surgicalhistory, @medicationsuppallergyhistory, @familymedicalhistory, @reviewpast6months);                                   
                                    INSERT INTO healthandwellnessgoals(patientid, goals, challenges)
                                                    VALUES(@patientid, @goals, @challenges);
                                    INSERT INTO menstrual(patientid, ageofmens, padperday, daysofmens, regularity, menscycle, agemenopause, nopregnancies, nochildren, nomiscarriage)
                                                    VALUES(@patientid, @ageofmens, @padperday, @daysofmens, @regularity, @menscycle, @agemenopause, @nopregnancies, @nochildren, @nomiscarriage)";



                    command.Parameters.AddWithValue("@patientid", txtpatientID.Text);
                    command.Parameters.AddWithValue("@firstname", txtname.Text);
                    command.Parameters.AddWithValue("@middlename", txtmidname.Text);
                    command.Parameters.AddWithValue("@lastname", txtsurname.Text);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@birthday", dtBirthday.Text);
                    command.Parameters.AddWithValue("@age", txtage.Text);
                    command.Parameters.AddWithValue("@address", txtaddress.Text);
                    command.Parameters.AddWithValue("@email", txtemail.Text);
                    command.Parameters.AddWithValue("@religion", txtreligion.Text);
                    command.Parameters.AddWithValue("@mobileno", txtmobileno.Text);
                    command.Parameters.AddWithValue("@homeno", txthome.Text);
                    command.Parameters.AddWithValue("@emergencyname", txtnamemergency.Text);
                    command.Parameters.AddWithValue("@emergencycontact", txtEmobile.Text);
                    command.Parameters.AddWithValue("@emergencyrelationship", txtrelationship.Text);

                    command.Parameters.AddWithValue("@avesleep", txtsleep.Text);
                    command.Parameters.AddWithValue("@work", txtwork.Text);
                    command.Parameters.AddWithValue("@occupation", txtoccupation.Text);
                    command.Parameters.AddWithValue("@prevoccupation", txtprevoccupation.Text);
                    command.Parameters.AddWithValue("@numberofchildren", txtnoofchild.Text);

                    command.Parameters.AddWithValue("@historyofillness", txthistory.Text);
                    command.Parameters.AddWithValue("@medicalhistory", medical);
                    command.Parameters.AddWithValue("@surgicalhistory", surgical);
                    command.Parameters.AddWithValue("@medicationsuppallergyhistory", allergies);
                    command.Parameters.AddWithValue("@familymedicalhistory", fammedhistory);
                    command.Parameters.AddWithValue("@reviewpast6months", reviews);


                    command.Parameters.AddWithValue("@goals", txtgoals.Text);
                    command.Parameters.AddWithValue("@challenges", txtchallenges.Text);

                    command.Parameters.AddWithValue("@ageofmens", txtagemens.Text);
                    command.Parameters.AddWithValue("@padperday", txtpads.Text);
                    command.Parameters.AddWithValue("@daysofmens", txtdaysmens.Text);
                    command.Parameters.AddWithValue("@regularity", regularity);
                    command.Parameters.AddWithValue("@menscycle", txtmenscycle.Text);
                    command.Parameters.AddWithValue("@agemenopause", txtageofmenopause.Text);
                    command.Parameters.AddWithValue("@nopregnancies", txtnoofpreg.Text);
                    command.Parameters.AddWithValue("@nochildren", txtnoofchild.Text);
                    command.Parameters.AddWithValue("@nomiscarriage", txtnomiscar.Text);

                    command.ExecuteNonQuery();
                    connect.Close();


                    foreach (DataGridViewRow row in dataGridCurrentMeds.Rows)
                    {
                        command.Parameters.Clear();
                        if (!row.IsNewRow)
                        {
                            command.CommandText = @"INSERT INTO currentmedication(patientid, brandname,   dosage, frequency, lasttaken, regularly)
                                                    VALUES( @patientids, @brandname, @dosage, @frequency, @lasttaken, @regularly)";


                            command.Parameters.AddWithValue("@patientids", txtpatientID.Text);
                            command.Parameters.AddWithValue("@brandname", row.Cells["colName"].Value);
                            command.Parameters.AddWithValue("@dosage", row.Cells["colDosage"].Value);
                            command.Parameters.AddWithValue("@frequency", row.Cells["colFreq"].Value);
                            command.Parameters.AddWithValue("@lasttaken", row.Cells["collastTaken"].Value);
                            command.Parameters.AddWithValue("@regularly", row.Cells["colTaken"].Value);
                            connect.Open();
                            command.ExecuteNonQuery();
                            connect.Close();
                        }
                    }

                    foreach (DataGridViewRow row in dataGridSupMeds.Rows)
                    {
                        command.Parameters.Clear();
                        if (!row.IsNewRow)
                        {
                            command.CommandText = @"INSERT INTO supplements(patientid, brandname, dosage, frequency, lasttaken, regularly)
                                                    VALUES( @patientids, @brandname, @dosage, @frequency, @lasttaken, @regularly)";


                            command.Parameters.AddWithValue("@patientids", txtpatientID.Text);
                            command.Parameters.AddWithValue("@brandname", row.Cells["colSupname"].Value);
                            command.Parameters.AddWithValue("@dosage", row.Cells["colSupdosage"].Value);
                            command.Parameters.AddWithValue("@frequency", row.Cells["colSupFreq"].Value);
                            command.Parameters.AddWithValue("@lasttaken", row.Cells["colSuptaken"].Value);
                            command.Parameters.AddWithValue("@regularly", row.Cells["colSupRegular"].Value);
                            connect.Open();
                            command.ExecuteNonQuery();
                            connect.Close();
                        }
                    }

                    foreach (DataGridViewRow row in datagridpersonalhistory.Rows)
                    {
                        command.Parameters.Clear();
                        //if ((Convert.ToBoolean(row.Cells[0].Value) == true))
                        //{
                            command.CommandText = @"INSERT INTO personalandsocialhistory(patientid, activity, day, week, kind, month)
                                                    VALUES( @patientid, @activity, @day, @week, @kind, @month)";

                            command.Parameters.AddWithValue("@patientid", txtpatientID.Text);
                            command.Parameters.AddWithValue("@activity", row.Cells["colActivity"].Value);
                            command.Parameters.AddWithValue("@day", row.Cells["colPerDay"].Value);
                            command.Parameters.AddWithValue("@week", row.Cells["colPerWeek"].Value);
                            command.Parameters.AddWithValue("@kind", row.Cells["colKind"].Value);
                            command.Parameters.AddWithValue("@month", row.Cells["colMonth"].Value);


                            connect.Open();
                            command.ExecuteNonQuery();
                            connect.Close();

                        //}
                    }
                    MessageBox.Show("Recorded, New Patient ID: " + txtpatientID.Text);
                }
                connect.Close();
            }
            else if( btnSubmit.Text == "Save")
            {
                medical = "";
                surgical = "";
                reviews = "";
                allergies = "";
                fammedhistory = "";

                if ((txtname.Text == "Name") || (txtmidname.Text == "MiddleName") || (txtsurname.Text == "Surname") || (txtmobileno.Text == " ") || (txthome.Text == " ") || (txtage.Text == "Age") || (txtaddress.Text == "Address") || (txtnamemergency.Text == "Name")
                   || (txtEmobile.Text == "Contact") || (txtrelationship.Text == "Relationship") || (gender == "Gender"))
                {
                    MessageBox.Show("Please complete details on personal informations");
                }
                else
                {
                    connect.Open();
                    command.Parameters.Clear();
                    foreach (Object itemChecked in chkListMedical.CheckedItems)
                    {
                        medical += itemChecked.ToString() + ", ";
                    }
                    medical += "Other( " + txtothersmed.Text + " )";
                    medical = medical.TrimEnd(',', ' ');

                    foreach (Object itemChecked in chkListSurgical.CheckedItems)
                    {
                        surgical += itemChecked.ToString() + ", ";
                    }
                    surgical += "Other( " + txtotherssurgical.Text + " )";
                    surgical = surgical.TrimEnd(',', ' ');


                    foreach (Object itemChecked in chkListAllergy.CheckedItems)
                    {

                        allergies += itemChecked.ToString() + ", ";

                    }
                    allergies = allergies.TrimEnd(',', ' ');


                    foreach (Control textbox in grpboxfam.Controls)
                    {

                        if ((textbox is TextBox) && (!(String.IsNullOrEmpty(textbox.Text))))
                        {
                            fammedhistory += textbox.Tag + "(" + textbox.Text + ")" + ", ";

                        }

                    }
                    fammedhistory = fammedhistory.TrimEnd(',', ' ');

                    foreach (Object item in chkListGeneral.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }

                    foreach (Object item in chkListNeuro.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }

                    foreach (Object item in chkListSkin.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }

                    foreach (Object item in chkListCardio.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }

                    foreach (Object item in chkListGastro.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    foreach (Object item in chkListKidney.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    foreach (Object item in chkListRepro.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    foreach (Object item in chkListEyes.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    foreach (Object item in chkListRespi.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    foreach (Object item in chkListEndo.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    foreach (Object item in chkListHema.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    foreach (Object item in chkListSkel.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    foreach (Object item in chkListPsych.CheckedItems)
                    {
                        reviews += item.ToString() + ", ";

                    }
                    reviews = reviews.TrimEnd(',', ' ');


                    foreach (Control radbox in grpboxregularity.Controls)
                    {

                        if ((radbox is RadioButton) && ((RadioButton)radbox).Checked)
                            regularity = radbox.Text;
                    }

                    command.CommandText = 

                    command.CommandText = @"UPDATE patients SET patientid = @patientid, firstname = @firstname, middlename = @middlename, lastname = @lastname, gender = @gender, birthday = @birthday, age = @age, address = @address, email = @email, religion = @religion, mobileno =@mobileno, homeno = @homeno, emergencyname = @emergencyname, emergencycontact = @emergencycontact, emergencyrelationship = @emergencyrelationship, avesleep = @avesleep, work = @work, occupation = @occupation, prevoccupation = @prevoccupation, numberofchildren = @numberofchildren 
                                                WHERE patientid = @patientid;

                                                UPDATE medicationhistory SET patientid = @patientid, historyofillness = @historyofillness, medicalhistory = @medicalhistory, surgicalhistory = @surgicalhistory, medicationsuppallergyhistory = @medicationsuppallergyhistory, familymedicalhistory = @familymedicalhistory, reviewpast6months = @reviewpast6months
                                                WHERE patientid = @patientid;

                                                UPDATE healthandwellnessgoals SET patientid = @patientid, goals = @goals, challenges = @challenges
                                                WHERE patientid = @patientid; 

                                                UPDATE menstrual SET patientid = @patientid, ageofmens = @ageofmens, padperday = padperday, daysofmens = @daysofmens, regularity = @regularity, menscycle = @menscycle, agemenopause = @agemenopause, nopregnancies = @nopregnancies, nochildren = @nochildren, nomiscarriage = @nomiscarriage
                                                WHERE patientid = @patientid";

                    command.Parameters.AddWithValue("@patientid", txtpatientID.Text);
                    command.Parameters.AddWithValue("@firstname", txtname.Text);
                    command.Parameters.AddWithValue("@middlename", txtmidname.Text);
                    command.Parameters.AddWithValue("@lastname", txtsurname.Text);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@birthday", dtBirthday.Text);
                    command.Parameters.AddWithValue("@age", txtage.Text);
                    command.Parameters.AddWithValue("@address", txtaddress.Text);
                    command.Parameters.AddWithValue("@email", txtemail.Text);
                    command.Parameters.AddWithValue("@religion", txtreligion.Text);
                    command.Parameters.AddWithValue("@mobileno", txtmobileno.Text);
                    command.Parameters.AddWithValue("@homeno", txthome.Text);
                    command.Parameters.AddWithValue("@emergencyname", txtnamemergency.Text);
                    command.Parameters.AddWithValue("@emergencycontact", txtEmobile.Text);
                    command.Parameters.AddWithValue("@emergencyrelationship", txtrelationship.Text);

                    command.Parameters.AddWithValue("@avesleep", txtsleep.Text);
                    command.Parameters.AddWithValue("@work", txtwork.Text);
                    command.Parameters.AddWithValue("@occupation", txtoccupation.Text);
                    command.Parameters.AddWithValue("@prevoccupation", txtprevoccupation.Text);
                    command.Parameters.AddWithValue("@numberofchildren", txtnoofchild.Text);

                    command.Parameters.AddWithValue("@historyofillness", txthistory.Text);
                    command.Parameters.AddWithValue("@medicalhistory", medical);
                    command.Parameters.AddWithValue("@surgicalhistory", surgical);
                    command.Parameters.AddWithValue("@medicationsuppallergyhistory", allergies);
                    command.Parameters.AddWithValue("@familymedicalhistory", fammedhistory);
                    command.Parameters.AddWithValue("@reviewpast6months", reviews);


                    command.Parameters.AddWithValue("@goals", txtgoals.Text);
                    command.Parameters.AddWithValue("@challenges", txtchallenges.Text);

                    command.Parameters.AddWithValue("@ageofmens", txtagemens.Text);
                    command.Parameters.AddWithValue("@padperday", txtpads.Text);
                    command.Parameters.AddWithValue("@daysofmens", txtdaysmens.Text);
                    command.Parameters.AddWithValue("@regularity", regularity);
                    command.Parameters.AddWithValue("@menscycle", txtmenscycle.Text);
                    command.Parameters.AddWithValue("@agemenopause", txtageofmenopause.Text);
                    command.Parameters.AddWithValue("@nopregnancies", txtnoofpreg.Text);
                    command.Parameters.AddWithValue("@nochildren", txtnoofchild.Text);
                    command.Parameters.AddWithValue("@nomiscarriage", txtnomiscar.Text);

                    command.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Informations succesfully updated!");
                    btnSubmit.Text = "Submit";
                    radUpdate.Checked = false;
                    radAdd.Checked = true;
                }
            }
             
        }

    }
    
}
