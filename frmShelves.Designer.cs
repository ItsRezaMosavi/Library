namespace Library
{
    partial class frmShelves
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
            this.dgvShelves = new System.Windows.Forms.DataGridView();
            this.clmShelfNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUsedCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvailableCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtShelfNumber = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblShelfNumber = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.btnAddShelf = new System.Windows.Forms.Button();
            this.pnlAddShelf = new System.Windows.Forms.Panel();
            this.lblAddShelf = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.btnBookInsert = new System.Windows.Forms.Button();
            this.btnShelfManagement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelves)).BeginInit();
            this.pnlAddShelf.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShelves
            // 
            this.dgvShelves.AllowUserToAddRows = false;
            this.dgvShelves.AllowUserToDeleteRows = false;
            this.dgvShelves.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShelves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShelves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmShelfNumber,
            this.clmCapacity,
            this.clmUsedCapacity,
            this.clmAvailableCapacity});
            this.dgvShelves.Location = new System.Drawing.Point(1, 361);
            this.dgvShelves.Name = "dgvShelves";
            this.dgvShelves.ReadOnly = true;
            this.dgvShelves.Size = new System.Drawing.Size(1210, 361);
            this.dgvShelves.TabIndex = 0;
            // 
            // clmShelfNumber
            // 
            this.clmShelfNumber.HeaderText = "شماره قفسه";
            this.clmShelfNumber.Name = "clmShelfNumber";
            this.clmShelfNumber.ReadOnly = true;
            // 
            // clmCapacity
            // 
            this.clmCapacity.HeaderText = "ظرفیت قفسه";
            this.clmCapacity.Name = "clmCapacity";
            this.clmCapacity.ReadOnly = true;
            // 
            // clmUsedCapacity
            // 
            this.clmUsedCapacity.HeaderText = "فضای پر";
            this.clmUsedCapacity.Name = "clmUsedCapacity";
            this.clmUsedCapacity.ReadOnly = true;
            // 
            // clmAvailableCapacity
            // 
            this.clmAvailableCapacity.HeaderText = "فضای خالی";
            this.clmAvailableCapacity.Name = "clmAvailableCapacity";
            this.clmAvailableCapacity.ReadOnly = true;
            // 
            // txtShelfNumber
            // 
            this.txtShelfNumber.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShelfNumber.Location = new System.Drawing.Point(196, 58);
            this.txtShelfNumber.Name = "txtShelfNumber";
            this.txtShelfNumber.Size = new System.Drawing.Size(100, 29);
            this.txtShelfNumber.TabIndex = 1;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(196, 103);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(100, 29);
            this.txtCapacity.TabIndex = 2;
            // 
            // lblShelfNumber
            // 
            this.lblShelfNumber.AutoSize = true;
            this.lblShelfNumber.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShelfNumber.Location = new System.Drawing.Point(319, 58);
            this.lblShelfNumber.Name = "lblShelfNumber";
            this.lblShelfNumber.Size = new System.Drawing.Size(87, 22);
            this.lblShelfNumber.TabIndex = 3;
            this.lblShelfNumber.Text = "شماره قفسه :";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(337, 106);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(64, 22);
            this.lblCapacity.TabIndex = 4;
            this.lblCapacity.Text = "ظرفیت :";
            // 
            // btnAddShelf
            // 
            this.btnAddShelf.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShelf.Location = new System.Drawing.Point(17, 46);
            this.btnAddShelf.Name = "btnAddShelf";
            this.btnAddShelf.Size = new System.Drawing.Size(126, 82);
            this.btnAddShelf.TabIndex = 5;
            this.btnAddShelf.Text = "افزودن قفسه";
            this.btnAddShelf.UseVisualStyleBackColor = true;
            this.btnAddShelf.Click += new System.EventHandler(this.btnAddShelf_Click);
            // 
            // pnlAddShelf
            // 
            this.pnlAddShelf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddShelf.Controls.Add(this.lblAddShelf);
            this.pnlAddShelf.Controls.Add(this.txtShelfNumber);
            this.pnlAddShelf.Controls.Add(this.btnAddShelf);
            this.pnlAddShelf.Controls.Add(this.txtCapacity);
            this.pnlAddShelf.Controls.Add(this.lblCapacity);
            this.pnlAddShelf.Controls.Add(this.lblShelfNumber);
            this.pnlAddShelf.Location = new System.Drawing.Point(12, 182);
            this.pnlAddShelf.Name = "pnlAddShelf";
            this.pnlAddShelf.Size = new System.Drawing.Size(419, 173);
            this.pnlAddShelf.TabIndex = 6;
            // 
            // lblAddShelf
            // 
            this.lblAddShelf.AutoSize = true;
            this.lblAddShelf.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddShelf.Location = new System.Drawing.Point(175, 10);
            this.lblAddShelf.Name = "lblAddShelf";
            this.lblAddShelf.Size = new System.Drawing.Size(98, 24);
            this.lblAddShelf.TabIndex = 6;
            this.lblAddShelf.Text = "افزودن قفسه";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(191, 78);
            this.btnReturn.TabIndex = 24;
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
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "تازه سازی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tmrClock
            // 
            this.tmrClock.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblClock);
            this.panel1.Location = new System.Drawing.Point(931, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 100);
            this.panel1.TabIndex = 39;
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
            // btnBookInsert
            // 
            this.btnBookInsert.Location = new System.Drawing.Point(1035, 287);
            this.btnBookInsert.Name = "btnBookInsert";
            this.btnBookInsert.Size = new System.Drawing.Size(165, 64);
            this.btnBookInsert.TabIndex = 40;
            this.btnBookInsert.Text = "قرار دادن کتاب در قفسه";
            this.btnBookInsert.UseVisualStyleBackColor = true;
            this.btnBookInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShelfManagement
            // 
            this.btnShelfManagement.Location = new System.Drawing.Point(897, 287);
            this.btnShelfManagement.Name = "btnShelfManagement";
            this.btnShelfManagement.Size = new System.Drawing.Size(114, 64);
            this.btnShelfManagement.TabIndex = 41;
            this.btnShelfManagement.Text = "مدیریت قفسه";
            this.btnShelfManagement.UseVisualStyleBackColor = true;
            this.btnShelfManagement.Click += new System.EventHandler(this.btnShelfManagement_Click);
            // 
            // frmShelves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 720);
            this.Controls.Add(this.btnShelfManagement);
            this.Controls.Add(this.btnBookInsert);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pnlAddShelf);
            this.Controls.Add(this.dgvShelves);
            this.Name = "frmShelves";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "قفسه ها";
            this.Load += new System.EventHandler(this.frmShelves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelves)).EndInit();
            this.pnlAddShelf.ResumeLayout(false);
            this.pnlAddShelf.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShelves;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmShelfNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsedCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvailableCapacity;
        private System.Windows.Forms.TextBox txtShelfNumber;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblShelfNumber;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Button btnAddShelf;
        private System.Windows.Forms.Panel pnlAddShelf;
        private System.Windows.Forms.Label lblAddShelf;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Button btnBookInsert;
        private System.Windows.Forms.Button btnShelfManagement;
    }
}