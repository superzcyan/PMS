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
    public partial class EmployeeSchedule : Form
    {
        MySqlConnection connect = new MySqlConnection("Server = localhost; Uid =root; Password=root; Database =pms; Port =3306");
        MySqlCommand command = new MySqlCommand();
        public EmployeeSchedule()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            connect.Open();            
            command.Parameters.Clear();
            command.CommandText = "Select * from schedules where (patientid = '" + txtEmpID.Text + "') OR ((firstname = '" + txtname.Text + "' AND lastname = '" + txtsurname.Text + "'))  ";
            try
            {
                MySqlDataReader msqlReader = command.ExecuteReader();
                if (msqlReader.Read())
                {
                    txtname.Text = msqlReader.GetValue(2).ToString();
                    txtmidname.Text = msqlReader.GetValue(3).ToString();
                    txtsurname.Text = msqlReader.GetValue(4).ToString();
                    txtposition.Text = msqlReader.GetValue(16).ToString();
                    

                }
                else
                {
                    MessageBox.Show("Employee don't exist");
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

        private void EmployeeSchedule_Load(object sender, EventArgs e)
        {

            connect.Open();
            command.Connection = connect;

            MySqlDataAdapter adapter = new MySqlDataAdapter("Select * FROM schedules", connect);


            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvappointments.AutoGenerateColumns = false;
            dgvappointments.DataSource = table;
            connect.Close();
        }
    }
}
