using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class PatientView : Form
    {
        MySqlConnection connect = new MySqlConnection("Server = localhost; Uid =root; Password=root; Database =pms; Port =3306");
        MySqlCommand command = new MySqlCommand();
        int prescribedqty = 0, morning = 0, noon = 0, afternoon = 0;
        string patientid, medicine, dosage, presDoctor, presDate, other, procedure, illness, treatDoctor, session, results, treatDate;
        public PatientView()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Forms.Dashboard menu = new Forms.Dashboard();
            {
                menu.lblname.Text = lbllogin.Text;
                         
                this.Close();
                menu.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            patientid = txtsearch.Text;
            connect.Open();
            command.Connection = connect;

            MySqlDataAdapter adapter = new MySqlDataAdapter("Select * FROM medicationhistory WHERE medicationhistory.patientid = '" + txtsearch.Text + "'", connect);
             
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvhistory.AutoGenerateColumns = false;
                dgvhistory.DataSource = table;


            
            
            MySqlDataAdapter adapter2 = new MySqlDataAdapter("Select * FROM personalandsocialhistory WHERE personalandsocialhistory.patientid = '" + txtsearch.Text + "'", connect);

                DataTable table2 = new DataTable();
                adapter2.Fill(table2);
                dgvpersonal.AutoGenerateColumns = false;
                dgvpersonal.DataSource = table2;


            MySqlDataAdapter adapter3 = new MySqlDataAdapter("Select * FROM menstrual WHERE menstrual.patientid = '" + txtsearch.Text + "'", connect);

                DataTable table3 = new DataTable();
                adapter3.Fill(table3);
                dgvmens.AutoGenerateColumns = false;
                dgvmens.DataSource = table3;


            MySqlDataAdapter adapter4 = new MySqlDataAdapter("Select * FROM currentmedication WHERE currentmedication.patientid = '" + txtsearch.Text + "'", connect);

                DataTable table4 = new DataTable();
                adapter4.Fill(table4);
                dgvmeds.AutoGenerateColumns = false;
                dgvmeds.DataSource = table4;


            MySqlDataAdapter adapter5 = new MySqlDataAdapter("Select * FROM supplements WHERE supplements.patientid = '" + txtsearch.Text + "'", connect);

                DataTable table5 = new DataTable();
                adapter5.Fill(table5);
                dgvsups.AutoGenerateColumns = false;
                dgvsups.DataSource = table5;

            MySqlDataAdapter adapter6 = new MySqlDataAdapter("Select * FROM appointments WHERE appointments.patientid = '" + txtsearch.Text + "'", connect);

                DataTable table6 = new DataTable();
                adapter6.Fill(table6);
                dgvappointments.AutoGenerateColumns = false;
                dgvappointments.DataSource = table6;

            MySqlDataAdapter adapter7 = new MySqlDataAdapter("Select * FROM treatments WHERE treatments.patientid = '" + txtsearch.Text + "'", connect);

                DataTable table7 = new DataTable();
                adapter7.Fill(table7);
                dgvtreatment.AutoGenerateColumns = false;
                dgvtreatment.DataSource = table7;

            MySqlDataAdapter adapter8 = new MySqlDataAdapter("Select * FROM prescriptions WHERE prescriptions.patientid = '" + txtsearch.Text + "'", connect);

                DataTable table8 = new DataTable();
                adapter8.Fill(table8);
                dgvprescription.AutoGenerateColumns = false;
                dgvprescription.DataSource = table8;



            command.CommandText = "Select * FROM patients, medicationhistory, healthandwellnessgoals WHERE patients.patientid = '" + txtsearch.Text + "'";
            try
            {
                MySqlDataReader msqlReader = command.ExecuteReader();
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
                else if (txtsearch.Text == "Patient ID") 
                {
                    MessageBox.Show("Please input patient ID number");
                    txtsearch.Focus();
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

          

        private void button4_Click(object sender, EventArgs e)
        {
            Forms.Dashboard menu = new Forms.Dashboard();
            {
                menu.lblname.Text = lblname.Text;
                
                this.Close();
                menu.Show();
            }
        }

        private void treatmentReset()
        {
            txtproceed.Text = "Procedure Name";
            txtillness.Text = "Type of illness";
            cmbDoctor.SelectedIndex = 0;
            txtsession.Text = "No. of Session/s";
            txtOtherTreat.Text = "";
        }

        private void prescriptionReset()
        {
            txtmed.Text ="Medicine";
            txtdosage.Text = "Dosage";
            txtqty.Text = "Quantity";
            txtmorning.Text = "Morning";
            txtNoon.Text = "Noon";
            txtafternoon.Text = "Afternoon";
            txtOtherPresc.Text = "";
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();

            command.CommandText = @"INSERT INTO prescriptions(patientid, medicine, dosage, quantity, morning, noon, afternoon, doctor, date)
                                                    VALUES( @patientids, @medicine, @dosage, @quantity, @morning, @noon, @afternoon, @doctor,  @date )";

       
            command.Parameters.AddWithValue("@patientids", txtpatientid.Text);
            command.Parameters.AddWithValue("@medicine", txtmed.Text);
            command.Parameters.AddWithValue("@dosage", txtdosage.Text);
            command.Parameters.AddWithValue("@quantity", txtqty.Text);
            command.Parameters.AddWithValue("@morning", txtmorning.Text);
            command.Parameters.AddWithValue("@noon", txtNoon.Text);
            command.Parameters.AddWithValue("@afternoon", txtafternoon.Text);
            command.Parameters.AddWithValue("@doctor", lbllogin.Text);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("MMMM dd ,yyyy"));

            command.ExecuteNonQuery();
            connect.Close();

            MySqlDataAdapter adapter8 = new MySqlDataAdapter("Select * FROM prescriptions WHERE prescriptions.patientid = '" + txtsearch.Text + "'", connect);

            DataTable table8 = new DataTable();
            adapter8.Fill(table8);
            dgvprescription.AutoGenerateColumns = false;
            dgvprescription.DataSource = table8;

            MessageBox.Show("Recorded");

        }

        
        private void btnAddTreat_Click(object sender, EventArgs e)
        {
            if (txtproceed.Text == "Procedure Name" || txtillness.Text == "Type of illness" || txtsession.Text == "No. of Sessions/s" || cmbDoctor.Text == "Choose Doctor" || txtOtherTreat.Text == "")
            {
                MessageBox.Show("Please complete all fields");
            }

            else
            {
                if (btnAddTreat.Text == "Add")
                {
                    command.Parameters.Clear();
                    command.CommandText = @"INSERT INTO treatments(patientid, proceed, targetillness, sessions, result, doctor, date )
                                                    VALUES(@patientids, @proceed, @targetillness, @sessions, @result, @doctor, @date)";

                    command.Parameters.AddWithValue("@patientids", txtpatientid.Text);
                    command.Parameters.AddWithValue("@proceed", txtproceed.Text);
                    command.Parameters.AddWithValue("@targetillness", txtillness.Text);
                    command.Parameters.AddWithValue("@sessions", txtsession.Text);
                    command.Parameters.AddWithValue("@result", txtOtherTreat.Text);
                    command.Parameters.AddWithValue("@doctor", cmbDoctor.Text);
                    command.Parameters.AddWithValue("@date", DateTime.Now.ToString("MMMM dd, yyyy"));

                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();

                    MySqlDataAdapter adapter7 = new MySqlDataAdapter("Select * FROM treatments WHERE treatments.patientid = '" + txtsearch.Text + "'", connect);

                    DataTable table7 = new DataTable();
                    adapter7.Fill(table7);
                    dgvtreatment.AutoGenerateColumns = false;
                    dgvtreatment.DataSource = table7;

                    treatmentReset();

                    MessageBox.Show("Recorded");
                    btnAddTreat.Text = "Add";
                }
                else if (btnAddTreat.Text == "Save")
                {
                    connect.Open();
                    command.Parameters.Clear();
                    command.CommandText = @"UPDATE treatments SET proceed = @proceed, targetillness = @illness, sessions = @session, result= @result, doctor = @doctor
                                        WHERE patientid = @patientid";
                    command.Parameters.AddWithValue("@patientid", txtpatientid.Text);
                    command.Parameters.AddWithValue("@proceed", txtproceed.Text);
                    command.Parameters.AddWithValue("@illness", txtillness.Text);
                    command.Parameters.AddWithValue("@session", txtsession.Text);
                    command.Parameters.AddWithValue("@doctor", cmbDoctor.Text);
                    command.Parameters.AddWithValue("@result", txtOtherTreat.Text);

                    command.ExecuteNonQuery();
                    connect.Close();

                    MySqlDataAdapter adapter7 = new MySqlDataAdapter("Select * FROM treatments WHERE treatments.patientid = '" + txtsearch.Text + "'", connect);

                    DataTable table7 = new DataTable();
                    adapter7.Fill(table7);
                    dgvtreatment.AutoGenerateColumns = false;
                    dgvtreatment.DataSource = table7;

                    treatmentReset();

                    MessageBox.Show("Treatment Updated!");

                    btnAddTreat.Text = "Add";
                }

            }
        }

      
        private void btnExit_Click(object sender, EventArgs e)
        {
            Forms.Dashboard menu = new Forms.Dashboard();
            {
                menu.lblname.Text = lblname.Text;
                
                this.Close();
                menu.Show();
            }

        }

       

        private void btnDeletePres_Click(object sender, EventArgs e)
        {
            if (dgvprescription.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete selected prescription?", "Delete Prescription", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    connect.Open();
                    command.Parameters.Clear();
                    command.CommandText = "DELETE FROM prescriptions WHERE patientid = @patientid AND proceed =@proceed AND targetillness = @targetillness AND sessions = @sessions  AND result = @result AND doctor = @doctor AND date=@date";


                    command.Parameters.AddWithValue("@patientid", txtpatientid.Text);
                    command.Parameters.AddWithValue("@proceed", procedure);
                    command.Parameters.AddWithValue("@targetillness", illness);
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
                    MessageBox.Show("Deleted!");


                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("You haven't selected any row.");
            }
        }

        private void btnEditPres_Click(object sender, EventArgs e)
        {
            if (dgvprescription.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string medicine = dgvtreatment.SelectedRows[0].Cells[0].Value + string.Empty;
                string dosage = dgvtreatment.SelectedRows[0].Cells[1].Value + string.Empty;
                string quantity = dgvtreatment.SelectedRows[0].Cells[2].Value + string.Empty;
                string morning = dgvtreatment.SelectedRows[0].Cells[3].Value + string.Empty;
                string noon = dgvtreatment.SelectedRows[0].Cells[4].Value + string.Empty;
                string afternoon = dgvtreatment.SelectedRows[0].Cells[5].Value + string.Empty;
                string other = dgvtreatment.SelectedRows[0].Cells[6].Value + string.Empty;
                txtmed.Text = medicine;
                txtdosage.Text = dosage;
                txtqty.Text = quantity;
                txtmorning.Text = morning;
                txtNoon.Text = noon;
                txtafternoon.Text = afternoon;
                txtOtherPresc.Text = other;
                btnAddPres.Text = "Save";
            }
            else
            {
                MessageBox.Show("You haven't selected any row.");
            }
        }

        private void btnDeleteTreat_Click(object sender, EventArgs e) //-1
        {
            if (dgvtreatment.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete selected prescription?", "Delete Prescription", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    connect.Open();
                    command.Parameters.Clear();
                    command.CommandText = "DELETE FROM treatments WHERE patientid = @patientid AND proceed =@proceed AND targetillness = @targetillness AND sessions = @sessions  AND result = @result AND doctor = @doctor AND date=@date";


                    command.Parameters.AddWithValue("@patientid", txtpatientid.Text);
                    command.Parameters.AddWithValue("@proceed", procedure);
                    command.Parameters.AddWithValue("@targetillness", illness);
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
                    MessageBox.Show("Deleted!");


                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("You haven't selected any row.");
            }
        }

        private void btnAddPres_Click(object sender, EventArgs e) //1
        {
            if (!(txtmed.Text == "Medicine" || txtmed.Text == "" || txtdosage.Text == "Dosage" || txtdosage.Text == "" || txtqty.Text == "Quantity" || txtqty.Text == ""
                || txtmorning.Text == "Morning" || txtmorning.Text == "" || txtNoon.Text == "Noon" || txtNoon.Text == "" || txtafternoon.Text == "Afternoon" || txtafternoon.Text == ""
                || txtOtherPresc.Text == ""))
            {

                prescribedqty = Int32.Parse(txtqty.Text);
                morning = Int32.Parse(txtmorning.Text);
                noon = Int32.Parse(txtNoon.Text);
                afternoon = Int32.Parse(txtafternoon.Text);
                dosage = txtdosage.Text;
                if (btnAddPres.Text == "Add")
                {
                    connect.Open();
                    command.Parameters.Clear();

                    command.CommandText = @"INSERT INTO prescriptions(patientid, medicine, dosage, quantity, morning, noon, afternoon, other, doctor, date)
                                                    VALUES( @patientids, @medicine, @dosage, @quantity, @morning, @noon, @afternoon, @other, @doctor,  @date )";


                    command.Parameters.AddWithValue("@patientids", txtpatientid.Text);
                    command.Parameters.AddWithValue("@medicine", txtmed.Text);
                    command.Parameters.AddWithValue("@dosage", txtdosage.Text);
                    command.Parameters.AddWithValue("@quantity", txtqty.Text);
                    command.Parameters.AddWithValue("@morning", txtmorning.Text);
                    command.Parameters.AddWithValue("@noon", txtNoon.Text);
                    command.Parameters.AddWithValue("@afternoon", txtafternoon.Text);
                    command.Parameters.AddWithValue("@other", txtOtherPresc.Text);
                    command.Parameters.AddWithValue("@doctor", lblname.Text);
                    command.Parameters.AddWithValue("@date", DateTime.Now.ToString("MMMM dd ,yyyy"));

                    command.ExecuteNonQuery();
                    connect.Close();
                    connect.Open();
                    MySqlDataAdapter adapter8 = new MySqlDataAdapter("Select * FROM prescriptions WHERE prescriptions.patientid = '" + txtsearch.Text + "'", connect);

                    DataTable table8 = new DataTable();
                    adapter8.Fill(table8);
                    dgvprescription.AutoGenerateColumns = false;
                    dgvprescription.DataSource = table8;
                    connect.Close();

                    MessageBox.Show("Recorded");
                    btnAddPres.Text = "Add";
                }

            }
            else if (btnAddPres.Text == "Save")
            {
                connect.Open();
                command.Parameters.Clear();
                command.CommandText = @"UPDATE treatments SET medicine = @medicine, dosage = @dosage, quantity = @quantity, morning = @morning, noon = @noon, afternoon = @afternoon, doctor = @doctor, date = @date
                                        WHERE patientid = @patientid";
                command.Parameters.AddWithValue("@patientids", txtpatientid.Text);
                command.Parameters.AddWithValue("@medicine", txtmed.Text);
                command.Parameters.AddWithValue("@dosage", txtdosage.Text);
                command.Parameters.AddWithValue("@quantity", txtqty.Text);
                command.Parameters.AddWithValue("@morning", txtmorning.Text);
                command.Parameters.AddWithValue("@noon", txtNoon.Text);
                command.Parameters.AddWithValue("@afternoon", txtafternoon.Text);
                command.Parameters.AddWithValue("@doctor", lbllogin.Text);
                command.Parameters.AddWithValue("@date", DateTime.Now.ToString("MMMM dd ,yyyy"));
                command.ExecuteNonQuery();


                command.Parameters.Clear();
                MySqlDataAdapter adapter7 = new MySqlDataAdapter("Select * FROM treatments WHERE treatments.patientid = '" + txtpatientid.Text + "'", connect);

                DataTable table7 = new DataTable();
                adapter7.Fill(table7);
                dgvtreatment.AutoGenerateColumns = false;
                dgvtreatment.DataSource = table7;

                connect.Close();
                MessageBox.Show("Updated!");
                btnAddPres.Text = "Add";

            }

            else if (txtmed.Text == "Medicine" || txtmed.Text == "" || txtdosage.Text == "Dosage" || txtdosage.Text == "" || txtqty.Text == "Quantity" || txtqty.Text == ""
                || txtmorning.Text == "Morning" || txtmorning.Text == "" || txtNoon.Text == "Noon" || txtNoon.Text == "" || txtafternoon.Text == "Afternoon" || txtafternoon.Text == ""
                || txtOtherPresc.Text == "")
            {
                MessageBox.Show("Please complete all fields or 0 if none");
            }
            else if (prescribedqty <= 0)
            {

                MessageBox.Show("Quantity cannot be 0");
            }
            else if (dosage == "0")
            {

                MessageBox.Show("Dosage cannot be 0");
            }
            else if (morning < 1 & noon < 1 & afternoon < 1)
            {

                MessageBox.Show("Indicate atleast one schedule of intake ");
            }

        }

            
        private void txtsession_Click(object sender, EventArgs e)
        {
            if (txtsession.Text == "No. of Session/s")
            {
                txtsession.Text = "";
            }
        }


        private void txtsession_LostFocus(object sender, EventArgs e)
        {
            if (txtsession.Text == "")
            {
                txtsession.Text = "No. of Session/s";
            }
        }

      
        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtmorning_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNoon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtafternoon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dgvtreatment_SelectionChanged(object sender, EventArgs e)
        {


            foreach (DataGridViewRow row in dgvtreatment.SelectedRows)
            {
                procedure = row.Cells["colProcedure"].Value.ToString();
                illness = row.Cells["colIllness"].Value.ToString();
                treatDoctor = row.Cells["colDoctorTreat"].Value.ToString();
                session = row.Cells["colSessions"].Value.ToString();
                results = row.Cells["colResults"].Value.ToString();
                treatDate = row.Cells["colTreatDate"].Value.ToString();               
            } 
                
        }

        private void dgvprescription_SelectionChanged(object sender, EventArgs e)
        {
            
                foreach (DataGridViewRow row in dgvprescription.SelectedRows)
                {
                    medicine = row.Cells["colMed"].Value.ToString();
                    dosage = row.Cells["colmeddosage"].Value.ToString();
                    prescribedqty = Int32.Parse(row.Cells["colQuantity"].Value.ToString());
                    morning = Int32.Parse(row.Cells["colMorning"].Value.ToString());
                    noon = Int32.Parse(row.Cells["colNoon"].Value.ToString());
                    afternoon = Int32.Parse(row.Cells["colAfternoon"].Value.ToString());
                    other = row.Cells["colOthers"].Value.ToString();
                    presDoctor = row.Cells["colDoctorName"].Value.ToString();
                    presDate = row.Cells["coldatePres"].Value.ToString();
               
                }
            
           
        }

        private void btnEditTreat_Click(object sender, EventArgs e)
        {
            if (dgvtreatment.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string procedure = dgvtreatment.SelectedRows[0].Cells[0].Value + string.Empty;
                string illness = dgvtreatment.SelectedRows[0].Cells[1].Value + string.Empty;
                string session = dgvtreatment.SelectedRows[0].Cells[2].Value + string.Empty;
                string result = dgvtreatment.SelectedRows[0].Cells[3].Value + string.Empty;
                string doctor = dgvtreatment.SelectedRows[0].Cells[4].Value + string.Empty;
                txtproceed.Text = procedure;
                txtillness.Text = illness;
                txtsession.Text = session;
                txtOtherTreat.Text = result;
                cmbDoctor.Text = doctor;
                
                btnAddTreat.Text = "Save";
            }
            else
            {
                MessageBox.Show("You haven't selected any row.");
            }
        }


       

       

    }

}
