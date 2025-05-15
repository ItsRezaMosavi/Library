namespace Library
{
    partial class frmEmployeeManagement
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBookManagement = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmShelfManagement = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmEmployeeManagement = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmMemberManagement = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmEmployeeAccessManagement = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.btnSearchByNationalCode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnSearchByUserName = new System.Windows.Forms.Button();
            this.pnlAdvancedSearch = new System.Windows.Forms.Panel();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnShowFullInformation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAdvancedSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmUserName,
            this.clmFName,
            this.clmLName,
            this.clmNationalCode,
            this.clmGender,
            this.clmPhoneNumber,
            this.clmEmail,
            this.clmBookManagement,
            this.clmShelfManagement,
            this.clmEmployeeManagement,
            this.clmMemberManagement,
            this.clmEmployeeAccessManagement});
            this.dgvEmployee.Location = new System.Drawing.Point(2, 407);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.Size = new System.Drawing.Size(1354, 393);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            // 
            // clmUserName
            // 
            this.clmUserName.HeaderText = "نام کاربری";
            this.clmUserName.Name = "clmUserName";
            this.clmUserName.ReadOnly = true;
            // 
            // clmFName
            // 
            this.clmFName.HeaderText = "نام";
            this.clmFName.Name = "clmFName";
            this.clmFName.ReadOnly = true;
            // 
            // clmLName
            // 
            this.clmLName.HeaderText = "نام خانوادگی";
            this.clmLName.Name = "clmLName";
            this.clmLName.ReadOnly = true;
            // 
            // clmNationalCode
            // 
            this.clmNationalCode.HeaderText = "کد ملی";
            this.clmNationalCode.Name = "clmNationalCode";
            this.clmNationalCode.ReadOnly = true;
            // 
            // clmGender
            // 
            this.clmGender.HeaderText = "جنسیت";
            this.clmGender.Name = "clmGender";
            this.clmGender.ReadOnly = true;
            // 
            // clmPhoneNumber
            // 
            this.clmPhoneNumber.HeaderText = "تلفن همراه";
            this.clmPhoneNumber.Name = "clmPhoneNumber";
            this.clmPhoneNumber.ReadOnly = true;
            // 
            // clmEmail
            // 
            this.clmEmail.HeaderText = "ایمیل";
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            // 
            // clmBookManagement
            // 
            this.clmBookManagement.HeaderText = "مدیریت کتاب ها";
            this.clmBookManagement.Name = "clmBookManagement";
            this.clmBookManagement.ReadOnly = true;
            this.clmBookManagement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmBookManagement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmBookManagement.Width = 120;
            // 
            // clmShelfManagement
            // 
            this.clmShelfManagement.HeaderText = "مدیریت قفسه ها";
            this.clmShelfManagement.Name = "clmShelfManagement";
            this.clmShelfManagement.ReadOnly = true;
            this.clmShelfManagement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmShelfManagement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmShelfManagement.Width = 120;
            // 
            // clmEmployeeManagement
            // 
            this.clmEmployeeManagement.HeaderText = "مدیریت کارمندان";
            this.clmEmployeeManagement.Name = "clmEmployeeManagement";
            this.clmEmployeeManagement.ReadOnly = true;
            this.clmEmployeeManagement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmEmployeeManagement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmEmployeeManagement.Width = 120;
            // 
            // clmMemberManagement
            // 
            this.clmMemberManagement.HeaderText = "مدیریت اعضا";
            this.clmMemberManagement.Name = "clmMemberManagement";
            this.clmMemberManagement.ReadOnly = true;
            this.clmMemberManagement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmMemberManagement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmEmployeeAccessManagement
            // 
            this.clmEmployeeAccessManagement.HeaderText = "مدیریت دسترسی کارمندان";
            this.clmEmployeeAccessManagement.Name = "clmEmployeeAccessManagement";
            this.clmEmployeeAccessManagement.ReadOnly = true;
            this.clmEmployeeAccessManagement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmEmployeeAccessManagement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmEmployeeAccessManagement.Width = 150;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(1146, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 71);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.lblClock);
            this.panel3.Location = new System.Drawing.Point(1108, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 100);
            this.panel3.TabIndex = 20;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(3, 8);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 24);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "label1";
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(47, 62);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(69, 24);
            this.lblClock.TabIndex = 13;
            this.lblClock.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtNationalCode);
            this.panel2.Controls.Add(this.lblNationalCode);
            this.panel2.Controls.Add(this.btnSearchByNationalCode);
            this.panel2.Location = new System.Drawing.Point(398, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 106);
            this.panel2.TabIndex = 19;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalCode.Location = new System.Drawing.Point(175, 53);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(176, 32);
            this.txtNationalCode.TabIndex = 7;
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalCode.Location = new System.Drawing.Point(286, 9);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(57, 24);
            this.lblNationalCode.TabIndex = 4;
            this.lblNationalCode.Text = "کد ملی";
            // 
            // btnSearchByNationalCode
            // 
            this.btnSearchByNationalCode.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByNationalCode.Location = new System.Drawing.Point(3, 17);
            this.btnSearchByNationalCode.Name = "btnSearchByNationalCode";
            this.btnSearchByNationalCode.Size = new System.Drawing.Size(166, 68);
            this.btnSearchByNationalCode.TabIndex = 9;
            this.btnSearchByNationalCode.Text = "جستجو کد ملی";
            this.btnSearchByNationalCode.UseVisualStyleBackColor = true;
            this.btnSearchByNationalCode.Click += new System.EventHandler(this.btnSearchByNationalCode_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.btnSearchByUserName);
            this.panel1.Location = new System.Drawing.Point(12, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 106);
            this.panel1.TabIndex = 18;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(184, 53);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(176, 32);
            this.txtUserName.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(266, 16);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(86, 24);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "نام کاربری";
            // 
            // btnSearchByUserName
            // 
            this.btnSearchByUserName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByUserName.Location = new System.Drawing.Point(3, 16);
            this.btnSearchByUserName.Name = "btnSearchByUserName";
            this.btnSearchByUserName.Size = new System.Drawing.Size(178, 69);
            this.btnSearchByUserName.TabIndex = 8;
            this.btnSearchByUserName.Text = "جستجو نام کاربری";
            this.btnSearchByUserName.UseVisualStyleBackColor = true;
            this.btnSearchByUserName.Click += new System.EventHandler(this.btnSearchByUserName_Click);
            // 
            // pnlAdvancedSearch
            // 
            this.pnlAdvancedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAdvancedSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAdvancedSearch.Controls.Add(this.btnSearchByName);
            this.pnlAdvancedSearch.Controls.Add(this.txtLastName);
            this.pnlAdvancedSearch.Controls.Add(this.txtFirstName);
            this.pnlAdvancedSearch.Controls.Add(this.lblLastName);
            this.pnlAdvancedSearch.Controls.Add(this.lblFirstName);
            this.pnlAdvancedSearch.Location = new System.Drawing.Point(776, 295);
            this.pnlAdvancedSearch.Name = "pnlAdvancedSearch";
            this.pnlAdvancedSearch.Size = new System.Drawing.Size(561, 106);
            this.pnlAdvancedSearch.TabIndex = 17;
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByName.Location = new System.Drawing.Point(13, 7);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(240, 92);
            this.btnSearchByName.TabIndex = 8;
            this.btnSearchByName.Text = "جستجو نام و نام خانوادگی";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(274, 58);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(176, 32);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(274, 13);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(176, 32);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(456, 61);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(98, 24);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "نام خانوادگی";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(500, 16);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 24);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "نام";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEmployee.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(1146, 206);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(191, 71);
            this.btnAddEmployee.TabIndex = 16;
            this.btnAddEmployee.Text = "افزودن کارمند";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(191, 78);
            this.btnReturn.TabIndex = 22;
            this.btnReturn.Text = "بازگشت";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 96);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(191, 78);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "تازه سازی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(601, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 32);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "مدیریت کارمندان";
            // 
            // btnShowFullInformation
            // 
            this.btnShowFullInformation.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFullInformation.Location = new System.Drawing.Point(948, 208);
            this.btnShowFullInformation.Name = "btnShowFullInformation";
            this.btnShowFullInformation.Size = new System.Drawing.Size(191, 71);
            this.btnShowFullInformation.TabIndex = 24;
            this.btnShowFullInformation.Text = "نمایش اطلاعات کارمند";
            this.btnShowFullInformation.UseVisualStyleBackColor = true;
            // 
            // frmEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 800);
            this.Controls.Add(this.btnShowFullInformation);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAdvancedSearch);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "frmEmployeeManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmEmployeeManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmployeeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAdvancedSearch.ResumeLayout(false);
            this.pnlAdvancedSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Button btnSearchByNationalCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSearchByUserName;
        private System.Windows.Forms.Panel pnlAdvancedSearch;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmBookManagement;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmShelfManagement;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmEmployeeManagement;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmMemberManagement;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmEmployeeAccessManagement;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnShowFullInformation;
    }
}