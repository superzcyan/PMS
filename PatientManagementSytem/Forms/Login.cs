using MySql.Data.MySqlClient;
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
using System.Runtime.InteropServices;

namespace PMS{

    public partial class Login : Form
    {

        MySqlConnection connect = new MySqlConnection("Server = localhost; Uid =root; Password=root; Database =pms; Port =3306");
        MySqlCommand command = new MySqlCommand();
        bool focus = false;
        int count;
        String position, userloginName, doctorName;
        
        public Login()
        {
            InitializeComponent();
        }

       
        private void Login_Paint(object sender, PaintEventArgs e)
        {

           
            Pen pen = new Pen(Color.Silver);
            Graphics grap = e.Graphics;
            int variances = 1;
            grap.DrawRectangle(pen, new Rectangle(userPanel.Location.X - variances, userPanel.Location.Y - variances, userPanel.Width + variances, userPanel.Height + variances));
            grap.DrawRectangle(pen, new Rectangle(passPanel.Location.X - variances, passPanel.Location.Y - variances, passPanel.Width + variances, passPanel.Height + variances));

            if ((txtusername as Control).Focused)
            {
                Pen pens = new Pen(Color.SkyBlue);
                grap.DrawRectangle(pens, new Rectangle(userPanel.Location.X - variances, userPanel.Location.Y - variances, userPanel.Width + variances, userPanel.Height + variances));
                
            }
            else if ((txtpassword as Control).Focused)
            {
                Pen pens = new Pen(Color.SkyBlue);
                grap.DrawRectangle(pens, new Rectangle(passPanel.Location.X - variances, passPanel.Location.Y - variances, passPanel.Width + variances, userPanel.Height + variances));

            }

        }

        public void login()
        {
            command.Parameters.Clear();
            Forms.Dashboard dashboard = new Forms.Dashboard();
            String username = txtusername.Text;
            String password = txtpassword.Text;
            connect.Open();
            command.Connection = connect;
            command.CommandText = "Select * from staffs where empid = @username and password = @password";            
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            try
            {
                MySqlDataReader msqlReader = command.ExecuteReader();
                if (msqlReader.Read())
                {
                    position = msqlReader["position"].ToString();
                    userloginName = position + " " + msqlReader.GetValue(2).ToString().Substring(0, 1) + " " + msqlReader.GetValue(3).ToString().Substring(0, 1) + " " + msqlReader.GetValue(4).ToString();
                    doctorName = msqlReader.GetValue(2).ToString() + " " + msqlReader.GetValue(3).ToString() + " " + msqlReader.GetValue(4).ToString();
                    dashboard.loginName = userloginName;
                    dashboard.doctorName = doctorName;
                    this.Hide();
                    dashboard.Show();               
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();           
        }

        private void txtusername_Click(object sender, EventArgs e)
        {
            
            focus = true;
            if (txtusername.Text == "" || txtusername.Text == "Username")
            {                
                txtusername.Text = "";
                txtusername.ForeColor = Color.Black;

            }
            this.Refresh();

        }
        private void txtusername_LostFocus(object sender, System.EventArgs e)
        {
            
            focus = false;
            if (txtusername.Text == "" || txtusername.Text == "Username")
            {
                txtusername.ForeColor = Color.Silver;
                txtusername.Text = "Username";
                
              
            }
            this.Refresh();
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtpassword.Focus();
            }
            if (e.KeyChar == (char)'\'')
            {
                e.Handled = true;
            }
        }

        private void txtpassword_LostFocus(object sender, System.EventArgs e)
        {
         
            if (txtpassword.Text == "" || txtpassword.Text == "Password")
            {
                txtpassword.PasswordChar = '\0';
                txtpassword.Text = "Password";
                txtpassword.ForeColor = Color.Silver;

            }
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            txtpassword.ForeColor = Color.Black;
            if (txtpassword.Text == "" || txtpassword.Text == "Password")
            {
                txtpassword.Text = "";                
               
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (!(txtpassword.Text == "Password"))
            {
                txtpassword.PasswordChar = '\u25CF';
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {                
                login();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Txtpassword_Enter(object sender, EventArgs e)
        {
            txtpassword.ForeColor = Color.Black;
            if (txtpassword.Text == "" || txtpassword.Text == "Password")
            {
                txtpassword.Text = "";

            }
        }

        private void Txtusername_Enter(object sender, EventArgs e)
        {
            focus = true;
            if (txtusername.Text == "" || txtusername.Text == "Username")
            {
                txtusername.Text = "";
                txtusername.ForeColor = Color.Black;

            }
            this.Refresh();

        }
    }
}
