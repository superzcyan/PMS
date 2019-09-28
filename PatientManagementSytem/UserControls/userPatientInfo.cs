using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;


namespace PMS.UserControls
{
    public partial class userPatientInfo : UserControl
    {
        MySqlConnection connect = new MySqlConnection("Server = localhost; Uid =root; Password=root; Database =pms; Port =3306; Allow User Variables = True");
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader msqlReader;
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        String allergies = "", medical = "", surgical = "", fammedhistory = "", reviews = "", regularity = "", gender = "", result = "", patientid = "", fullName = "";
        int From, To, paternalRow;
        public userPatientInfo()
        {
            InitializeComponent();
            autoComplete();
           
            
        }

        public void autoComplete()
        {
            connect.Close();
            connect.Open();
            command.Connection = connect;
            command.Parameters.Clear();
            command.CommandText = "Select CONCAT(firstname,' ', middlename,' ', lastname) FROM patients ";
            msqlReader = command.ExecuteReader();
            AutoCompleteStringCollection autoCompletePatient = new AutoCompleteStringCollection();
            while (msqlReader.Read())
            {
                autoCompletePatient.Add(msqlReader.GetString(0));

            }
            txtSearch.AutoCompleteCustomSource = autoCompletePatient;
            connect.Close();

         }

