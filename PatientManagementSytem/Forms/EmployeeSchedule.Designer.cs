namespace PMS
{
    partial class EmployeeSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSchedule));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvappointments = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbpatientid = new System.Windows.Forms.ComboBox();
            this.lblpatientid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtmidname = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblposition = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colempid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldmidname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPositioni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvappointments)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(925, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // dgvappointments
            // 
            this.dgvappointments.AllowUserToResizeColumns = false;
            this.dgvappointments.AllowUserToResizeRows = false;
            this.dgvappointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvappointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvappointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvappointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvappointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvappointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colempid,
            this.colPatient,
            this.coldmidname,
            this.colsurname,
            this.colPositioni,
            this.colDate,
            this.colstart,
            this.colend,
            this.colStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvappointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvappointments.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvappointments.Location = new System.Drawing.Point(493, 333);
            this.dgvappointments.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvappointments.Name = "dgvappointments";
            this.dgvappointments.ReadOnly = true;
            this.dgvappointments.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvappointments.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvappointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvappointments.Size = new System.Drawing.Size(1173, 424);
            this.dgvappointments.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(489, 300);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 21);
            this.label13.TabIndex = 47;
            this.label13.Text = "Sort :";
            // 
            // cmbpatientid
            // 
            this.cmbpatientid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbpatientid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpatientid.FormattingEnabled = true;
            this.cmbpatientid.Items.AddRange(new object[] {
            "All"});
            this.cmbpatientid.Location = new System.Drawing.Point(539, 296);
            this.cmbpatientid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbpatientid.Name = "cmbpatientid";
            this.cmbpatientid.Size = new System.Drawing.Size(213, 29);
            this.cmbpatientid.TabIndex = 46;
            this.cmbpatientid.Text = "All";
            // 
            // lblpatientid
            // 
            this.lblpatientid.AutoSize = true;
            this.lblpatientid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatientid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.lblpatientid.Location = new System.Drawing.Point(60, 338);
            this.lblpatientid.Name = "lblpatientid";
            this.lblpatientid.Size = new System.Drawing.Size(63, 20);
            this.lblpatientid.TabIndex = 65;
            this.lblpatientid.Text = "Emp Id:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtEmpID);
            this.panel1.Location = new System.Drawing.Point(154, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 30);
            this.panel1.TabIndex = 53;
            // 
            // txtEmpID
            // 
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(5, 5);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(116, 20);
            this.txtEmpID.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.label8.Location = new System.Drawing.Point(51, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "Surname:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.label7.Location = new System.Drawing.Point(15, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Middle Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.label6.Location = new System.Drawing.Point(72, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Name:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(222)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.btnSearch.Location = new System.Drawing.Point(316, 333);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 30);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtsurname
            // 
            this.txtsurname.BackColor = System.Drawing.Color.White;
            this.txtsurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsurname.Location = new System.Drawing.Point(157, 441);
            this.txtsurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.ReadOnly = true;
            this.txtsurname.Size = new System.Drawing.Size(280, 20);
            this.txtsurname.TabIndex = 57;
            // 
            // txtmidname
            // 
            this.txtmidname.BackColor = System.Drawing.Color.White;
            this.txtmidname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmidname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmidname.Location = new System.Drawing.Point(157, 409);
            this.txtmidname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmidname.Name = "txtmidname";
            this.txtmidname.ReadOnly = true;
            this.txtmidname.Size = new System.Drawing.Size(280, 20);
            this.txtmidname.TabIndex = 56;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(157, 377);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(280, 20);
            this.txtname.TabIndex = 55;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(154, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 30);
            this.panel2.TabIndex = 66;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(154, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 30);
            this.panel3.TabIndex = 67;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(154, 436);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 30);
            this.panel4.TabIndex = 68;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(222)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(175)))), ((int)(((byte)(87)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.btnClear.Location = new System.Drawing.Point(154, 731);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(275, 50);
            this.btnClear.TabIndex = 72;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(222)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(175)))), ((int)(((byte)(87)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.btnUpdate.Location = new System.Drawing.Point(154, 661);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(275, 50);
            this.btnUpdate.TabIndex = 71;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(222)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(175)))), ((int)(((byte)(87)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.btnExit.Location = new System.Drawing.Point(1559, 949);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(275, 50);
            this.btnExit.TabIndex = 73;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(154, 514);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(208, 29);
            this.cmbStatus.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(59, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Position:";
            // 
            // txtposition
            // 
            this.txtposition.BackColor = System.Drawing.Color.White;
            this.txtposition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtposition.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtposition.Location = new System.Drawing.Point(157, 473);
            this.txtposition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtposition.Name = "txtposition";
            this.txtposition.ReadOnly = true;
            this.txtposition.Size = new System.Drawing.Size(240, 20);
            this.txtposition.TabIndex = 75;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(154, 468);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(245, 30);
            this.panel7.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(68, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(15, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 82;
            this.label3.Text = "Position:";
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblposition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblposition.Location = new System.Drawing.Point(85, 40);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(68, 21);
            this.lblposition.TabIndex = 80;
            this.lblposition.Text = "Position";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.lblname.Location = new System.Drawing.Point(90, 20);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(58, 21);
            this.lblname.TabIndex = 79;
            this.lblname.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 81;
            this.label4.Text = "Login as : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.label5.Location = new System.Drawing.Point(810, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(463, 49);
            this.label5.TabIndex = 83;
            this.label5.Text = "Employee Attendance";
            // 
            // colempid
            // 
            this.colempid.DataPropertyName = "empid";
            this.colempid.HeaderText = "Emp Id";
            this.colempid.Name = "colempid";
            this.colempid.ReadOnly = true;
            this.colempid.Width = 120;
            // 
            // colPatient
            // 
            this.colPatient.DataPropertyName = "firstname";
            this.colPatient.HeaderText = "First Name";
            this.colPatient.Name = "colPatient";
            this.colPatient.ReadOnly = true;
            this.colPatient.Width = 200;
            // 
            // coldmidname
            // 
            this.coldmidname.DataPropertyName = "middlename";
            this.coldmidname.HeaderText = "Middle Name";
            this.coldmidname.Name = "coldmidname";
            this.coldmidname.ReadOnly = true;
            this.coldmidname.Width = 150;
            // 
            // colsurname
            // 
            this.colsurname.DataPropertyName = "surname";
            this.colsurname.HeaderText = "Surname";
            this.colsurname.Name = "colsurname";
            this.colsurname.ReadOnly = true;
            this.colsurname.Width = 200;
            // 
            // colPositioni
            // 
            this.colPositioni.DataPropertyName = "position";
            this.colPositioni.HeaderText = "Position";
            this.colPositioni.Name = "colPositioni";
            this.colPositioni.ReadOnly = true;
            this.colPositioni.Width = 150;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "date";
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 150;
            // 
            // colstart
            // 
            this.colstart.DataPropertyName = "starttime";
            this.colstart.HeaderText = "Start Time";
            this.colstart.Name = "colstart";
            this.colstart.ReadOnly = true;
            // 
            // colend
            // 
            this.colend.DataPropertyName = "endtime";
            this.colend.HeaderText = "End Time";
            this.colend.Name = "colend";
            this.colend.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 150;
            // 
            // EmployeeSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblposition);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtposition);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblpatientid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.txtmidname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbpatientid);
            this.Controls.Add(this.dgvappointments);
            this.Controls.Add(this.pictureBox2);
            this.Name = "EmployeeSchedule";
            this.Text = "EmployeeSchedule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvappointments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvappointments;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbpatientid;
        private System.Windows.Forms.Label lblpatientid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.TextBox txtmidname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblposition;
        public System.Windows.Forms.Label lblname;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colempid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldmidname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPositioni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colend;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}