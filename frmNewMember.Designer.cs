namespace library
{
    partial class frmNewMember
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
            components = new System.ComponentModel.Container();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtNationalCode = new TextBox();
            txtBirthMonth = new TextBox();
            txtBirthYear = new TextBox();
            txtBirthday = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblNationalCode = new Label();
            lblBirth = new Label();
            lblDate = new Label();
            lblClock = new Label();
            lblLibraryName = new Label();
            tmrMain = new System.Windows.Forms.Timer(components);
            btnRegistration = new Button();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 18F, FontStyle.Bold);
            txtFirstName.Location = new Point(330, 219);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(149, 35);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 18F, FontStyle.Bold);
            txtLastName.Location = new Point(329, 278);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 35);
            txtLastName.TabIndex = 1;
            // 
            // txtNationalCode
            // 
            txtNationalCode.Font = new Font("Arial", 18F, FontStyle.Bold);
            txtNationalCode.Location = new Point(329, 337);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(150, 35);
            txtNationalCode.TabIndex = 2;
            // 
            // txtBirthMonth
            // 
            txtBirthMonth.Font = new Font("Arial", 18F, FontStyle.Bold);
            txtBirthMonth.Location = new Point(356, 394);
            txtBirthMonth.Name = "txtBirthMonth";
            txtBirthMonth.Size = new Size(56, 35);
            txtBirthMonth.TabIndex = 3;
            // 
            // txtBirthYear
            // 
            txtBirthYear.Font = new Font("Arial", 18F, FontStyle.Bold);
            txtBirthYear.Location = new Point(284, 395);
            txtBirthYear.Name = "txtBirthYear";
            txtBirthYear.Size = new Size(56, 35);
            txtBirthYear.TabIndex = 4;
            // 
            // txtBirthday
            // 
            txtBirthday.Font = new Font("Arial", 18F, FontStyle.Bold);
            txtBirthday.Location = new Point(423, 394);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new Size(56, 35);
            txtBirthday.TabIndex = 5;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblFirstName.Location = new Point(162, 219);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(49, 29);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "نام :";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblLastName.Location = new Point(156, 276);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(128, 29);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "نام خانوادگی :";
            // 
            // lblNationalCode
            // 
            lblNationalCode.AutoSize = true;
            lblNationalCode.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblNationalCode.Location = new Point(152, 340);
            lblNationalCode.Name = "lblNationalCode";
            lblNationalCode.Size = new Size(80, 29);
            lblNationalCode.TabIndex = 8;
            lblNationalCode.Text = "کد ملی :";
            // 
            // lblBirth
            // 
            lblBirth.AutoSize = true;
            lblBirth.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblBirth.Location = new Point(152, 400);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(109, 29);
            lblBirth.TabIndex = 9;
            lblBirth.Text = "تاریخ تولد :";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(499, 137);
            lblDate.Name = "lblDate";
            lblDate.RightToLeft = RightToLeft.Yes;
            lblDate.Size = new Size(38, 19);
            lblDate.TabIndex = 12;
            lblDate.Text = "date";
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClock.Location = new Point(393, 137);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(38, 19);
            lblClock.TabIndex = 11;
            lblClock.Text = "hour";
            // 
            // lblLibraryName
            // 
            lblLibraryName.AutoSize = true;
            lblLibraryName.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLibraryName.Location = new Point(342, 63);
            lblLibraryName.Name = "lblLibraryName";
            lblLibraryName.RightToLeft = RightToLeft.Yes;
            lblLibraryName.Size = new Size(223, 41);
            lblLibraryName.TabIndex = 10;
            lblLibraryName.Text = "library name";
            lblLibraryName.Click += lblLibraryName_Click;
            // 
            // tmrMain
            // 
            tmrMain.Enabled = true;
            tmrMain.Tick += tmrMain_Tick;
            // 
            // btnRegistration
            // 
            btnRegistration.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistration.Location = new Point(371, 483);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(155, 49);
            btnRegistration.TabIndex = 13;
            btnRegistration.Text = "ثبت نام";
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // frmNewMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 678);
            Controls.Add(btnRegistration);
            Controls.Add(lblDate);
            Controls.Add(lblClock);
            Controls.Add(lblLibraryName);
            Controls.Add(lblBirth);
            Controls.Add(lblNationalCode);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtBirthday);
            Controls.Add(txtBirthYear);
            Controls.Add(txtBirthMonth);
            Controls.Add(txtNationalCode);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "frmNewMember";
            Text = "frmNewMember";
            Load += frmNewMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtNationalCode;
        private TextBox txtBirthMonth;
        private TextBox txtBirthYear;
        private TextBox txtBirthday;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblNationalCode;
        private Label lblBirth;
        private Label lblDate;
        private Label lblClock;
        private Label lblLibraryName;
        private System.Windows.Forms.Timer tmrMain;
        private Button btnRegistration;
    }
}