        public void clearControls()
        {
            userPatientInfo userPatientInfoForm = new userPatientInfo();
            foreach (Control controls in tabControl1.Controls)
            {
                if (controls is TextBox)
                {
                    controls.Text = String.Empty;
                }
             
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            infoReload();
            
        }

        public void clearAll()
        {
            foreach (Control obj in grpboxGenInfo.Controls)
            {

                if (obj is TextBox)
                {
                    obj.Text = "";
                }                
            }

            foreach (int i in chkListMedical.CheckedIndices)
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
            chkboxOther1.Checked = false;
            txtothersmed.Text = "";
            txtotherssurgical.Text = "";
            txtgoals.Text = "";
            txtchallenges.Text = "";

            dataGridCurrentMeds.DataSource = null;
            dataGridSupMeds.DataSource = null;
            datagridpersonalhistory.DataSource = null;
            datagridPatients.Refresh();            

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

        public void infoReload()
        {
            txtSearch.Focus();
            radAdd.Checked = true;
            connect.Open();
            command.Connection = connect;
            MySqlDataAdapter adapterpatients = new MySqlDataAdapter("Select *, CONCAT(firstname,' ',middlename,' ',lastname) AS patientname FROM patients", connect);
            
            DataTable tablepatients = new DataTable();
            adapterpatients.Fill(tablepatients);
            datagridPatients.AutoGenerateColumns = false;
            datagridPatients.DataSource = tablepatients;
            datagridPatients.ClearSelection();
            

            command.CommandText = "Select COUNT(*) from patients";
            int count = Convert.ToInt16(command.ExecuteScalar()) + 1;
            txtPatientID.Text = "P" + count.ToString();
            connect.Close();          

        }

        private void addFamMedHistory()
        {
            int highBlood = datagridFamMedHistory.Rows.Add();
            int stroke = datagridFamMedHistory.Rows.Add();
            int bleedDisorder = datagridFamMedHistory.Rows.Add();
            int diabetes = datagridFamMedHistory.Rows.Add();
            int thyroidD = datagridFamMedHistory.Rows.Add();
            int heartD = datagridFamMedHistory.Rows.Add();
            int lungD = datagridFamMedHistory.Rows.Add();
            int lungC = datagridFamMedHistory.Rows.Add();
            int gastroD = datagridFamMedHistory.Rows.Add();
            int colonC = datagridFamMedHistory.Rows.Add();
            int pacreaC = datagridFamMedHistory.Rows.Add();
            int kidneyD = datagridFamMedHistory.Rows.Add();
            int kidneyC = datagridFamMedHistory.Rows.Add();
            int bladderD = datagridFamMedHistory.Rows.Add();
            int bladderC = datagridFamMedHistory.Rows.Add();
            int reproD = datagridFamMedHistory.Rows.Add();
            int ovarianC = datagridFamMedHistory.Rows.Add();
            int endoC = datagridFamMedHistory.Rows.Add();
            int cervicalC = datagridFamMedHistory.Rows.Add();
            int osteo = datagridFamMedHistory.Rows.Add();
            int otherDC = datagridFamMedHistory.Rows.Add();
            datagridFamMedHistory.RowCount = 21;

            datagridFamMedHistory.Rows[highBlood].Cells[0].Value = "High Blood";
            datagridFamMedHistory.Rows[stroke].Cells[0].Value = "Stroke";
            datagridFamMedHistory.Rows[bleedDisorder].Cells[0].Value = "Bleed Disorder";
            datagridFamMedHistory.Rows[diabetes].Cells[0].Value = "Diabetes";
            datagridFamMedHistory.Rows[thyroidD].Cells[0].Value = "Thyroid Disease";
            datagridFamMedHistory.Rows[heartD].Cells[0].Value = "Heart Disease";
            datagridFamMedHistory.Rows[lungC].Cells[0].Value = "Lung Cancer";
            datagridFamMedHistory.Rows[lungD].Cells[0].Value = "Lung Disease";
            datagridFamMedHistory.Rows[gastroD].Cells[0].Value = "Gastrointestinal Disease";
            datagridFamMedHistory.Rows[colonC].Cells[0].Value = "Colon Cancer";
            datagridFamMedHistory.Rows[pacreaC].Cells[0].Value = "Pancreatic Cancer";
            datagridFamMedHistory.Rows[kidneyD].Cells[0].Value = "Kidney Disease";
            datagridFamMedHistory.Rows[kidneyC].Cells[0].Value = "Kidney Cancer";
            datagridFamMedHistory.Rows[bladderD].Cells[0].Value = "Bladder Disease";
            datagridFamMedHistory.Rows[bladderC].Cells[0].Value = "Bladder Cancer";
            datagridFamMedHistory.Rows[reproD].Cells[0].Value = "Reproductive Disease";
            datagridFamMedHistory.Rows[ovarianC].Cells[0].Value = "Ovarian Cancer";
            datagridFamMedHistory.Rows[endoC].Cells[0].Value = "Endometrial Cancer";
            datagridFamMedHistory.Rows[cervicalC].Cells[0].Value = "Cervical Cancer";
            datagridFamMedHistory.Rows[osteo].Cells[0].Value = "Osteoporosis";
            datagridFamMedHistory.Rows[otherDC].Cells[0].Value = "Other Diseases/Cancer";
            datagridFamMedHistory.Columns["colType"].ReadOnly = true;
        }
        private void addhistory()
        {
            int alchol = datagridpersonalhistory.Rows.Add();
            int smoke = datagridpersonalhistory.Rows.Add();
            int caffeine = datagridpersonalhistory.Rows.Add();
            int drugs = datagridpersonalhistory.Rows.Add();
            int excercise = datagridpersonalhistory.Rows.Add();
            datagridpersonalhistory.RowCount = 5;
            datagridpersonalhistory.Rows[alchol].Cells[0].Value = "Alcohol";
            datagridpersonalhistory.Rows[smoke].Cells[0].Value = "Tobacco/Cigar";
            datagridpersonalhistory.Rows[caffeine].Cells[0].Value = "Caffeine";
            datagridpersonalhistory.Rows[drugs].Cells[0].Value = "Drugs";
            datagridpersonalhistory.Rows[excercise].Cells[0].Value = "Excercise";
            datagridpersonalhistory.Columns["colActivity"].ReadOnly = true;
        }
        private void PersonalInfo_Load(object sender, EventArgs e)
        {

            infoReload();

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
                foreach (Control textbox in grpboxMentrualandObs.Controls)
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
                foreach (Control textbox in grpboxMentrualandObs.Controls)
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
            btnSave.Text = "Save";
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
            if (chkboxOther1.Checked == true)
            {
                txtotherssurgical.Enabled = true;
            }
            else
            {
                txtotherssurgical.Enabled = false;
            }
        }


        private void radUpdate_CheckedChanged(object sender, EventArgs e){
            datagridpersonalhistory.DataSource = null;
            datagridpersonalhistory.Rows.Clear();
            clearAll();            
        }

        private void ChkboxChild_CheckedChanged(object sender, EventArgs e){
            if (chkboxChild.Checked == true)
            {
                txtchildnum.Enabled = true;
            }
            else
            {
                txtchildnum.Enabled = false;
                txtchildnum.Text = "";
            }
        }

        private void BtnClear_MouseEnter(object sender, EventArgs e){
            btnClear.ForeColor = Color.White;
        }

        private void BtnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.Black;
        }               
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            infoReload();
        }

