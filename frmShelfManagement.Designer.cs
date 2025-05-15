namespace Library
{
    partial class frmShelfManagement
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
            this.lblShelfNumber = new System.Windows.Forms.Label();
            this.cmbShelfNumber = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlShelf = new System.Windows.Forms.Panel();
            this.lblShelfNum = new System.Windows.Forms.Label();
            this.txtShelfNumber = new System.Windows.Forms.TextBox();
            this.lblShelfCapacity = new System.Windows.Forms.Label();
            this.lblUsedCapacity = new System.Windows.Forms.Label();
            this.lblAvailableCapacity = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtUsedCapacity = new System.Windows.Forms.TextBox();
            this.txtAvailableCapacity = new System.Windows.Forms.TextBox();
            this.dgvShelf = new System.Windows.Forms.DataGridView();
            this.clmBookCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlShelf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelf)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShelfNumber
            // 
            this.lblShelfNumber.AutoSize = true;
            this.lblShelfNumber.Location = new System.Drawing.Point(1006, 59);
            this.lblShelfNumber.Name = "lblShelfNumber";
            this.lblShelfNumber.Size = new System.Drawing.Size(64, 13);
            this.lblShelfNumber.TabIndex = 0;
            this.lblShelfNumber.Text = "شماره قفسه";
            // 
            // cmbShelfNumber
            // 
            this.cmbShelfNumber.FormattingEnabled = true;
            this.cmbShelfNumber.Location = new System.Drawing.Point(868, 56);
            this.cmbShelfNumber.Name = "cmbShelfNumber";
            this.cmbShelfNumber.Size = new System.Drawing.Size(121, 21);
            this.cmbShelfNumber.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(718, 47);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(115, 36);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "انتخاب قفسه";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pnlShelf
            // 
            this.pnlShelf.Controls.Add(this.txtAvailableCapacity);
            this.pnlShelf.Controls.Add(this.txtUsedCapacity);
            this.pnlShelf.Controls.Add(this.txtCapacity);
            this.pnlShelf.Controls.Add(this.lblAvailableCapacity);
            this.pnlShelf.Controls.Add(this.lblUsedCapacity);
            this.pnlShelf.Controls.Add(this.lblShelfCapacity);
            this.pnlShelf.Controls.Add(this.txtShelfNumber);
            this.pnlShelf.Controls.Add(this.lblShelfNum);
            this.pnlShelf.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlShelf.Location = new System.Drawing.Point(12, 149);
            this.pnlShelf.Name = "pnlShelf";
            this.pnlShelf.Size = new System.Drawing.Size(1083, 90);
            this.pnlShelf.TabIndex = 3;
            // 
            // lblShelfNum
            // 
            this.lblShelfNum.AutoSize = true;
            this.lblShelfNum.Location = new System.Drawing.Point(977, 37);
            this.lblShelfNum.Name = "lblShelfNum";
            this.lblShelfNum.Size = new System.Drawing.Size(99, 24);
            this.lblShelfNum.TabIndex = 0;
            this.lblShelfNum.Text = "شماره قفسه :";
            // 
            // txtShelfNumber
            // 
            this.txtShelfNumber.Location = new System.Drawing.Point(871, 33);
            this.txtShelfNumber.Name = "txtShelfNumber";
            this.txtShelfNumber.Size = new System.Drawing.Size(100, 32);
            this.txtShelfNumber.TabIndex = 1;
            // 
            // lblShelfCapacity
            // 
            this.lblShelfCapacity.AutoSize = true;
            this.lblShelfCapacity.Location = new System.Drawing.Point(706, 37);
            this.lblShelfCapacity.Name = "lblShelfCapacity";
            this.lblShelfCapacity.Size = new System.Drawing.Size(107, 24);
            this.lblShelfCapacity.TabIndex = 2;
            this.lblShelfCapacity.Text = "ظرفیت قفسه :";
            // 
            // lblUsedCapacity
            // 
            this.lblUsedCapacity.AutoSize = true;
            this.lblUsedCapacity.Location = new System.Drawing.Point(412, 37);
            this.lblUsedCapacity.Name = "lblUsedCapacity";
            this.lblUsedCapacity.Size = new System.Drawing.Size(91, 24);
            this.lblUsedCapacity.TabIndex = 3;
            this.lblUsedCapacity.Text = "ظرفیت پر :";
            // 
            // lblAvailableCapacity
            // 
            this.lblAvailableCapacity.AutoSize = true;
            this.lblAvailableCapacity.Location = new System.Drawing.Point(129, 37);
            this.lblAvailableCapacity.Name = "lblAvailableCapacity";
            this.lblAvailableCapacity.Size = new System.Drawing.Size(102, 24);
            this.lblAvailableCapacity.TabIndex = 4;
            this.lblAvailableCapacity.Text = "فضای خالی :";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(600, 33);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(100, 32);
            this.txtCapacity.TabIndex = 5;
            // 
            // txtUsedCapacity
            // 
            this.txtUsedCapacity.Location = new System.Drawing.Point(306, 33);
            this.txtUsedCapacity.Name = "txtUsedCapacity";
            this.txtUsedCapacity.Size = new System.Drawing.Size(100, 32);
            this.txtUsedCapacity.TabIndex = 6;
            // 
            // txtAvailableCapacity
            // 
            this.txtAvailableCapacity.Location = new System.Drawing.Point(21, 33);
            this.txtAvailableCapacity.Name = "txtAvailableCapacity";
            this.txtAvailableCapacity.Size = new System.Drawing.Size(100, 32);
            this.txtAvailableCapacity.TabIndex = 7;
            // 
            // dgvShelf
            // 
            this.dgvShelf.AllowUserToAddRows = false;
            this.dgvShelf.AllowUserToDeleteRows = false;
            this.dgvShelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShelf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmBookCode,
            this.clmBookName,
            this.clmBookCount});
            this.dgvShelf.Location = new System.Drawing.Point(0, 312);
            this.dgvShelf.Name = "dgvShelf";
            this.dgvShelf.ReadOnly = true;
            this.dgvShelf.Size = new System.Drawing.Size(1120, 373);
            this.dgvShelf.TabIndex = 4;
            // 
            // clmBookCode
            // 
            this.clmBookCode.HeaderText = "کد کتاب";
            this.clmBookCode.Name = "clmBookCode";
            this.clmBookCode.ReadOnly = true;
            // 
            // clmBookName
            // 
            this.clmBookName.HeaderText = "نام کتاب";
            this.clmBookName.Name = "clmBookName";
            this.clmBookName.ReadOnly = true;
            // 
            // clmBookCount
            // 
            this.clmBookCount.HeaderText = "تعداد";
            this.clmBookCount.Name = "clmBookCount";
            this.clmBookCount.ReadOnly = true;
            // 
            // frmShelfManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 685);
            this.Controls.Add(this.dgvShelf);
            this.Controls.Add(this.pnlShelf);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cmbShelfNumber);
            this.Controls.Add(this.lblShelfNumber);
            this.Name = "frmShelfManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت قفسه";
            this.Load += new System.EventHandler(this.frmShelfManagement_Load);
            this.pnlShelf.ResumeLayout(false);
            this.pnlShelf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShelfNumber;
        private System.Windows.Forms.ComboBox cmbShelfNumber;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel pnlShelf;
        private System.Windows.Forms.Label lblShelfNum;
        private System.Windows.Forms.TextBox txtShelfNumber;
        private System.Windows.Forms.TextBox txtAvailableCapacity;
        private System.Windows.Forms.TextBox txtUsedCapacity;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblAvailableCapacity;
        private System.Windows.Forms.Label lblUsedCapacity;
        private System.Windows.Forms.Label lblShelfCapacity;
        private System.Windows.Forms.DataGridView dgvShelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBookCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBookCount;
    }
}