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

namespace PMS.UserControls
{
    public partial class userPatientRecords : UserControl
    {
        MySqlConnection connect = new MySqlConnection("Server = localhost; Uid =root; Password=root; Database =pms; Port =3306");
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader msqlReader;
        int treatcount, prescribedcount, dosage, prescribedqty = 0, morning = 0, noon = 0, afternoon = 0, quantity = 0;
        string patientid, medicine,  presDate, other, procedure, targetillness, treatDoctor, session, results, treatDate, fullName;
        public string presDoctor;
        public userPatientRecords()
        {
            InitializeComponent();
            loadcmbboxDoctors();
            
        }

        private void loadcmbboxDoctors()
        {
            connect.Open();
            command.CommandText = "SELECT * FROM staffs WHERE position ='Doctor'";
            command.Connection = connect;
            msqlReader = command.ExecuteReader();
            while (msqlReader.Read())
            {
                cmbDoctor.Items.Add(msqlReader.GetString("firstname") +' '+ msqlReader.GetString("middlename") +' '+ msqlReader.GetString("surname"));
            }
            connect.Close();
        }
        
        private void searchPatient()
        {
            connect.Open();            
            command.CommandText = "Select patientid FROM patients WHERE CONCAT(firstname, ' ', middlename, ' ', lastname) = '" + fullName + "' OR patientid = '" + patientid + "'";
            msqlReader = command.ExecuteReader();
            if (msqlReader.Read())
            {
                txtpatientid.Text = msqlReader["patientid"].ToString();
                patientid = txtpatientid.Text;
            }
            connect.Close();

            connect.Open();
            command.Connection = connect;
            MySqlDataAdapter adapter = new MySqlDataAdapter("Select * FROM medicationhistory WHERE medicationhistory.patientid = '" + patientid + "'", connect);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvhistory.AutoGenerateColumns = false;
            dgvhistory.DataSource = table;
                      
            MySqlDataAdapter adapter2 = new MySqlDataAdapter("Select * FROM personalandsocialhistory WHERE personalandsocialhistory.patientid = '" + patientid + "'", connect);

            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            dgvpersonal.AutoGenerateColumns = false;
            dgvpersonal.DataSource = table2;

            MySqlDataAdapter adapter3 = new MySqlDataAdapter("Select * FROM menstrual WHERE menstrual.patientid = '" + patientid + "'", connect);

            DataTable table3 = new DataTable();
            adapter3.Fill(table3);
            dgvmens.AutoGenerateColumns = false;
            dgvmens.DataSource = table3;

            MySqlDataAdapter adapter4 = new MySqlDataAdapter("Select * FROM currentmedication WHERE currentmedication.patientid = '" + patientid + "'", connect);

            DataTable table4 = new DataTable();
            adapter4.Fill(table4);
            dgvmeds.AutoGenerateColumns = false;
            dgvmeds.DataSource = table4;

            MySqlDataAdapter adapter5 = new MySqlDataAdapter("Select * FROM supplements WHERE supplements.patientid = '" + patientid + "'", connect);

            DataTable table5 = new DataTable();
            adapter5.Fill(table5);
            dgvsups.AutoGenerateColumns = false;
            dgvsups.DataSource = table5;

            MySqlDataAdapter adapter6 = new MySqlDataAdapter("Select * FROM appointments WHERE appointments.patientid = '" + patientid + "'", connect);

            DataTable table6 = new DataTable();
            adapter6.Fill(table6);
            dgvappointments.AutoGenerateColumns = false;
            dgvappointments.DataSource = table6;

            MySqlDataAdapter adapter7 = new MySqlDataAdapter("Select * FROM treatments WHERE treatments.patientid = '" + patientid + "'", connect);

            DataTable table7 = new DataTable();
            adapter7.Fill(table7);
            dgvtreatment.AutoGenerateColumns = false;
            dgvtreatment.DataSource = table7;

            MySqlDataAdapter adapter8 = new MySqlDataAdapter("Select * FROM prescriptions WHERE prescriptions.patientid = '" + patientid + "'", connect);

            DataTable table8 = new DataTable();
            adapter8.Fill(table8);
            dgvprescription.AutoGenerateColumns = false;
            dgvprescription.DataSource = table8;
                        
            command.CommandText = "Select * FROM patients, medicationhistory, healthandwellnessgoals WHERE patients.patientid = '" + patientid + "'";
            try
            {
                msqlReader = command.ExecuteReader();
                if (msqlReader.Read())
                {
                    txtpatientid.Text = (msqlReader["patientid"].ToString());
                    txtname.Text = msqlReader.GetValue(1).ToString();
                    txtmidname.Text = msqlReader.GetValue(2).ToString();
                    txtsurname.Text = msqlReader.GetValue(3).ToString();
                    txtaddress.Text = msqlReader.GetValue(4).ToString();
                    txtbirthday.Text = msqlReader.GetValue(6).ToString();
                    txtage.Text = msqlReader.GetValue(7).ToString();
                    txtemailadd.Text = msqlReader.GetValue(8).ToString();
                    txtmobileno.Text = msqlReader.GetValue(9).ToString();
                    txthomeno.Text = msqlReader.GetValue(10).ToString();
                    txtreligion.Text = msqlReader.GetValue(11).ToString();
                    txtemergencyname.Text = msqlReader.GetValue(12).ToString();
                    txtemergencycontact.Text = msqlReader.GetValue(13).ToString();
                    txtrelationship.Text = msqlReader.GetValue(14).ToString();
                    txthistoryofillness.Text = (msqlReader["historyofillness"].ToString());
                    txtgoals.Text = (msqlReader["goals"].ToString());
                    txtchallenges.Text = (msqlReader["challenges"].ToString());
                }
                else if (txtSearch.Text == "")
                {
                    MessageBox.Show("Please input patient ID number");
                    txtSearch.Focus();
                }
                else
                {
                    MessageBox.Show("Patient don't exist");
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

        public void autoComplete()
        {
            fullName = txtSearch.Text;
            connect.Close();
            connect.Open();
            command.Connection = connect;
            command.Parameters.Clear();
            command.CommandText = "Select CONCAT(firstname,' ', middlename,' ', lastname) FROM patients";            
            msqlReader = command.ExecuteReader();
            AutoCompleteStringCollection autoCompletePatient = new AutoCompleteStringCollection();
            while (msqlReader.Read())
            {
                autoCompletePatient.Add(msqlReader.GetString(0));

            }
            txtSearch.AutoCompleteCustomSource = autoCompletePatient;
            connect.Close();

        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                fullName = txtSearch.Text;
                patientid = txtSearch.Text;                
                searchPatient();
            }
        }

        
        private void Txtsearch_TextChanged(object sender, EventArgs e)
        {
            autoComplete();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            fullName = txtSearch.Text;
            patientid = txtSearch.Text;
            searchPatient();
        }

       private void treatmentReset()
        {
            txtproceed.Text = "";
            txtillness.Text = "";
            //cmbDoctor.SelectedIndex = 0;
            txtsession.Text = "";
            txtOtherTreat.Text = "";
        }

        private void prescriptionReset()
        {
            txtmed.Text = "";
            txtdosage.Text = "";
            txtqty.Text = "";
            txtmorning.Text = "";
            txtNoon.Text = "";
            txtafternoon.Text = "";
            txtOtherPresc.Text = "";

        }

        private void BtnEditTreat_Click(object sender, EventArgs e)
        {
            saveTreatment();
        }

        private void addDoctors()
        {
            connect.Open();
            command.CommandText = "SELECT CONCAT(firstname,' ', middlename,' ', surname) FROM staff WHERE position = 'doctors'";

        }

        private void Dgvtreatment_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvtreatment.ClearSelection();
        }

        private void Dgvprescription_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvprescription.ClearSelection();
        }

