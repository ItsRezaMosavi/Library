namespace Library
{
    partial class frmMain
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
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnMembersManagement = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.pnlTime = new System.Windows.Forms.Panel();
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnShelves = new System.Windows.Forms.Button();
            this.btnBooksManagement = new System.Windows.Forms.Button();
            this.pnlTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMember
            // 
            this.btnAddMember.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.Location = new System.Drawing.Point(71, 147);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(281, 155);
            this.btnAddMember.TabIndex = 0;
            this.btnAddMember.Text = "افزودن عضو";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnMembersManagement
            // 
            this.btnMembersManagement.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembersManagement.Location = new System.Drawing.Point(71, 337);
            this.btnMembersManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnMembersManagement.Name = "btnMembersManagement";
            this.btnMembersManagement.Size = new System.Drawing.Size(281, 155);
            this.btnMembersManagement.TabIndex = 1;
            this.btnMembersManagement.Text = "مدیریت اعضا";
            this.btnMembersManagement.UseVisualStyleBackColor = true;
            this.btnMembersManagement.Click += new System.EventHandler(this.btnMembersManagement_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(385, 147);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(281, 155);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "افزودن کارمندان";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(18, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 24);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label1";
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(72, 61);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(69, 24);
            this.lblClock.TabIndex = 4;
            this.lblClock.Text = "label1";
            this.lblClock.Click += new System.EventHandler(this.lblClock_Click);
            // 
            // tmrClock
            // 
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // pnlTime
            // 
            this.pnlTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTime.Controls.Add(this.lblDate);
            this.pnlTime.Controls.Add(this.lblClock);
            this.pnlTime.Location = new System.Drawing.Point(1070, 12);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(238, 100);
            this.pnlTime.TabIndex = 5;
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeManagement.Location = new System.Drawing.Point(386, 337);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(281, 155);
            this.btnEmployeeManagement.TabIndex = 6;
            this.btnEmployeeManagement.Text = "مدیریت کارمندان";
            this.btnEmployeeManagement.UseVisualStyleBackColor = true;
            this.btnEmployeeManagement.Click += new System.EventHandler(this.btnEmployeeManagement_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(699, 147);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(281, 155);
            this.btnAddBook.TabIndex = 7;
            this.btnAddBook.Text = "افزودن کتاب";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnShelves
            // 
            this.btnShelves.Location = new System.Drawing.Point(1013, 147);
            this.btnShelves.Name = "btnShelves";
            this.btnShelves.Size = new System.Drawing.Size(281, 155);
            this.btnShelves.TabIndex = 8;
            this.btnShelves.Text = "قفسه ها";
            this.btnShelves.UseVisualStyleBackColor = true;
            this.btnShelves.Click += new System.EventHandler(this.btnShelves_Click);
            // 
            // btnBooksManagement
            // 
            this.btnBooksManagement.Location = new System.Drawing.Point(701, 337);
            this.btnBooksManagement.Name = "btnBooksManagement";
            this.btnBooksManagement.Size = new System.Drawing.Size(281, 155);
            this.btnBooksManagement.TabIndex = 9;
            this.btnBooksManagement.Text = "مدیریت کتاب ها";
            this.btnBooksManagement.UseVisualStyleBackColor = true;
            this.btnBooksManagement.Click += new System.EventHandler(this.btnBooksManagement_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 695);
            this.Controls.Add(this.btnBooksManagement);
            this.Controls.Add(this.btnShelves);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnEmployeeManagement);
            this.Controls.Add(this.pnlTime);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnMembersManagement);
            this.Controls.Add(this.btnAddMember);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "کتابخانه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnMembersManagement;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Button btnEmployeeManagement;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnShelves;
        private System.Windows.Forms.Button btnBooksManagement;
    }
}