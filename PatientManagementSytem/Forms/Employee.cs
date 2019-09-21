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
    public partial class Employee : Form
    {
        MySqlConnection connect = new MySqlConnection("Server = localhost; Uid =root; Password=root; Database =pms; Port =3306");
        MySqlCommand command = new MySqlCommand();
        string gender = "";
        string birthday;
        public Employee()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            command.Parameters.Clear();
            foreach (RadioButton rad in grpGender.Controls)
            {
                if (rad.Checked)
                {
                     gender = rad.Text;
                }
            }

            if ((txtfirstname.Text == "Name") || (txtmidname.Text == "Middle Name") || (txtsurname.Text == "Surname") || (cmbposition.Text == "Position") ||
                (mtxthome.Text == " ") || (mtxtmobile.Text == " ") || (txtage.Text == "Age") || (txtaddress.Text == "Address") || gender == "")
            {
                MessageBox.Show("Please complete all details");
            }

            else
            {
                connect.Open();
                
                command.CommandText = @"INSERT INTO staffs(empid, firstname, middlename, surname, gender ,birthday, age, emailaddress, mobileno, homeno, address, position, password) 
                                            VALUES (@patientid, @firstname, @middlename, @surname, @gender, @birthday, @age, @emailaddress, @mobileno, @homeno, @address, @position, @password)";
                command.Parameters.AddWithValue("@patientid", txtempid.Text);
                command.Parameters.AddWithValue("@firstname", txtfirstname.Text);
                command.Parameters.AddWithValue("@middlename", txtmidname.Text);
                command.Parameters.AddWithValue("@surname", txtsurname.Text);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@birthday", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@age", txtsurname.Text);
                command.Parameters.AddWithValue("@emailaddress", txtemail.Text);
                command.Parameters.AddWithValue("@mobileno", mtxtmobile.Text);
                command.Parameters.AddWithValue("@homeno", mtxthome.Text);
                command.Parameters.AddWithValue("@address", txtaddress.Text);
                command.Parameters.AddWithValue("@position", cmbposition.Text);
                command.Parameters.AddWithValue("@password", txtpassword.Text);
                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Account Created");

                SetDefaultValues();
            }
        }
        private void txtfirstname_Click(object sender, EventArgs e)
        {
            if (txtfirstname.Text == "" || txtfirstname.Text == "Name")
            {
                txtfirstname.Text = "";
            }

        }
        private void txtfirstname_LostFocus(object sender, System.EventArgs e)
        {
            if (txtfirstname.Text == "")
            {
                txtfirstname.Text = "Name";
            }
        }


        private void txtmidname_Click(object sender, EventArgs e)
        {
            if (txtmidname.Text == "" || txtmidname.Text == "Middle Name")
            {
                txtmidname.Text = "";
            }

        }
        private void txtmidname_LostFocus(object sender, System.EventArgs e)
        {
            if (txtmidname.Text == "")
            {
                txtmidname.Text = "Middle Name";
            }
        }

        private void txtsurname_Click(object sender, EventArgs e)
        {
            if (txtsurname.Text == "" || txtsurname.Text == "Surname")
            {
                txtsurname.Text = "";
            }

        }
        private void txtsurname_LostFocus(object sender, System.EventArgs e)
        {
            if (txtsurname.Text == "")
            {
                txtsurname.Text = "Surname";
            }
        }


        private void txtaddress_Click(object sender, EventArgs e)
        {
            if (txtaddress.Text == "" || txtaddress.Text == "Address")
            {
                txtaddress.Text = "";
            }

        }
        private void txtaddress_LostFocus(object sender, System.EventArgs e)
        {
            if (txtaddress.Text == "")
            {
                txtaddress.Text = "Address";
            }
        }

        private void txtemail_Click(object sender, EventArgs e)
        {
            if (txtemail.Text == "" || txtemail.Text == "Email Address")
            {
                txtemail.Text = "";
            }

        }
        private void txtemail_LostFocus(object sender, System.EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "Email Address";
            }
        }

             
        private void Register_Load(object sender, EventArgs e)
        {
            cmbposition.SelectedIndex = 0;
            connect.Open();
            command.Connection = connect;
            command.CommandText = "Select COUNT(*) from staffs";
            int count = Convert.ToInt16(command.ExecuteScalar()) + 1;
            txtempid.Text = "E"+count.ToString();            
            connect.Close();
        }

        private void dateTimePicker1_TextChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Today)
            {
                DateTime from = dateTimePicker1.Value;
                DateTime to = DateTime.Now;
                TimeSpan span = to - from;
                double days = span.TotalDays;
                txtage.Text = Math.Truncate(days / 365).ToString("0");
                birthday = from.ToString("MMMM dd, yyyy");
            }
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {            
            string allowedLetterChars = "abcdefghijkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ";
            string allowedNumberChars = "23456789";
            char[] chars = new char[8];
            Random rd = new Random();

            bool useLetter = true;
            for (int i = 0; i < 8; i++)
            {
                if (useLetter)
                {
                    chars[i] = allowedLetterChars[rd.Next(0, allowedLetterChars.Length)];
                    useLetter = false;
                }
                else
                {
                    chars[i] = allowedNumberChars[rd.Next(0, allowedNumberChars.Length)];
                    useLetter = true;
                }

            }
            string password = new string(chars);
            txtpassword.Text = password;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetDefaultValues();

          
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

        private void cmbposition_LostFocus(object sender, EventArgs e)
            {
                if (txtsurname.Text == "")
                {
                    txtsurname.Text = "Middle Name";
                }

                connect.Open();
                command.Connection = connect;
                command.CommandText = "Select * from staffs where firstname = '" + txtfirstname.Text + "' and middlename = '" + txtmidname.Text + "' and surname = '" + txtsurname.Text + "'";
                try
                {
                    MySqlDataReader msqlReader = command.ExecuteReader();
                    if (msqlReader.Read())
                    {

                        MessageBox.Show("Employee already has account.");

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

        private void txtfirstname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtmobileno_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if ((e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && (e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            {
                e.Handled = true;
            }
           
        }

        private void txthomeno_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && (e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {
           
            if (txtage.Text != "Age")
            {
                int age = 0;
                age = Convert.ToInt32(txtage.Text);
                if (age > 15)
                {

                    txtaddress.Focus();
                }

                else
                {
                    MessageBox.Show("Invalid Birthday, must be more than 15yrs old");
                    txtage.Text = "Age";                   
                    dateTimePicker1.Focus();


                }
            }
        }


        private void SetDefaultValues()
        {
            txtfirstname.Text = "";
            txtmidname.Text = "";
            txtsurname.Text = "";
            mtxtmobile.Clear();
            mtxthome.Clear();
            txtemail.Text = "";
            txtaddress.Text = "";
            txtage.Text = "";
            txtpassword.Text = "";
            dateTimePicker1.ResetText();
            cmbposition.SelectedIndex = 0;

        }


        private void mtxtmobile_MouseUp(object sender, MouseEventArgs e)
        {
            if (mtxtmobile.SelectionStart > mtxtmobile.Text.Length)
            {
                mtxtmobile.Select(mtxtmobile.Text.Length, 0);
            }
        }

        private void mtxthome_MouseUp(object sender, MouseEventArgs e)
        {
            if (mtxthome.SelectionStart > mtxthome.Text.Length)
            {
                mtxthome.Select(mtxthome.Text.Length, -4);
            }
        }

      
    }
}