        private void Dgvprescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillPrescriptionTextbox();
        }

        private void saveTreatment()
        {            

                connect.Open();
                command.Parameters.Clear();
                command.CommandText = @"UPDATE treatments SET  proceed = @proceed, targetillness = @illness, sessions = @session, result= @result, doctor = @doctor
                                        WHERE count = @treatcount AND patientid = @patientid";
                command.Parameters.AddWithValue("@treatcount", treatcount);
                command.Parameters.AddWithValue("@patientid", patientid);
                command.Parameters.AddWithValue("@proceed", txtproceed.Text);
                command.Parameters.AddWithValue("@illness", txtillness.Text);
                command.Parameters.AddWithValue("@session", txtsession.Text);
                command.Parameters.AddWithValue("@doctor", cmbDoctor.Text);
                command.Parameters.AddWithValue("@result", txtOtherTreat.Text);

                command.ExecuteNonQuery();
                connect.Close();

                MySqlDataAdapter adapter7 = new MySqlDataAdapter("Select * FROM treatments WHERE treatments.patientid = '" + patientid + "'", connect);

                DataTable table7 = new DataTable();
                adapter7.Fill(table7);
                dgvtreatment.AutoGenerateColumns = false;
                dgvtreatment.DataSource = table7;

                treatmentReset();
                MessageBox.Show("Treatment Updated!");
                        
        }
        private void addTreatment()
        {                       
                    command.Parameters.Clear();
                    command.CommandText = @"INSERT INTO treatments(patientid, proceed, targetillness, sessions, result, doctor, date )
                                                    VALUES(@patientids, @proceed, @targetillness, @sessions, @result, @doctor, @date)";

                    command.Parameters.AddWithValue("@patientids", patientid);
                    command.Parameters.AddWithValue("@proceed", txtproceed.Text);
                    command.Parameters.AddWithValue("@targetillness", txtillness.Text);
                    command.Parameters.AddWithValue("@sessions", txtsession.Text);
                    command.Parameters.AddWithValue("@result", txtOtherTreat.Text);
                    command.Parameters.AddWithValue("@doctor", cmbDoctor.Text);
                    command.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));

                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();

                    MySqlDataAdapter adapter7 = new MySqlDataAdapter("Select * FROM treatments WHERE treatments.patientid = '" +patientid+ "'", connect);

                    DataTable table7 = new DataTable();
                    adapter7.Fill(table7);
                    dgvtreatment.AutoGenerateColumns = false;
                    dgvtreatment.DataSource = table7;
                    treatmentReset();
                    MessageBox.Show("Recorded");
                    btnAddTreat.Text = "Add";                                          
        }
        private void BtnAddTreat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtproceed.Text) || string.IsNullOrEmpty(txtillness.Text) || string.IsNullOrEmpty(txtsession.Text) || string.IsNullOrEmpty(cmbDoctor.Text) || string.IsNullOrEmpty(txtOtherTreat.Text))
            {
                MessageBox.Show("Please complete all fields");
            }
            else
            {
                addTreatment();
            }
        }               
        public void fillTreamentTextbox()
        {
            treatcount = Convert.ToInt32(dgvtreatment.CurrentRow.Cells[0].Value);
            procedure = dgvtreatment.CurrentRow.Cells[1].Value.ToString();
            targetillness = dgvtreatment.CurrentRow.Cells[2].Value.ToString();
            session = dgvtreatment.CurrentRow.Cells[3].Value.ToString();
            results = dgvtreatment.CurrentRow.Cells[4].Value.ToString();
            treatDoctor = dgvtreatment.CurrentRow.Cells[5].Value.ToString();
            treatDate = dgvtreatment.CurrentRow.Cells[6].Value.ToString();
            txtproceed.Text = procedure;
            txtillness.Text = targetillness;
            txtsession.Text = session;
            txtOtherTreat.Text = results;
            cmbDoctor.Text = treatDoctor;
        }      
        private void Dgvtreatment_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            fillTreamentTextbox();            
        }
        private void BtnDeleteTreat_Click(object sender, EventArgs e)
        {
            patientid = txtpatientid.Text;
            if (dgvtreatment.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete selected treatment?", "Delete treatment", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    connect.Open();
                    command.Parameters.Clear();
                    command.CommandText = "DELETE FROM treatments WHERE count = @treatcount AND patientid = @patientid";
                    command.Parameters.AddWithValue("@treatcount", treatcount);
                    command.Parameters.AddWithValue("@patientid", patientid);
                    command.Parameters.AddWithValue("@proceed", procedure);
                    command.Parameters.AddWithValue("@targetillness", targetillness);
                    command.Parameters.AddWithValue("@sessions", session);
                    command.Parameters.AddWithValue("@result", results);
                    command.Parameters.AddWithValue("@doctor", treatDoctor);
                    command.Parameters.AddWithValue("@date", treatDate);
                    command.ExecuteNonQuery();

                    MySqlDataAdapter adapter7 = new MySqlDataAdapter("Select * FROM treatments WHERE treatments.patientid = '" + txtpatientid.Text + "'", connect);

                    DataTable table7 = new DataTable();
                    adapter7.Fill(table7);
                    dgvtreatment.AutoGenerateColumns = false;
                    dgvtreatment.DataSource = table7;
                    connect.Close();
                    treatmentReset();
                    MessageBox.Show("Deleted!");                                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    dgvtreatment.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to be deleted");
            }
        }

        public void fillPrescriptionTextbox()
        {
            prescribedcount = Convert.ToInt32(dgvprescription.CurrentRow.Cells[0].Value);
            medicine = dgvprescription.CurrentRow.Cells[1].Value.ToString();
            dosage = Convert.ToInt32(dgvprescription.CurrentRow.Cells[2].Value.ToString());
            prescribedqty = Convert.ToInt32(dgvprescription.CurrentRow.Cells[3].Value);
            morning = Convert.ToInt32(dgvprescription.CurrentRow.Cells[4].Value);
            noon = Convert.ToInt32(dgvprescription.CurrentRow.Cells[5].Value);
            afternoon = Convert.ToInt32(dgvprescription.CurrentRow.Cells[6].Value);
            other = dgvprescription.CurrentRow.Cells[7].Value.ToString();
            presDoctor = dgvprescription.CurrentRow.Cells[8].Value.ToString();
            presDate = dgvprescription.CurrentRow.Cells[9].Value.ToString();
            txtmed.Text = medicine;
            txtdosage.Text = dosage.ToString();
            txtqty.Text = prescribedqty.ToString();
            txtmorning.Text = morning.ToString();
            txtNoon.Text = noon.ToString();
            txtafternoon.Text = afternoon.ToString();
            txtOtherPresc.Text = other;
            
        }
        public void fillprescripedVariables()
        {
            prescribedqty = Convert.ToInt32(txtqty.Text);
            dosage = Convert.ToInt32(txtdosage.Text);
            morning = Convert.ToInt32(txtmorning.Text);
            noon = Convert.ToInt32(txtNoon.Text);
            afternoon = Convert.ToInt32(txtafternoon.Text);
        }
        public void filldatagridPrescription()
        {
            
            MySqlDataAdapter adapter8 = new MySqlDataAdapter("Select * FROM prescriptions WHERE prescriptions.patientid = '" + patientid + "'", connect);

            DataTable table8 = new DataTable();
            adapter8.Fill(table8);
            dgvprescription.AutoGenerateColumns = false;
            dgvprescription.DataSource = table8;
            
        }
        private void addPrescription()
        {
            fillprescripedVariables();
            connect.Open();
            command.Parameters.Clear();

            command.CommandText = @"INSERT INTO prescriptions(patientid, medicine, dosage, quantity, morning, noon, afternoon, other, doctor, date)
                                                    VALUES( @patientids, @medicine, @dosage, @quantity, @morning, @noon, @afternoon, @other, @doctor,  @date )";


            command.Parameters.AddWithValue("@patientids", patientid);
            command.Parameters.AddWithValue("@medicine", txtmed.Text);
            command.Parameters.AddWithValue("@dosage", txtdosage.Text);
            command.Parameters.AddWithValue("@quantity", txtqty.Text);
            command.Parameters.AddWithValue("@morning", txtmorning.Text);
            command.Parameters.AddWithValue("@noon", txtNoon.Text);
            command.Parameters.AddWithValue("@afternoon", txtafternoon.Text);
            command.Parameters.AddWithValue("@other", txtOtherPresc.Text);
            command.Parameters.AddWithValue("@doctor", presDoctor);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            filldatagridPrescription();
            connect.Close();
            prescriptionReset();
            MessageBox.Show("Recorded");
        }

        private void savePrescription()
        {

            connect.Open();
            command.Parameters.Clear();
            command.CommandText = @"UPDATE prescriptions SET medicine = @medicine, dosage = @dosage, quantity = @quantity, morning = @morning, noon = @noon, afternoon = @afternoon, doctor = @doctor, date = @date
                                        WHERE count = @count AND patientid = @patientid";
            command.Parameters.AddWithValue("@count", prescribedcount); 
            command.Parameters.AddWithValue("@patientid", patientid);
            command.Parameters.AddWithValue("@medicine", txtmed.Text);
            command.Parameters.AddWithValue("@dosage", txtdosage.Text);
            command.Parameters.AddWithValue("@quantity", txtqty.Text);
            command.Parameters.AddWithValue("@morning", txtmorning.Text);
            command.Parameters.AddWithValue("@noon", txtNoon.Text);
            command.Parameters.AddWithValue("@afternoon", txtafternoon.Text);
            command.Parameters.AddWithValue("@doctor", presDoctor);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            filldatagridPrescription();
            connect.Close();
            prescriptionReset();
            MessageBox.Show("Record has been updated!");
        }
        private void BtnAddPres_Click(object sender, EventArgs e)
        {
            fillprescripedVariables();
            if (txtmed.Text == "" || txtmed.Text == "" || txtdosage.Text == "" || txtdosage.Text == "" || txtqty.Text == "" || txtqty.Text == ""
                || txtmorning.Text == "" || txtmorning.Text == "" || txtNoon.Text == "" || txtNoon.Text == "" || txtafternoon.Text == "" || txtafternoon.Text == ""
                || txtOtherPresc.Text == "")
            {
                MessageBox.Show("Please complete all fields");
            }
            else if (prescribedqty == 0)
            {

                MessageBox.Show("Quantity cannot be 0");
            }
            else if (dosage == 0)
            {

                MessageBox.Show("Dosage cannot be 0");
            }
            else if (morning < 1 & noon < 1 & afternoon < 1)
            {

                MessageBox.Show("Indicate atleast one schedule of intake ");
            }
            else
            {
                addPrescription();
            }
        }

        private void BtnEditPres_Click(object sender, EventArgs e)
        {
            if (dgvprescription.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                savePrescription();
                
            }
            else
            {
                MessageBox.Show("Please select a row record to be updated.");
            }
        }

        private void BtnDeletePres_Click(object sender, EventArgs e)
        {
            if (dgvprescription.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                fillPrescriptionTextbox();
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete selected prescription?", "Delete Prescription", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    connect.Open();
                    command.Parameters.Clear();
                    command.CommandText = "DELETE FROM prescriptions WHERE patientid = @patientid AND count = @count";

                    command.Parameters.AddWithValue("@count", prescribedcount);
                    command.Parameters.AddWithValue("@patientid", patientid);
                    command.Parameters.AddWithValue("@medicine", medicine);
                    command.Parameters.AddWithValue("@dosage", dosage);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@morning", morning);
                    command.Parameters.AddWithValue("@noon", noon);
                    command.Parameters.AddWithValue("@afternoon", afternoon);
                    command.Parameters.AddWithValue("@other", other);
                    command.Parameters.AddWithValue("@doctor", presDoctor);
                    command.Parameters.AddWithValue("@date", presDate);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    filldatagridPrescription();
                    connect.Close();
                    prescriptionReset();
                    MessageBox.Show("Deleted!");

                }
                else if (dialogResult == DialogResult.No)
                {
                    txtmed.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please select a row record to be deleted.");
            }
        }
        private void BtnDeleteTreat_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteTreat.ForeColor = Color.White;
        }

        private void BtnDeleteTreat_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteTreat.ForeColor = Color.Black;
        }


        private void BtnDeletePres_MouseEnter(object sender, EventArgs e)
        {
            btnDeletePres.ForeColor = Color.White;
        }

        private void BtnDeletePres_MouseLeave(object sender, EventArgs e)
        {
            btnDeletePres.ForeColor = Color.Black;
        }

    }
}
