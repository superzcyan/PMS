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
    public partial class userAppointments : UserControl
    {
        MySqlConnection connect = new MySqlConnection("Server = localhost; Uid =root; Password=root; Database =pms; Port =3306");
        MySqlCommand command = new MySqlCommand();
        String datetimenow;
        public userAppointments()
        {
            InitializeComponent();
        }

        private void UserAppointments_Load(object sender, EventArgs e)
        {
            connect.Open();
            command.Connection = connect;

            MySqlDataAdapter adapter6 = new MySqlDataAdapter("Select * FROM appointments", connect);


            DataTable table6 = new DataTable();
            adapter6.Fill(table6);
            dgvappointments.AutoGenerateColumns = false;
            dgvappointments.DataSource = table6;


            cmbpatientid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbpatientid.AutoCompleteSource = AutoCompleteSource.ListItems;
            command.CommandText = "Select patientid FROM appointments";
            MySqlDataAdapter adapter = new MySqlDataAdapter("Select DISTINCT patientid FROM appointments", connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow row = dt.NewRow();
            row["patientid"] = "All";
            dt.Rows.InsertAt(row, 0);
            cmbpatientid.DataSource = dt;
            cmbpatientid.DisplayMember = "patientid";
            cmbpatientid.ValueMember = "patientid";
            connect.Close();
        }

        private void Search()
        {
            connect.Open();
            command.Connection = connect;
            command.Parameters.Clear();
            command.CommandText = "Select * from patients where (patientid = '" + txtpatientID.Text + "') OR ((firstname = '" + txtname.Text + "' AND lastname = '" + txtsurname.Text + "'))  ";
            try
            {
                MySqlDataReader msqlReader = command.ExecuteReader();
                if (msqlReader.Read())
                {
                    txtname.Text = msqlReader.GetValue(1).ToString();
                    txtmidname.Text = msqlReader.GetValue(2).ToString();
                    txtsurname.Text = msqlReader.GetValue(3).ToString();
                    txtcontact.Text = msqlReader.GetValue(9).ToString();
                    txtemail.Text = msqlReader.GetValue(8).ToString();

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
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvappointments.SelectedRows.Count > 0)
            {
                string patientid = dgvappointments.SelectedRows[0].Cells[0].Value + string.Empty;
                string name = dgvappointments.SelectedRows[0].Cells[1].Value + string.Empty;
                string midname = dgvappointments.SelectedRows[0].Cells[2].Value + string.Empty;
                string surname = dgvappointments.SelectedRows[0].Cells[3].Value + string.Empty;
                string contactno = dgvappointments.SelectedRows[0].Cells[4].Value + string.Empty;
                string email = dgvappointments.SelectedRows[0].Cells[5].Value + string.Empty;
                string doctor = dgvappointments.SelectedRows[0].Cells[6].Value + string.Empty;
                string description = dgvappointments.SelectedRows[0].Cells[7].Value + string.Empty;
                string date = dgvappointments.SelectedRows[0].Cells[8].Value + string.Empty;
                string start = dgvappointments.SelectedRows[0].Cells[9].Value + string.Empty;
                string end = dgvappointments.SelectedRows[0].Cells[10].Value + string.Empty;

                txtpatientID.Text = patientid;
                txtname.Text = name;
                txtmidname.Text = midname;
                txtsurname.Text = surname;
                txtcontact.Text = contactno;
                txtemail.Text = email;
                cmbdoctor.Text = doctor;
                rtxtdesc.Text = description;
                dateTimePickerDate.Value = Convert.ToDateTime(date);
                dateTimePickerStart.Value = Convert.ToDateTime(start);
                dateTimePickerEnd.Value = Convert.ToDateTime(end);
                btnConfirm.Text = "Save";


            }
            else
            {
                MessageBox.Show("You haven't selected any row.");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvappointments.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string patientid = dgvappointments.SelectedRows[0].Cells[0].Value + string.Empty;
                string name = dgvappointments.SelectedRows[0].Cells[1].Value + string.Empty;
                string midname = dgvappointments.SelectedRows[0].Cells[2].Value + string.Empty;
                string surname = dgvappointments.SelectedRows[0].Cells[3].Value + string.Empty;
                string contactno = dgvappointments.SelectedRows[0].Cells[4].Value + string.Empty;
                string email = dgvappointments.SelectedRows[0].Cells[5].Value + string.Empty;
                string doctor = dgvappointments.SelectedRows[0].Cells[6].Value + string.Empty;
                string description = dgvappointments.SelectedRows[0].Cells[7].Value + string.Empty;
                string date = dgvappointments.SelectedRows[0].Cells[8].Value + string.Empty;
                string start = dgvappointments.SelectedRows[0].Cells[9].Value + string.Empty;
                string end = dgvappointments.SelectedRows[0].Cells[10].Value + string.Empty;

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete selected appointment?", "Delete Schedule", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    connect.Open();
                    command.Parameters.Clear();
                    command.CommandText = "DELETE FROM appointments WHERE patientid = @patientid AND firstname =@firstname AND middlename = @middlename AND surname=@surname AND doctor=@doctor AND date=@date AND start=@start AND end=@end";
                    //AND email = @email AND description = @description
                    //;


                    command.Parameters.AddWithValue("@patientid", patientid);
                    command.Parameters.AddWithValue("@firstname", name);
                    command.Parameters.AddWithValue("@middlename", midname);
                    command.Parameters.AddWithValue("@surname", surname);
                    //command.Parameters.AddWithValue("@email", email);
                    //command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@doctor", doctor);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@start", start);
                    command.Parameters.AddWithValue("@end", end);
                    command.ExecuteNonQuery();

                    MySqlDataAdapter adapter7 = new MySqlDataAdapter("Select * FROM appointments", connect);

                    DataTable table7 = new DataTable();
                    adapter7.Fill(table7);
                    dgvappointments.AutoGenerateColumns = false;
                    dgvappointments.DataSource = table7;
                    connect.Close();
                    MessageBox.Show("Deleted!");


                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Please select a row in schedule table to delete.");
            }
        }

        private void SetDefaultValues()
        {
            txtpatientID.Text = "";
            txtname.Text = "";
            txtmidname.Text = "";
            txtsurname.Text = "";
            txtcontact.Text = "";
            txtemail.Text = "";
            rtxtdesc.Text = "";
            dateTimePickerDate.ResetText();
            dateTimePickerStart.ResetText();
            dateTimePickerEnd.ResetText();


        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            connect.Open();

            if (btnConfirm.Text == "Add")
            {

                if (txtpatientID.Text == "")
                {
                    MessageBox.Show("Patient ID is blank");
                }
                else if (rtxtdesc.Text == " ")
                {
                    MessageBox.Show("Reason for appointments is required.");
                }
                else if (cmbdoctor.Text == "Choose a doctor")
                {
                    MessageBox.Show("Please select a Doctor");
                }
                else
                {

                    command.Parameters.Clear();
                    command.CommandText = "Select * from appointments where doctor = @doctor and date = @date and start= @start and end= @end";
                    command.Parameters.AddWithValue("@doctor", cmbdoctor.Text);
                    command.Parameters.AddWithValue("@date", dateTimePickerDate.Text);
                    command.Parameters.AddWithValue("@start", dateTimePickerStart.Text);
                    command.Parameters.AddWithValue("@end", dateTimePickerEnd.Text);
                    MySqlDataReader msqlReader = command.ExecuteReader();
                    if (msqlReader.Read())
                    {

                        MessageBox.Show("Schedule already taken");
                        connect.Close();
                    }
                    else
                    {
                        connect.Close();
                        connect.Open();
                        command.Parameters.Clear();
                        command.CommandText = @"INSERT INTO appointments(patientid, firstname, middlename, surname, email, contactno, description, doctor, date, start, end) 
                    VALUES (@patientid, @firstname, @middlename, @surname, @email, @contactno, @description, @doctor, @date, @start, @end)";
                        command.Parameters.AddWithValue("@patientid", txtpatientID.Text);
                        command.Parameters.AddWithValue("@firstname", txtname.Text);
                        command.Parameters.AddWithValue("@middlename", txtmidname.Text);
                        command.Parameters.AddWithValue("@surname", txtsurname.Text);
                        command.Parameters.AddWithValue("@email", txtemail.Text);
                        command.Parameters.AddWithValue("@contactno", txtcontact.Text);
                        command.Parameters.AddWithValue("@description", rtxtdesc.Text);
                        command.Parameters.AddWithValue("@doctor", cmbdoctor.Text);
                        command.Parameters.AddWithValue("@date", dateTimePickerDate.Text);
                        command.Parameters.AddWithValue("@start", dateTimePickerStart.Text);
                        command.Parameters.AddWithValue("@end", dateTimePickerEnd.Text);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Appoinment Plotted");

                        MySqlDataAdapter adapter6 = new MySqlDataAdapter("Select * FROM appointments", connect);


                        DataTable table6 = new DataTable();
                        adapter6.Fill(table6);
                        dgvappointments.AutoGenerateColumns = false;
                        dgvappointments.DataSource = table6;


                        cmbpatientid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        cmbpatientid.AutoCompleteSource = AutoCompleteSource.ListItems;
                        command.CommandText = "Select patientid FROM appointments";
                        MySqlDataAdapter adapter = new MySqlDataAdapter("Select DISTINCT patientid FROM appointments", connect);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DataRow row = dt.NewRow();
                        row["patientid"] = "All";
                        dt.Rows.InsertAt(row, 0);
                        cmbpatientid.DataSource = dt;
                        cmbpatientid.DisplayMember = "patientid";
                        cmbpatientid.ValueMember = "patientid";

                        connect.Close();
                        SetDefaultValues();

                    }
                }
            }
            else if (btnConfirm.Text == "Save")
            {
                connect.Open();
                command.Parameters.Clear();
                command.CommandText = @"UPDATE appointments SET patientid = @patientid, firstname = @firstname, middlename = @middlename, surname = @surname, email =  @email , contactno = @contactno, description  = @description, doctor = @doctor, date =  @date, start =  @start, end = @end";
                command.Parameters.AddWithValue("@patientid", txtpatientID.Text);
                command.Parameters.AddWithValue("@firstname", txtname.Text);
                command.Parameters.AddWithValue("@middlename", txtmidname.Text);
                command.Parameters.AddWithValue("@surname", txtsurname.Text);
                command.Parameters.AddWithValue("@email", txtemail.Text);
                command.Parameters.AddWithValue("@contactno", txtcontact.Text);
                command.Parameters.AddWithValue("@description", rtxtdesc.Text);
                command.Parameters.AddWithValue("@doctor", cmbdoctor.Text);
                command.Parameters.AddWithValue("@date", dateTimePickerDate.Text);
                command.Parameters.AddWithValue("@start", dateTimePickerStart.Text);
                command.Parameters.AddWithValue("@end", dateTimePickerEnd.Text);
                command.ExecuteNonQuery();
                connect.Close();
                btnConfirm.Text = "Add";
                MessageBox.Show("Appoinment Updated!");
            }


            connect.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }

        private void TxtpatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Search();
            }
            if (e.KeyChar == (char)'\'')
            {
                e.Handled = true;
            }
        }

        private void BtnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.White;
        }

        private void BtnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.Black;
        }
    }
}
