namespace Library
{
    partial class frmMemebersManagement
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
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMotherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAdvancedSearch = new System.Windows.Forms.Panel();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.btnSearchByNationalCode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.pnlAdvancedSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmFirstName,
            this.clmLastName,
            this.clmNationalCode,
            this.clmGender,
            this.clmBirth,
            this.clmJoinDate,
            this.clmFatherName,
            this.clmMotherName,
            this.clmPhone,
            this.clmEmail,
            this.clmProvince,
            this.clmCity,
            this.clmAddress,
            this.clmDescription});
            this.dgvMembers.Location = new System.Drawing.Point(0, 343);
            this.dgvMembers.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.Size = new System.Drawing.Size(1872, 798);
            this.dgvMembers.TabIndex = 0;
            // 
            // clmId
            // 
            this.clmId.HeaderText = "کد عضویت";
            this.clmId.MinimumWidth = 6;
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Width = 125;
            // 
            // clmFirstName
            // 
            this.clmFirstName.HeaderText = "نام";
            this.clmFirstName.MinimumWidth = 6;
            this.clmFirstName.Name = "clmFirstName";
            this.clmFirstName.ReadOnly = true;
            // 
            // clmLastName
            // 
            this.clmLastName.HeaderText = "نام خانوادگی";
            this.clmLastName.MinimumWidth = 6;
            this.clmLastName.Name = "clmLastName";
            this.clmLastName.ReadOnly = true;
            this.clmLastName.Width = 125;
            // 
            // clmNationalCode
            // 
            this.clmNationalCode.HeaderText = "کد ملی";
            this.clmNationalCode.MinimumWidth = 6;
            this.clmNationalCode.Name = "clmNationalCode";
            this.clmNationalCode.ReadOnly = true;
            this.clmNationalCode.Width = 125;
            // 
            // clmGender
            // 
            this.clmGender.HeaderText = "جنسیت";
            this.clmGender.MinimumWidth = 6;
            this.clmGender.Name = "clmGender";
            this.clmGender.ReadOnly = true;
            this.clmGender.Width = 70;
            // 
            // clmBirth
            // 
            this.clmBirth.HeaderText = "تاریخ تولد";
            this.clmBirth.MinimumWidth = 6;
            this.clmBirth.Name = "clmBirth";
            this.clmBirth.ReadOnly = true;
            this.clmBirth.Width = 125;
            // 
            // clmJoinDate
            // 
            this.clmJoinDate.HeaderText = "تاریخ عضویت";
            this.clmJoinDate.MinimumWidth = 6;
            this.clmJoinDate.Name = "clmJoinDate";
            this.clmJoinDate.ReadOnly = true;
            this.clmJoinDate.Width = 150;
            // 
            // clmFatherName
            // 
            this.clmFatherName.HeaderText = "نام پدر";
            this.clmFatherName.MinimumWidth = 6;
            this.clmFatherName.Name = "clmFatherName";
            this.clmFatherName.ReadOnly = true;
            // 
            // clmMotherName
            // 
            this.clmMotherName.HeaderText = "نام مادر";
            this.clmMotherName.MinimumWidth = 6;
            this.clmMotherName.Name = "clmMotherName";
            this.clmMotherName.ReadOnly = true;
            // 
            // clmPhone
            // 
            this.clmPhone.HeaderText = "شماره تلفن";
            this.clmPhone.MinimumWidth = 6;
            this.clmPhone.Name = "clmPhone";
            this.clmPhone.ReadOnly = true;
            this.clmPhone.Width = 125;
            // 
            // clmEmail
            // 
            this.clmEmail.HeaderText = "ایمیل";
            this.clmEmail.MinimumWidth = 6;
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            this.clmEmail.Width = 125;
            // 
            // clmProvince
            // 
            this.clmProvince.HeaderText = "استان";
            this.clmProvince.MinimumWidth = 6;
            this.clmProvince.Name = "clmProvince";
            this.clmProvince.ReadOnly = true;
            this.clmProvince.Width = 80;
            // 
            // clmCity
            // 
            this.clmCity.HeaderText = "شهر";
            this.clmCity.MinimumWidth = 6;
            this.clmCity.Name = "clmCity";
            this.clmCity.ReadOnly = true;
            this.clmCity.Width = 80;
            // 
            // clmAddress
            // 
            this.clmAddress.HeaderText = "آدرس";
            this.clmAddress.MinimumWidth = 6;
            this.clmAddress.Name = "clmAddress";
            this.clmAddress.ReadOnly = true;
            this.clmAddress.Width = 200;
            // 
            // clmDescription
            // 
            this.clmDescription.HeaderText = "توضیحات";
            this.clmDescription.MinimumWidth = 6;
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            this.clmDescription.Width = 300;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1660, 161);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 78);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.Location = new System.Drawing.Point(1660, 253);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(191, 81);
            this.btnAddMember.TabIndex = 2;
            this.btnAddMember.Text = "افزودن عضو";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(36, 126);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(191, 78);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "تازه سازی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(36, 20);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(191, 78);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "بازگشت";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlAdvancedSearch
            // 
            this.pnlAdvancedSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAdvancedSearch.Controls.Add(this.btnSearchByName);
            this.pnlAdvancedSearch.Controls.Add(this.txtLastName);
            this.pnlAdvancedSearch.Controls.Add(this.txtFirstName);
            this.pnlAdvancedSearch.Controls.Add(this.lblLastName);
            this.pnlAdvancedSearch.Controls.Add(this.lblFirstName);
            this.pnlAdvancedSearch.Location = new System.Drawing.Point(965, 173);
            this.pnlAdvancedSearch.Name = "pnlAdvancedSearch";
            this.pnlAdvancedSearch.Size = new System.Drawing.Size(638, 161);
            this.pnlAdvancedSearch.TabIndex = 7;
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByName.Location = new System.Drawing.Point(19, 41);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(271, 92);
            this.btnSearchByName.TabIndex = 8;
            this.btnSearchByName.Text = "جستجو نام و نام خانوادگی";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(319, 101);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(176, 32);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(319, 37);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(176, 32);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(526, 104);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(98, 24);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "نام خانوادگی";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(526, 45);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 24);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "نام";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalCode.Location = new System.Drawing.Point(196, 61);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(176, 32);
            this.txtNationalCode.TabIndex = 7;
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalCode.Location = new System.Drawing.Point(319, 31);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(57, 24);
            this.lblNationalCode.TabIndex = 4;
            this.lblNationalCode.Text = "کد ملی";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(290, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(87, 24);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "کد عضویت";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(197, 67);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(176, 32);
            this.txtId.TabIndex = 0;
            // 
            // btnSearchById
            // 
            this.btnSearchById.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchById.Location = new System.Drawing.Point(13, 29);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(178, 94);
            this.btnSearchById.TabIndex = 8;
            this.btnSearchById.Text = "جستجو کد عضویت";
            this.btnSearchById.UseVisualStyleBackColor = true;
            this.btnSearchById.Click += new System.EventHandler(this.btnSearchById_Click);
            // 
            // btnSearchByNationalCode
            // 
            this.btnSearchByNationalCode.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByNationalCode.Location = new System.Drawing.Point(24, 31);
            this.btnSearchByNationalCode.Name = "btnSearchByNationalCode";
            this.btnSearchByNationalCode.Size = new System.Drawing.Size(166, 90);
            this.btnSearchByNationalCode.TabIndex = 9;
            this.btnSearchByNationalCode.Text = "جستجو کد ملی";
            this.btnSearchByNationalCode.UseVisualStyleBackColor = true;
            this.btnSearchByNationalCode.Click += new System.EventHandler(this.btnSearchByNationalCode_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.btnSearchById);
            this.panel1.Location = new System.Drawing.Point(1211, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 155);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtNationalCode);
            this.panel2.Controls.Add(this.lblNationalCode);
            this.panel2.Controls.Add(this.btnSearchByNationalCode);
            this.panel2.Location = new System.Drawing.Point(813, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 155);
            this.panel2.TabIndex = 11;
            // 
            // tmrClock
            // 
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.lblClock);
            this.panel3.Location = new System.Drawing.Point(1622, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 100);
            this.panel3.TabIndex = 14;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // frmMemebersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 1061);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAdvancedSearch);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvMembers);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmMemebersManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmMemebersManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMemebersManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.pnlAdvancedSearch.ResumeLayout(false);
            this.pnlAdvancedSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMotherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAdvancedSearch;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.Button btnSearchByNationalCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Panel panel3;
    }
}