        private void TxtPatientID_TextChanged(object sender, EventArgs e)
        {           
            txtPatientID.Text = textInfo.ToTitleCase(txtPatientID.Text);
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                fullName = txtSearch.Text;
                patientid = txtSearch.Text;
                radUpdate.Checked = true;
                searchPatient();
            }
        }

        private void DatagridPatients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            patientid = datagridPatients.CurrentRow.Cells[0].Value.ToString();
            radUpdate.Checked = true;            
            searchPatient();
        }
               
        private void btnSearch_Click(object sender, EventArgs e)
        {
            radUpdate.Checked = true;            
            fullName = txtSearch.Text;
            patientid = txtSearch.Text;
            searchPatient();
        }
      
        private void searchPatient()
        {
            clearAll();
            //Search query using Full Name
            connect.Open();                     
            command.CommandText = "Select patientid FROM patients WHERE CONCAT(firstname, ' ', middlename, ' ', lastname) = '"+ fullName + "' OR patientid = '" + patientid + "'";
            msqlReader = command.ExecuteReader();
            if (msqlReader.Read())
            {
                txtPatientID.Text = msqlReader["patientid"].ToString();
                patientid = txtPatientID.Text;
            }
            connect.Close();
            //Search query using Full Name end

            //SQL query for Searching
            connect.Open();
            
            //fill currentmed dgvtable
            MySqlDataAdapter adaptercurrentmed = new MySqlDataAdapter("Select * FROM currentmedication WHERE currentmedication.patientid = '" + patientid + "'", connect);
            DataTable tablecurrentmed = new DataTable();
            adaptercurrentmed.Fill(tablecurrentmed);
            dataGridCurrentMeds.AutoGenerateColumns = false;
            dataGridCurrentMeds.DataSource = tablecurrentmed;
            //fill currentmed dgvtable end

            //fill supplements dgvtable
            MySqlDataAdapter adaptersupplements = new MySqlDataAdapter("Select * FROM supplements WHERE supplements.patientid = '" + patientid + "'", connect);
            DataTable tablesupplements = new DataTable();
            adaptersupplements.Fill(tablesupplements);
            dataGridSupMeds.AutoGenerateColumns = false;
            dataGridSupMeds.DataSource = tablesupplements;
            //fill supplements dgvtable end

            //fill personalhistory dgvtable
            MySqlDataAdapter adapterpersonalhistory = new MySqlDataAdapter("Select * FROM personalandsocialhistory WHERE personalandsocialhistory.patientid = '" + patientid + "'", connect);
            DataTable tablepersonalhistory = new DataTable();
            adapterpersonalhistory.Fill(tablepersonalhistory);
            datagridpersonalhistory.AutoGenerateColumns = false;
            datagridpersonalhistory.DataSource = tablepersonalhistory;
            //fill personalhistory dgvtable end

            //fill family medical history dgvtable
            MySqlDataAdapter adaptfamilymedhistory = new MySqlDataAdapter("Select * FROM familymedhistory WHERE familymedhistory.patientid = '" + patientid + "'", connect);
            DataTable tablefammedhistory = new DataTable();
            adaptfamilymedhistory.Fill(tablefammedhistory);
            datagridFamMedHistory.AutoGenerateColumns = false;
            datagridFamMedHistory.DataSource = tablefammedhistory;
            //fill family medical history dgvtable end


            //Search query using patientID
            command.CommandText = "Select * FROM patients, healthandwellnessgoals, medicationhistory, menstrual WHERE patients.patientid = '" + patientid + "' AND medicationhistory.patientid = '" + patientid + "'  AND menstrual.patientid = '" + patientid + "' AND healthandwellnessgoals.patientid = '" + patientid + "'";
            msqlReader = command.ExecuteReader();
            if (msqlReader.Read())            {
                //if patient ID exist, fill text boxes from database table
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
                //
                //if patient ID exist, fill text boxes from database table end

                if (regularity == "Regular")
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

                if (txtchildnum.Text == "")
                {
                    txtchildnum.Enabled = false;
                    txtchildnum.Text = "";
                    chkboxChild.Checked = false;
                }
                else
                {
                    txtchildnum.Enabled = true;
                    chkboxChild.Checked = true;
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
                    chkboxOther1.Checked = true;
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
               

                //Retrieve Freview of past 6months from Database start
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
                //Retrieve Freview of past 6months from Database end


            }
            else if (txtPatientID.Text == "")
            {
                MessageBox.Show("Please input patient ID number");

            }
            else
            {
                MessageBox.Show("Patient don't exist");
                clearAll();
            }


            connect.Close();
        }

        private void RadFemale_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radFemale.Checked == true)
            {
                foreach (Control textbox in grpboxMentrualandObs.Controls)
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
                foreach (Control textbox in grpboxMentrualandObs.Controls)
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

        

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            autoComplete();
        }             
        private void DtBirthday_Validated(object sender, EventArgs e)
        {
            command.Parameters.Clear();
            DateTime from = dtBirthday.Value;
            DateTime to = DateTime.Now;
            TimeSpan span = to - from;
            double days = span.TotalDays;
            txtage.Text = Math.Truncate(days / 365).ToString("0");
        }       
        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radAdd.Checked == true)
            {
                clearAll();
                txtPatientID.Enabled = false;
                connect.Open();
                command.Connection = connect;
                command.CommandText = "Select COUNT(*) from patients";
                int count = Convert.ToInt16(command.ExecuteScalar()) + 1;
                txtPatientID.Text = "P" + count.ToString();
                connect.Close();
                addhistory();
                addFamMedHistory();
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


       
        private void addPatient()
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

            foreach(Control obj in grpboxGenInfo.Controls)
            {
                if(obj is TextBox)
                {
                    TextBox textBoxes = obj as TextBox;
                    if (string.IsNullOrEmpty(textBoxes.Text))
                    {
                        MessageBox.Show("Please complete details on general information");
                        break;
                    }
                    else
                    {
                        connect.Open();

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


                       /* foreach (Control textbox in grpboxfam.Controls)
                        {

                            if ((textbox is TextBox) && (!(String.IsNullOrEmpty(textbox.Text))))
                            {
                                fammedhistory += textbox.Tag + "(" + textbox.Text + ")" + ", ";

                            }

                        }
                        fammedhistory = fammedhistory.TrimEnd(',', ' ');*/


                        /*
                        foreach (DataGridViewRow rowPaternal in datagridFamMedHistory.Rows)
                        {
                            if (Convert.ToBoolean(((DataGridViewCheckBoxCell)rowPaternal.Cells["colPaternal"]).Value) == true)
                            {
                                fammedhistory += datagridFamMedHistory.Rows[0].Cells["colType"].Value.ToString() + " (Paternal), ";
                            }
                            if (Convert.ToBoolean(((DataGridViewCheckBoxCell)rowPaternal.Cells["colMaternal"]).Value) == true)
                            {
                                fammedhistory += datagridFamMedHistory.Rows[0].Cells["colType"].Value.ToString() + " (Maternal), ";

                            }

                        }*/

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
                        patientid = "P" + count.ToString();

                        command.CommandText = @"INSERT INTO patients(patientid, firstname, middlename, lastname, gender, birthday, age, address, email, religion, mobileno, homeno, emergencyname, emergencycontact, emergencyrelationship, avesleep, work, occupation, prevoccupation, numberofchildren) 
                                                    VALUES (@patientid, @firstname, @middlename, @lastname, @gender, @birthday, @age, @address, @email, @religion, @mobileno, @homeno, @emergencyname, @emergencycontact, @emergencyrelationship, @avesleep, @work, @occupation, @prevoccupation, @numberofchildren);
                                    INSERT INTO medicationhistory(patientid, historyofillness, medicalhistory, surgicalhistory, medicationsuppallergyhistory, reviewpast6months) 
                                                    VALUES(@patientid, @historyofillness, @medicalhistory, @surgicalhistory, @medicationsuppallergyhistory, @reviewpast6months);                                   
                                    INSERT INTO healthandwellnessgoals(patientid, goals, challenges)
                                                    VALUES(@patientid, @goals, @challenges);
                                    INSERT INTO menstrual(patientid, ageofmens, padperday, daysofmens, regularity, menscycle, agemenopause, nopregnancies, nochildren, nomiscarriage)
                                                    VALUES(@patientid, @ageofmens, @padperday, @daysofmens, @regularity, @menscycle, @agemenopause, @nopregnancies, @nochildren, @nomiscarriage)";



                        command.Parameters.AddWithValue("@patientid", patientid);
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
                        //command.Parameters.AddWithValue("@familymedicalhistory", fammedhistory);
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

                        foreach (DataGridViewRow row in datagridFamMedHistory.Rows)
                        {
                            command.Parameters.Clear();
                            if (!row.IsNewRow)
                            {
                                command.CommandText = @"INSERT INTO familymedhistory(patientid, type, paternal, maternal)
                                                       VALUES (@patientid, @type, @paternal, @maternal)";
                                command.Parameters.AddWithValue("@patientid", patientid);
                                command.Parameters.AddWithValue("@type", row.Cells["colType"].Value);
                                command.Parameters.AddWithValue("@paternal", row.Cells["colPaternal"].Value);
                                command.Parameters.AddWithValue("@maternal", row.Cells["colMaternal"].Value);
                                connect.Open();
                                command.ExecuteNonQuery();
                                connect.Close();
                            }
                        }

                        foreach (DataGridViewRow row in dataGridCurrentMeds.Rows)
                        {
                            command.Parameters.Clear();
                            if (!row.IsNewRow)
                            {
                                command.CommandText = @"INSERT INTO currentmedication(patientid, brandname,   dosage, frequency, lasttaken, regularly)
                                                    VALUES( @patientids, @brandname, @dosage, @frequency, @lasttaken, @regularly)";


                                command.Parameters.AddWithValue("@patientids", patientid);
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


                                command.Parameters.AddWithValue("@patientids", patientid);
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
                            command.CommandText = @"INSERT INTO personalandsocialhistory(patientid, activity, day, week, kind, month)
                                                    VALUES( @patientid, @activity, @day, @week, @kind, @month)";

                            command.Parameters.AddWithValue("@patientid", patientid);
                            command.Parameters.AddWithValue("@activity", row.Cells["colActivity"].Value);
                            command.Parameters.AddWithValue("@day", row.Cells["colPerDay"].Value);
                            command.Parameters.AddWithValue("@week", row.Cells["colPerWeek"].Value);
                            command.Parameters.AddWithValue("@kind", row.Cells["colKind"].Value);
                            command.Parameters.AddWithValue("@month", row.Cells["colMonth"].Value);


                            connect.Open();
                            command.ExecuteNonQuery();
                            connect.Close();
                        }
                        clearAll();
                        MessageBox.Show("Recorded, New Patient ID: " + patientid);
                        this.Controls.Clear();
                        this.InitializeComponent();
                        infoReload();
                    }
                    connect.Close();

                }
                
            }

                
        }
        
        private void updatePatient()
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
                connect.Close();
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


                /*foreach (Control textbox in grpboxfam.Controls)
                {

                    if ((textbox is TextBox) && (!(String.IsNullOrEmpty(textbox.Text))))
                    {
                        fammedhistory += textbox.Tag + "(" + textbox.Text + ")" + ", ";

                    }

                }
                fammedhistory = fammedhistory.TrimEnd(',', ' ');*/
/*
                foreach (DataGridViewRow rowPaternal in datagridFamMedHistory.Rows)
                {
                    if (Convert.ToBoolean(((DataGridViewCheckBoxCell)rowPaternal.Cells["colPaternal"]).Value) == true)
                    {
                        fammedhistory += datagridFamMedHistory.Rows[0].Cells["colType"].Value.ToString() + " (Paternal), ";
                    }  
                        if (Convert.ToBoolean(((DataGridViewCheckBoxCell)rowPaternal.Cells["colMaternal"]).Value) == true)
                    {
                        fammedhistory += datagridFamMedHistory.Rows[0].Cells["colType"].Value.ToString() + " (Maternal), ";
                       
                    }

                }*/

                
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

                command.CommandText = @"UPDATE patients SET firstname = @firstname, middlename = @middlename, lastname = @lastname, gender = @gender, birthday = @birthday, age = @age, address = @address, email = @email, religion = @religion, mobileno =@mobileno, homeno = @homeno, emergencyname = @emergencyname, emergencycontact = @emergencycontact, emergencyrelationship = @emergencyrelationship, avesleep = @avesleep, work = @work, occupation = @occupation, prevoccupation = @prevoccupation, numberofchildren = @numberofchildren 
                                                WHERE patientid = @patientid;

                                                UPDATE medicationhistory SET historyofillness = @historyofillness, medicalhistory = @medicalhistory, surgicalhistory = @surgicalhistory, medicationsuppallergyhistory = @medicationsuppallergyhistory, reviewpast6months = @reviewpast6months
                                                WHERE patientid = @patientid;

                                                UPDATE healthandwellnessgoals SET goals = @goals, challenges = @challenges
                                                WHERE patientid = @patientid; 

                                                UPDATE menstrual SET ageofmens = @ageofmens, padperday = padperday, daysofmens = @daysofmens, regularity = @regularity, menscycle = @menscycle, agemenopause = @agemenopause, nopregnancies = @nopregnancies, nochildren = @nochildren, nomiscarriage = @nomiscarriage
                                                WHERE patientid = @patientid";

                command.Parameters.AddWithValue("@patientid", patientid);
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
                //command.Parameters.AddWithValue("@familymedicalhistory", fammedhistory);
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

                foreach (DataGridViewRow row in datagridFamMedHistory.Rows)
                {
                    command.Parameters.Clear();
                    if (!row.IsNewRow)
                    {
                        command.CommandText = @"UPDATE familymedhistory SET type = @type, paternal = @paternal, maternal = @maternal
                                                       WHERE patientid = @patientid";
                        command.Parameters.AddWithValue("@patientid", patientid);
                        command.Parameters.AddWithValue("@type", row.Cells["colType"].Value);
                        command.Parameters.AddWithValue("@paternal", row.Cells["colPaternal"].Value);
                        command.Parameters.AddWithValue("@maternal", row.Cells["colMaternal"].Value);
                        connect.Open();
                        command.ExecuteNonQuery();
                        connect.Close();
                    }
                }



                MessageBox.Show("Informations succesfully updated!");
                this.Controls.Clear();
                this.InitializeComponent();
                infoReload();                
                radAdd.Checked = true;
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radAdd.Checked)
            {
                addPatient();
                this.InitializeComponent();
                infoReload();
            }
            else if (radUpdate.Checked)
            {
                connect.Open();
                command.Parameters.Clear();
                command.CommandText = "Select * FROM patients, medicationhistory, healthandwellnessgoals, menstrual WHERE patients.patientid = '" + patientid + "' AND medicationhistory.patientid = '" + patientid + "'  AND menstrual.patientid = '" + patientid + "'";


                MySqlDataReader msqlReader = command.ExecuteReader();
                if (msqlReader.Read())
                {
                    updatePatient();                                                    

                }
                else
                {
                    MessageBox.Show("Please check inputs");
                }
                connect.Close();

            }

        }

    }
}

