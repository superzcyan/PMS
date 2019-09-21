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
    public partial class userRegisterStaff : UserControl
    {
        MySqlConnection connect = new MySqlConnection("Server = localhost; Uid =root; Password=root; Database =pms; Port =3306");
        MySqlCommand command = new MySqlCommand();
        string gender = "";
        string birthday;
        public userRegisterStaff()
        {
            InitializeComponent();
        }

        private void registerStatff()
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
                empIDcheck();
            }
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            checkStaff();
            registerStatff();
            
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            SetDefaultValues();
        }

        private void empIDcheck()
        {
            connect.Open();
            command.Connection = connect;
            command.CommandText = "Select COUNT(*) from staffs";
            int count = Convert.ToInt16(command.ExecuteScalar()) + 1;
            txtempid.Text = "E" + count.ToString();
            connect.Close();
        }

        private void UserRegisterStaff_Load(object sender, EventArgs e)
        {
            cmbposition.SelectedIndex = 0;            
            empIDcheck();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
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

        private void Btngenerate_Click(object sender, EventArgs e)
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

        private void checkStaff()
        {
            connect.Open();
            command.Connection = connect;
            command.CommandText = "Select * from staffs where position = '" + cmbposition.Text + "' and firstname = '" + txtfirstname.Text + "' and middlename = '" + txtmidname.Text + "' and surname = '" + txtsurname.Text + "'";
            try
            {
                MySqlDataReader msqlReader = command.ExecuteReader();
                if (msqlReader.Read())
                {

                    MessageBox.Show("Employee with same position already has account.");

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
        private void Txtsurname_Validated(object sender, EventArgs e)
        {
            checkStaff();
        }

        private void Txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                checkStaff();
                registerStatff();
            }
        }
    }
}
