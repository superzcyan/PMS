using MySql.Data.MySqlClient;

namespace PMS
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtmidname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.cmbposition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.btngenerate = new System.Windows.Forms.Button();
            this.lblposition = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.mtxthome = new System.Windows.Forms.MaskedTextBox();
            this.mtxtmobile = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.lblname = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(161, 623);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(265, 27);
            this.txtemail.TabIndex = 6;
            this.txtemail.Click += new System.EventHandler(this.txtemail_Click);
            this.txtemail.LostFocus += new System.EventHandler(this.txtemail_LostFocus);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(161, 506);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(563, 27);
            this.txtaddress.TabIndex = 8;
            this.txtaddress.Click += new System.EventHandler(this.txtaddress_Click);
            this.txtaddress.LostFocus += new System.EventHandler(this.txtaddress_LostFocus);
            // 
            // txtage
            // 
            this.txtage.BackColor = System.Drawing.Color.White;
            this.txtage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(557, 561);
            this.txtage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtage.Name = "txtage";
            this.txtage.ReadOnly = true;
            this.txtage.Size = new System.Drawing.Size(65, 27);
            this.txtage.TabIndex = 17;
            this.txtage.TextChanged += new System.EventHandler(this.txtage_TextChanged);
            // 
            // txtsurname
            // 
            this.txtsurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsurname.Location = new System.Drawing.Point(723, 450);
            this.txtsurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(271, 27);
            this.txtsurname.TabIndex = 2;
            this.txtsurname.Click += new System.EventHandler(this.txtsurname_Click);
            this.txtsurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsurname_KeyPress);
            this.txtsurname.LostFocus += new System.EventHandler(this.txtsurname_LostFocus);
            // 
            // txtmidname
            // 
            this.txtmidname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmidname.Location = new System.Drawing.Point(443, 450);
            this.txtmidname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmidname.Name = "txtmidname";
            this.txtmidname.Size = new System.Drawing.Size(271, 27);
            this.txtmidname.TabIndex = 1;
            this.txtmidname.Click += new System.EventHandler(this.txtmidname_Click);
            this.txtmidname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmidname_KeyPress);
            this.txtmidname.LostFocus += new System.EventHandler(this.txtmidname_LostFocus);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstname.Location = new System.Drawing.Point(161, 450);
            this.txtfirstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(271, 27);
            this.txtfirstname.TabIndex = 0;
            this.txtfirstname.Click += new System.EventHandler(this.txtfirstname_Click);
            this.txtfirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfirstname_KeyPress);
            this.txtfirstname.LostFocus += new System.EventHandler(this.txtfirstname_LostFocus);
            // 
            // cmbposition
            // 
            this.cmbposition.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbposition.FormattingEnabled = true;
            this.cmbposition.Items.AddRange(new object[] {
            "Choose Position..",
            "Doctor",
            "Receptionist",
            "Nurse",
            "Pharmacist",
            "Cashier"});
            this.cmbposition.Location = new System.Drawing.Point(313, 394);
            this.cmbposition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbposition.Name = "cmbposition";
            this.cmbposition.Size = new System.Drawing.Size(192, 29);
            this.cmbposition.TabIndex = 9;
            this.cmbposition.SelectedIndexChanged += new System.EventHandler(this.cmbposition_LostFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(344, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 49);
            this.label1.TabIndex = 25;
            this.label1.Text = "Employee Registration";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMMM dd, yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(350, 561);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 27);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_TextChanged);
            // 
            // txtempid
            // 
            this.txtempid.BackColor = System.Drawing.Color.White;
            this.txtempid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtempid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempid.Location = new System.Drawing.Point(161, 394);
            this.txtempid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtempid.Name = "txtempid";
            this.txtempid.ReadOnly = true;
            this.txtempid.Size = new System.Drawing.Size(128, 27);
            this.txtempid.TabIndex = 30;
            // 
            // btngenerate
            // 
            this.btngenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(222)))));
            this.btngenerate.FlatAppearance.BorderSize = 0;
            this.btngenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(175)))), ((int)(((byte)(87)))));
            this.btngenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.btngenerate.Location = new System.Drawing.Point(314, 677);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(130, 30);
            this.btngenerate.TabIndex = 9;
            this.btngenerate.Text = "Generate";
            this.btngenerate.UseVisualStyleBackColor = false;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblposition.ForeColor = System.Drawing.Color.Black;
            this.lblposition.Location = new System.Drawing.Point(36, 68);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(68, 21);
            this.lblposition.TabIndex = 35;
            this.lblposition.Text = "Position";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.Color.Black;
            this.lbllogin.Location = new System.Drawing.Point(36, 38);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(84, 21);
            this.lbllogin.TabIndex = 34;
            this.lbllogin.Text = "Login as : ";
            // 
            // mtxthome
            // 
            this.mtxthome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxthome.Location = new System.Drawing.Point(651, 622);
            this.mtxthome.Mask = "000-0000";
            this.mtxthome.Name = "mtxthome";
            this.mtxthome.PromptChar = ' ';
            this.mtxthome.Size = new System.Drawing.Size(129, 27);
            this.mtxthome.TabIndex = 5;
            this.mtxthome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mtxthome_MouseUp);
            // 
            // mtxtmobile
            // 
            this.mtxtmobile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtmobile.Location = new System.Drawing.Point(449, 622);
            this.mtxtmobile.Mask = "99999999999";
            this.mtxtmobile.Name = "mtxtmobile";
            this.mtxtmobile.PromptChar = ' ';
            this.mtxtmobile.Size = new System.Drawing.Size(181, 27);
            this.mtxtmobile.TabIndex = 4;
            this.mtxtmobile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mtxtmobile_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(445, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mobile No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(647, 598);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "Home No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(346, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "Birthday:";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.radMale.ForeColor = System.Drawing.Color.Black;
            this.radMale.Location = new System.Drawing.Point(11, 15);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(67, 25);
            this.radMale.TabIndex = 0;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            this.grpGender.BackColor = System.Drawing.Color.Transparent;
            this.grpGender.Controls.Add(this.radFemale);
            this.grpGender.Controls.Add(this.radMale);
            this.grpGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGender.Location = new System.Drawing.Point(165, 548);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(175, 47);
            this.grpGender.TabIndex = 3;
            this.grpGender.TabStop = false;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.radFemale.ForeColor = System.Drawing.Color.Black;
            this.radFemale.Location = new System.Drawing.Point(84, 15);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(85, 25);
            this.radFemale.TabIndex = 1;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Black;
            this.lblname.Location = new System.Drawing.Point(126, 38);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(58, 21);
            this.lblname.TabIndex = 42;
            this.lblname.Text = "Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(428, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 275);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.White;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(161, 679);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.ReadOnly = true;
            this.txtpassword.Size = new System.Drawing.Size(147, 27);
            this.txtpassword.TabIndex = 32;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(222)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(175)))), ((int)(((byte)(87)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.btnRegister.Location = new System.Drawing.Point(395, 818);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(275, 50);
            this.btnRegister.TabIndex = 65;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(222)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(175)))), ((int)(((byte)(87)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.btnClear.Location = new System.Drawing.Point(395, 762);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(275, 50);
            this.btnClear.TabIndex = 66;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(222)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.btnExit.Location = new System.Drawing.Point(394, 874);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(275, 50);
            this.btnExit.TabIndex = 67;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(309, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 68;
            this.label2.Text = "Position:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(157, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 69;
            this.label6.Text = "Employee ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(157, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 70;
            this.label7.Text = "First Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(438, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 21);
            this.label8.TabIndex = 71;
            this.label8.Text = "Middle Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(719, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 72;
            this.label9.Text = "Surname:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(157, 537);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 73;
            this.label10.Text = "Gender:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(157, 598);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 21);
            this.label11.TabIndex = 74;
            this.label11.Text = "Email addres:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(553, 537);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 21);
            this.label12.TabIndex = 75;
            this.label12.Text = "Age:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(157, 481);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 21);
            this.label13.TabIndex = 76;
            this.label13.Text = "Address:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(157, 654);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 21);
            this.label14.TabIndex = 77;
            this.label14.Text = "Password:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1079, 961);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxtmobile);
            this.Controls.Add(this.mtxthome);
            this.Controls.Add(this.lblposition);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.btngenerate);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbposition);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.txtmidname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.grpGender);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.TextBox txtmidname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.ComboBox cmbposition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.Button btngenerate;
        public System.Windows.Forms.Label lblposition;
        public System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.MaskedTextBox mtxthome;
        private System.Windows.Forms.MaskedTextBox mtxtmobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton radFemale;
        public System.Windows.Forms.Label lblname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
    }
}