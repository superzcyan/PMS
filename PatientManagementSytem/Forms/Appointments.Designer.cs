namespace PMS
{
    partial class Appointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointments));
            this.label2 = new System.Windows.Forms.Label();
            this.btnExt = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblposition = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.dgvappointments = new System.Windows.Forms.DataGridView();
            this.colpatientid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbpatientid = new System.Windows.Forms.ComboBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chklistMedical = new System.Windows.Forms.CheckedListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtboxmedical = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvappointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(764, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 49);
            this.label2.TabIndex = 8;
            this.label2.Text = "Scheduled Appointments";
            // 
            // btnExt
            // 
            this.btnExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(222)))));
            this.btnExt.FlatAppearance.BorderSize = 0;
            this.btnExt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(175)))), ((int)(((byte)(87)))));
            this.btnExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.btnExt.Location = new System.Drawing.Point(1554, 929);
            this.btnExt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(275, 50);
            this.btnExt.TabIndex = 9;
            this.btnExt.Text = "Exit";
            this.btnExt.UseVisualStyleBackColor = false;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            this.btnExt.MouseEnter += new System.EventHandler(this.btnExt_MouseEnter);
            this.btnExt.MouseLeave += new System.EventHandler(this.btnExt_MouseLeave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(222)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(175)))), ((int)(((byte)(87)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.btnUpdate.Location = new System.Drawing.Point(943, 830);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(275, 50);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnUpdate_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(222)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(175)))), ((int)(((byte)(87)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.btnAdd.Location = new System.Drawing.Point(658, 830);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(275, 50);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button4_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(222)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(175)))), ((int)(((byte)(87)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.btnDelete.Location = new System.Drawing.Point(1237, 830);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(275, 50);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblposition.ForeColor = System.Drawing.Color.Black;
            this.lblposition.Location = new System.Drawing.Point(38, 76);
            this.lblposition.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(68, 21);
            this.lblposition.TabIndex = 14;
            this.lblposition.Text = "Position";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.lblname.Location = new System.Drawing.Point(121, 41);
            this.lblname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(58, 21);
            this.lblname.TabIndex = 13;
            this.lblname.Text = "Name";
            // 
            // dgvappointments
            // 
            this.dgvappointments.AllowUserToResizeColumns = false;
            this.dgvappointments.AllowUserToResizeRows = false;
            this.dgvappointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvappointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvappointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvappointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvappointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colpatientid,
            this.colPatient,
            this.coldoctor,
            this.coldescription,
            this.coldate,
            this.colstart,
            this.colend});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvappointments.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvappointments.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvappointments.Location = new System.Drawing.Point(434, 422);
            this.dgvappointments.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvappointments.Name = "dgvappointments";
            this.dgvappointments.ReadOnly = true;
            this.dgvappointments.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvappointments.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvappointments.Size = new System.Drawing.Size(1222, 400);
            this.dgvappointments.TabIndex = 35;
            this.dgvappointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvappointments_CellContentClick);
            // 
            // colpatientid
            // 
            this.colpatientid.DataPropertyName = "patientid";
            this.colpatientid.HeaderText = "Patient Id";
            this.colpatientid.Name = "colpatientid";
            this.colpatientid.ReadOnly = true;
            this.colpatientid.Width = 150;
            // 
            // colPatient
            // 
            this.colPatient.DataPropertyName = "patientname";
            this.colPatient.HeaderText = "Patient Name";
            this.colPatient.Name = "colPatient";
            this.colPatient.ReadOnly = true;
            this.colPatient.Width = 250;
            // 
            // coldoctor
            // 
            this.coldoctor.DataPropertyName = "doctor";
            this.coldoctor.HeaderText = "Doctor";
            this.coldoctor.Name = "coldoctor";
            this.coldoctor.ReadOnly = true;
            this.coldoctor.Width = 200;
            // 
            // coldescription
            // 
            this.coldescription.DataPropertyName = "description";
            this.coldescription.HeaderText = "Description";
            this.coldescription.Name = "coldescription";
            this.coldescription.ReadOnly = true;
            this.coldescription.Width = 250;
            // 
            // coldate
            // 
            this.coldate.DataPropertyName = "date";
            this.coldate.HeaderText = "Date";
            this.coldate.Name = "coldate";
            this.coldate.ReadOnly = true;
            this.coldate.Width = 150;
            // 
            // colstart
            // 
            this.colstart.DataPropertyName = "start";
            this.colstart.HeaderText = "Start Time";
            this.colstart.Name = "colstart";
            this.colstart.ReadOnly = true;
            this.colstart.Width = 110;
            // 
            // colend
            // 
            this.colend.DataPropertyName = "end";
            this.colend.HeaderText = "End Time";
            this.colend.Name = "colend";
            this.colend.ReadOnly = true;
            this.colend.Width = 110;
            // 
            // cmbpatientid
            // 
            this.cmbpatientid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbpatientid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpatientid.FormattingEnabled = true;
            this.cmbpatientid.Items.AddRange(new object[] {
            "All"});
            this.cmbpatientid.Location = new System.Drawing.Point(507, 384);
            this.cmbpatientid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbpatientid.Name = "cmbpatientid";
            this.cmbpatientid.Size = new System.Drawing.Size(213, 29);
            this.cmbpatientid.TabIndex = 37;
            this.cmbpatientid.Text = "All";
            this.cmbpatientid.SelectedIndexChanged += new System.EventHandler(this.cmbpatientid_SelectedIndexChanged);
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(555, 124);
            this.txtPatientID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(155, 30);
            this.txtPatientID.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Login as : ";
            // 
            // piclogo
            // 
            this.piclogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.piclogo.Image = ((System.Drawing.Image)(resources.GetObject("piclogo.Image")));
            this.piclogo.Location = new System.Drawing.Point(906, 28);
            this.piclogo.Margin = new System.Windows.Forms.Padding(6);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(275, 275);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 40;
            this.piclogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(457, 388);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Sort :";
            // 
            // chklistMedical
            // 
            this.chklistMedical.FormattingEnabled = true;
            this.chklistMedical.Items.AddRange(new object[] {
            "Diabetes",
            "Highblood Pressure",
            "Goiter",
            "Leukemia"});
            this.chklistMedical.Location = new System.Drawing.Point(298, 85);
            this.chklistMedical.Name = "chklistMedical";
            this.chklistMedical.Size = new System.Drawing.Size(224, 229);
            this.chklistMedical.TabIndex = 42;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(555, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 32);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtboxmedical
            // 
            this.txtboxmedical.Location = new System.Drawing.Point(42, 329);
            this.txtboxmedical.Multiline = true;
            this.txtboxmedical.Name = "txtboxmedical";
            this.txtboxmedical.Size = new System.Drawing.Size(344, 164);
            this.txtboxmedical.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 47);
            this.button1.TabIndex = 45;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtboxmedical);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.chklistMedical);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.piclogo);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.cmbpatientid);
            this.Controls.Add(this.dgvappointments);
            this.Controls.Add(this.lblposition);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Appointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Appointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvappointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExt;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Label lblposition;
        public System.Windows.Forms.Label lblname;
        private System.Windows.Forms.DataGridView dgvappointments;
        private System.Windows.Forms.ComboBox cmbpatientid;
        private System.Windows.Forms.TextBox txtPatientID;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox piclogo;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpatientid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colend;
        private System.Windows.Forms.CheckedListBox chklistMedical;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtboxmedical;
        private System.Windows.Forms.Button button1;
    }
}