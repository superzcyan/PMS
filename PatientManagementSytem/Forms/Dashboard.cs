﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.Forms
{
    public partial class Dashboard : Form    {
        public string loginName, doctorName;
        public Dashboard()
        {
            InitializeComponent();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblname.Text = loginName;            
            UserControls.userHome home = new UserControls.userHome();
            panelDashboard.Controls.Add(home);
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;


            if (lblname.Text.Contains("admin"))
            {

                foreach (Control ctrl in panel1.Controls)
                {

                    if (ctrl is Button)
                    {
                        ctrl.Visible = true;
                    }
                }
            }
            if (lblname.Text.Contains("Doctor") || lblname.Text.Contains("Nurse"))
            {
                btnViewRecords.Location = btnRegisterPatient.Location;
                btnViewRecords.Visible = true;                
                
            }

            if (lblname.Text.Contains("Receptionist"))
            {
                btnViewRecords.Visible = true;
                btnRegisterPatient.Visible = true;
                btnNewAppointment.Visible = true;                

            }

            if (lblname.Text.Contains("Cashier") || lblname.Text.Contains("Pharmacist"))
            {
                btnViewRecords.Visible = true;                

            }
        }        
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            {
                this.Close();
                login.Show();
            }
        }
       
        private void BtnHome_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            UserControls.userHome home = new UserControls.userHome();
            panelDashboard.Controls.Add(home);
            home.Dock = DockStyle.Fill;
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
        }


        private void loadUserPatient()
        {
            panelDashboard.Controls.Clear();
            UserControls.userPatientInfo patienInfo = new UserControls.userPatientInfo();
            panelDashboard.Controls.Add(patienInfo);
            patienInfo.Dock = DockStyle.Fill;
            sidePanel.Height = btnRegisterPatient.Height;
            sidePanel.Top = btnRegisterPatient.Top;
        }
        private void BtnRegisterPatient_Click(object sender, EventArgs e)
        {
            loadUserPatient();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            UserControls.userRegisterStaff registerStaff = new UserControls.userRegisterStaff();
            panelDashboard.Controls.Add(registerStaff);
            registerStaff.Dock = DockStyle.Fill;
            sidePanel.Height = btnRegisterStaff.Height;            
            sidePanel.Top = btnRegisterStaff.Top;
        }

        private void BtnNewAppointment_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            UserControls.userAppointments appointments = new UserControls.userAppointments();
            panelDashboard.Controls.Add(appointments);
            appointments.Dock = DockStyle.Fill;
            sidePanel.Height = btnNewAppointment.Height;
            sidePanel.Top = btnNewAppointment.Top;
        }

        private void BtnViewRecords_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            UserControls.userPatientRecords patientRecords = new UserControls.userPatientRecords();
            panelDashboard.Controls.Add(patientRecords);
            patientRecords.Dock = DockStyle.Fill;
            sidePanel.Height = btnViewRecords.Height;
            sidePanel.Top = btnViewRecords.Top;

            patientRecords.presDoctor = doctorName;
        }

        private void BtnLogOut_MouseEnter(object sender, EventArgs e)
        {
            btnLogOut.ForeColor = Color.White;
        }

        private void BtnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.ForeColor = Color.Black;            
        }
    }
}
