namespace Library
{
    partial class frmAddEmployee
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.pnlConnection = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.pnlParentsName = new System.Windows.Forms.Panel();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.lblMotherName = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.pnlIdentity = new System.Windows.Forms.Panel();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbBirthYear = new System.Windows.Forms.ComboBox();
            this.cmbBirthMonth = new System.Windows.Forms.ComboBox();
            this.cmbBirthDay = new System.Windows.Forms.ComboBox();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlAddress.SuspendLayout();
            this.pnlConnection.SuspendLayout();
            this.pnlParentsName.SuspendLayout();
            this.pnlIdentity.SuspendLayout();
            this.pnlLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblClock);
            this.panel1.Location = new System.Drawing.Point(1026, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 100);
            this.panel1.TabIndex = 37;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(15, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 24);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "label1";
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(83, 67);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(69, 24);
            this.lblClock.TabIndex = 25;
            this.lblClock.Text = "label2";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(27, 25);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(162, 78);
            this.btnReturn.TabIndex = 36;
            this.btnReturn.Text = "بازگشت";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(1214, 566);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(84, 25);
            this.lblDescription.TabIndex = 35;
            this.lblDescription.Text = "توضیحات";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(789, 542);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(407, 153);
            this.txtDescription.TabIndex = 34;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(157, 616);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(190, 75);
            this.btnAddEmployee.TabIndex = 31;
            this.btnAddEmployee.Text = "افزودن";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // pnlAddress
            // 
            this.pnlAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddress.Controls.Add(this.txtAddress);
            this.pnlAddress.Controls.Add(this.txtCity);
            this.pnlAddress.Controls.Add(this.txtProvince);
            this.pnlAddress.Controls.Add(this.lblAddress);
            this.pnlAddress.Controls.Add(this.lblProvince);
            this.pnlAddress.Controls.Add(this.lblCity);
            this.pnlAddress.Location = new System.Drawing.Point(656, 318);
            this.pnlAddress.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(641, 206);
            this.pnlAddress.TabIndex = 30;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(103, 81);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(435, 107);
            this.txtAddress.TabIndex = 19;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(43, 28);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(154, 29);
            this.txtCity.TabIndex = 18;
            // 
            // txtProvince
            // 
            this.txtProvince.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvince.Location = new System.Drawing.Point(419, 28);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(2);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(119, 29);
            this.txtProvince.TabIndex = 17;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(547, 80);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 25);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "آدرس :";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(547, 26);
            this.lblProvince.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(63, 25);
            this.lblProvince.TabIndex = 14;
            this.lblProvince.Text = "استان :";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(200, 29);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(56, 25);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "شهر :";
            // 
            // pnlConnection
            // 
            this.pnlConnection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlConnection.Controls.Add(this.txtEmail);
            this.pnlConnection.Controls.Add(this.txtPhoneNumber);
            this.pnlConnection.Controls.Add(this.lblEmail);
            this.pnlConnection.Controls.Add(this.lblPhoneNumber);
            this.pnlConnection.Location = new System.Drawing.Point(27, 318);
            this.pnlConnection.Margin = new System.Windows.Forms.Padding(2);
            this.pnlConnection.Name = "pnlConnection";
            this.pnlConnection.Size = new System.Drawing.Size(611, 206);
            this.pnlConnection.TabIndex = 29;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(115, 112);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 29);
            this.txtEmail.TabIndex = 12;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(115, 28);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(290, 29);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(476, 114);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 25);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "ایمیل :";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(476, 28);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(99, 25);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "تلفن همراه :";
            // 
            // pnlParentsName
            // 
            this.pnlParentsName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlParentsName.Controls.Add(this.txtMotherName);
            this.pnlParentsName.Controls.Add(this.txtFatherName);
            this.pnlParentsName.Controls.Add(this.lblMotherName);
            this.pnlParentsName.Controls.Add(this.lblFatherName);
            this.pnlParentsName.Location = new System.Drawing.Point(27, 125);
            this.pnlParentsName.Margin = new System.Windows.Forms.Padding(2);
            this.pnlParentsName.Name = "pnlParentsName";
            this.pnlParentsName.Size = new System.Drawing.Size(381, 175);
            this.pnlParentsName.TabIndex = 28;
            // 
            // txtMotherName
            // 
            this.txtMotherName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotherName.Location = new System.Drawing.Point(77, 109);
            this.txtMotherName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(181, 29);
            this.txtMotherName.TabIndex = 7;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatherName.Location = new System.Drawing.Point(77, 30);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(181, 29);
            this.txtFatherName.TabIndex = 6;
            // 
            // lblMotherName
            // 
            this.lblMotherName.AutoSize = true;
            this.lblMotherName.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotherName.Location = new System.Drawing.Point(262, 109);
            this.lblMotherName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotherName.Name = "lblMotherName";
            this.lblMotherName.Size = new System.Drawing.Size(79, 25);
            this.lblMotherName.TabIndex = 5;
            this.lblMotherName.Text = "نام مادر :";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatherName.Location = new System.Drawing.Point(270, 31);
            this.lblFatherName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(70, 25);
            this.lblFatherName.TabIndex = 4;
            this.lblFatherName.Text = "نام پدر :";
            // 
            // pnlIdentity
            // 
            this.pnlIdentity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlIdentity.Controls.Add(this.cmbGender);
            this.pnlIdentity.Controls.Add(this.cmbBirthYear);
            this.pnlIdentity.Controls.Add(this.cmbBirthMonth);
            this.pnlIdentity.Controls.Add(this.cmbBirthDay);
            this.pnlIdentity.Controls.Add(this.txtNationalCode);
            this.pnlIdentity.Controls.Add(this.txtLastName);
            this.pnlIdentity.Controls.Add(this.txtFirstName);
            this.pnlIdentity.Controls.Add(this.lblLastName);
            this.pnlIdentity.Controls.Add(this.lblFirstName);
            this.pnlIdentity.Controls.Add(this.lblNationalCode);
            this.pnlIdentity.Controls.Add(this.lblBirthDate);
            this.pnlIdentity.Controls.Add(this.lblGender);
            this.pnlIdentity.Location = new System.Drawing.Point(431, 125);
            this.pnlIdentity.Margin = new System.Windows.Forms.Padding(2);
            this.pnlIdentity.Name = "pnlIdentity";
            this.pnlIdentity.Size = new System.Drawing.Size(866, 175);
            this.pnlIdentity.TabIndex = 27;
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "مرد",
            "زن"});
            this.cmbGender.Location = new System.Drawing.Point(26, 15);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(87, 33);
            this.cmbGender.TabIndex = 26;
            // 
            // cmbBirthYear
            // 
            this.cmbBirthYear.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBirthYear.FormattingEnabled = true;
            this.cmbBirthYear.Location = new System.Drawing.Point(226, 93);
            this.cmbBirthYear.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBirthYear.Name = "cmbBirthYear";
            this.cmbBirthYear.Size = new System.Drawing.Size(75, 33);
            this.cmbBirthYear.TabIndex = 25;
            // 
            // cmbBirthMonth
            // 
            this.cmbBirthMonth.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBirthMonth.FormattingEnabled = true;
            this.cmbBirthMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbBirthMonth.Location = new System.Drawing.Point(304, 93);
            this.cmbBirthMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBirthMonth.Name = "cmbBirthMonth";
            this.cmbBirthMonth.Size = new System.Drawing.Size(66, 33);
            this.cmbBirthMonth.TabIndex = 24;
            this.cmbBirthMonth.SelectedIndexChanged += new System.EventHandler(this.cmbBirthMonth_SelectedIndexChanged);
            // 
            // cmbBirthDay
            // 
            this.cmbBirthDay.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBirthDay.FormattingEnabled = true;
            this.cmbBirthDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbBirthDay.Location = new System.Drawing.Point(374, 93);
            this.cmbBirthDay.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBirthDay.Name = "cmbBirthDay";
            this.cmbBirthDay.Size = new System.Drawing.Size(55, 33);
            this.cmbBirthDay.TabIndex = 24;
            this.cmbBirthDay.SelectedIndexChanged += new System.EventHandler(this.cmbBirthDay_SelectedIndexChanged);
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalCode.Location = new System.Drawing.Point(608, 91);
            this.txtNationalCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(150, 29);
            this.txtNationalCode.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(275, 11);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(136, 29);
            this.txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(657, 13);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(137, 29);
            this.txtFirstName.TabIndex = 8;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(428, 13);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(113, 25);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "نام خانوادگی :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(806, 15);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(41, 25);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "نام :";
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalCode.Location = new System.Drawing.Point(782, 93);
            this.lblNationalCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(73, 25);
            this.lblNationalCode.TabIndex = 3;
            this.lblNationalCode.Text = "کد ملی :";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(432, 96);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(95, 25);
            this.lblBirthDate.TabIndex = 6;
            this.lblBirthDate.Text = "تاریخ تولد :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(116, 15);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(74, 25);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "جنسیت :";
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(20, 35);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(138, 32);
            this.txtUserName.TabIndex = 38;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(21, 103);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(149, 32);
            this.txtPassWord.TabIndex = 39;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(164, 39);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(99, 24);
            this.lblUserName.TabIndex = 40;
            this.lblUserName.Text = "نام کاربری :";
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassWord.Location = new System.Drawing.Point(176, 103);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(91, 24);
            this.lblPassWord.TabIndex = 41;
            this.lblPassWord.Text = "رمز عبور :";
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLogIn.Controls.Add(this.txtUserName);
            this.pnlLogIn.Controls.Add(this.lblPassWord);
            this.pnlLogIn.Controls.Add(this.txtPassWord);
            this.pnlLogIn.Controls.Add(this.lblUserName);
            this.pnlLogIn.Location = new System.Drawing.Point(490, 536);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(274, 171);
            this.pnlLogIn.TabIndex = 42;
            this.pnlLogIn.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(560, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 32);
            this.lblTitle.TabIndex = 43;
            this.lblTitle.Text = "افزودن کارمندان ";
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 741);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlLogIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.pnlAddress);
            this.Controls.Add(this.pnlConnection);
            this.Controls.Add(this.pnlParentsName);
            this.Controls.Add(this.pnlIdentity);
            this.Name = "frmAddEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmAddEmploee";
            this.Load += new System.EventHandler(this.frmAddEmploee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
            this.pnlConnection.ResumeLayout(false);
            this.pnlConnection.PerformLayout();
            this.pnlParentsName.ResumeLayout(false);
            this.pnlParentsName.PerformLayout();
            this.pnlIdentity.ResumeLayout(false);
            this.pnlIdentity.PerformLayout();
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Panel pnlAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Panel pnlConnection;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Panel pnlParentsName;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label lblMotherName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Panel pnlIdentity;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbBirthYear;
        private System.Windows.Forms.ComboBox cmbBirthMonth;
        private System.Windows.Forms.ComboBox cmbBirthDay;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.Panel pnlLogIn;
        private System.Windows.Forms.Label lblTitle;
    }
}