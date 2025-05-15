namespace library
{
    partial class frmLogin
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
            lblLibraryName = new Label();
            lblClock = new Label();
            lblDate = new Label();
            tmrMain = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            btnLogin = new Button();
            lblTitle = new Label();
            lblPassword = new Label();
            lblUserId = new Label();
            lblName = new Label();
            txtPassword = new TextBox();
            txtUserId = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            lblLastName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblLibraryName
            // 
            lblLibraryName.AutoSize = true;
            lblLibraryName.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLibraryName.Location = new Point(218, 35);
            lblLibraryName.Name = "lblLibraryName";
            lblLibraryName.RightToLeft = RightToLeft.Yes;
            lblLibraryName.Size = new Size(223, 41);
            lblLibraryName.TabIndex = 1;
            lblLibraryName.Text = "library name";
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClock.Location = new Point(269, 109);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(38, 19);
            lblClock.TabIndex = 3;
            lblClock.Text = "hour";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(375, 109);
            lblDate.Name = "lblDate";
            lblDate.RightToLeft = RightToLeft.Yes;
            lblDate.Size = new Size(38, 19);
            lblDate.TabIndex = 4;
            lblDate.Text = "date";
            // 
            // tmrMain
            // 
            tmrMain.Enabled = true;
            tmrMain.Tick += tmrMain_Tick;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblUserId);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUserId);
            panel1.Controls.Add(txtFirstName);
            panel1.Location = new Point(32, 154);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 520);
            panel1.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(233, 384);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(184, 53);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "ورود";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(307, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(60, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
            lblPassword.Location = new Point(164, 305);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(85, 26);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "گذرواژه :";
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
            lblUserId.Location = new Point(147, 241);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(102, 26);
            lblUserId.TabIndex = 5;
            lblUserId.Text = "کد پرسنلی :";
            lblUserId.Click += lblUserId_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
            lblName.Location = new Point(207, 125);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 26);
            lblName.TabIndex = 4;
            lblName.Text = "نام :";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            txtPassword.Location = new Point(285, 299);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(202, 32);
            txtPassword.TabIndex = 3;
            // 
            // txtUserId
            // 
            txtUserId.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            txtUserId.Location = new Point(285, 239);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(202, 32);
            txtUserId.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            txtFirstName.Location = new Point(285, 118);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(202, 32);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(285, 179);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(202, 32);
            txtLastName.TabIndex = 8;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(130, 185);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(119, 26);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "نام خانوادگی :";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 699);
            Controls.Add(panel1);
            Controls.Add(lblDate);
            Controls.Add(lblClock);
            Controls.Add(lblLibraryName);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmLogin";
            Load += frmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLibraryName;
        private Label lblClock;
        private Label lblDate;
        private System.Windows.Forms.Timer tmrMain;
        private Panel panel1;
        private Label lblTitle;
        private TextBox txtPassword;
        private TextBox txtUserId;
        private TextBox txtFirstName;
        private Label lblPassword;
        private Label lblUserId;
        private Label lblName;
        private Button btnLogin;
        private TextBox txtLastName;
        private Label lblLastName;
    }
}



