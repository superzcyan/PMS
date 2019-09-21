using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class Appointments : Form
    {
        MySqlConnection connect = new MySqlConnection("Server = localhost; Uid =root; Password=root; Database =pms; Port =3306");
        MySqlCommand command = new MySqlCommand();        

        public Appointments()
        {
            InitializeComponent();
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

        private void Appointments_Load(object sender, EventArgs e)
        {
            this.dgvappointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvappointments.MultiSelect = false;
              

            connect.Open();
            command.Connection = connect;

            MySqlDataAdapter adapter6 = new MySqlDataAdapter("Select *, CONCAT(firstname,' ',middlename,' ',surname) AS patientname FROM appointments", connect);

           
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

       
        private void button4_Click(object sender, EventArgs e)
        {
            AddAppointment addappointment = new AddAppointment();
            {


                addappointment.lblname.Text = lblname.Text;
                addappointment.lblposition.Text = lblposition.Text;
                this.Close();
                addappointment.Show();
            }
        }

         
        
        private void cmbpatientid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbpatientid.SelectedIndex == 0)
            {
                connect.Close();
                connect.Open();
                command.Connection = connect;

                MySqlDataAdapter adapter6 = new MySqlDataAdapter("Select *, CONCAT(firstname,' ',middlename,' ',surname) AS patientname FROM appointments", connect);

                DataTable table6 = new DataTable();
                adapter6.Fill(table6);
                dgvappointments.AutoGenerateColumns = false;
                dgvappointments.DataSource = table6;
                connect.Close();
            }
            else
            {
                connect.Close();
                connect.Open();
                command.Connection = connect;

                MySqlDataAdapter adapter6 = new MySqlDataAdapter("Select *, CONCAT(firstname,' ',middlename,' ',surname) AS patientname FROM appointments WHERE patientid  = '" + cmbpatientid.Text + "' ", connect);

                DataTable table6 = new DataTable();
                adapter6.Fill(table6);
                dgvappointments.AutoGenerateColumns = false;
                dgvappointments.DataSource = table6;
                connect.Close();
            }

        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.White;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.ForeColor = System.Drawing.Color.FromArgb(112, 81, 79);
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.ForeColor = Color.White;
        }
        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.ForeColor = System.Drawing.Color.FromArgb(112, 81, 79);
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.White;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {

            btnDelete.ForeColor = System.Drawing.Color.FromArgb(112, 81, 79);
        }

        private void btnExt_MouseEnter(object sender, EventArgs e)
        {
            btnExt.ForeColor = Color.White;
        }

        private void btnExt_MouseLeave(object sender, EventArgs e)
        {
            btnExt.ForeColor = System.Drawing.Color.FromArgb(112, 81, 79);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            connect.Open();
            command.CommandText = "Select * FROM medicationhistory WHERE patientid = '" + txtPatientID.Text + "'";
            try
            {
                MySqlDataReader msqlReader = command.ExecuteReader();
                if (msqlReader.Read())
                {

                    String medical = msqlReader.GetValue(2).ToString();
                    
                    String[] meds = medical.Split(',');
                    for(int i = 0; i < meds.Length; i++)
                    {
                        txtboxmedical.Text += meds[i];
                    }

                    for (int i = 0; i < chklistMedical.Items.Count; i++)
                    {
                     
                            if (txtboxmedical.Text.Contains((string)chklistMedical.Items[i]))
                            {
                                chklistMedical.SetItemChecked(i, true);
                            }
                        
                    }


                }
                else if (txtPatientID.Text == "Patient ID")
                {
                    MessageBox.Show("Please input patient ID number");

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

        private void button1_Click(object sender, EventArgs e)
        {
            String test = "Diabetes";
            for (int i = 0; i < chklistMedical.Items.Count; i++)
            {
                if ((string)chklistMedical.Items[i] == test)
                {
                chklistMedical.SetItemChecked(i, true);
                }
            }

            //for (int i = 0; i < checkedListBox1.Items.Count; i++)
            //{
            //    checkedListBox1.SetItemChecked(i, false);//First uncheck the old value!
            //                                             //
            //    for (int x = 0; x < values.Length; x++)
            //    {
            //        if (checkedListBox1.Items[i].ToString() == values[x])
            //        {
            //            //Check only if they match! 
            //            checkedListBox1.SetItemChecked(i, true);
            //        }
            //    }
            //}

        }

        private void dgvappointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
