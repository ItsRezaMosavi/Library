namespace Library
{
    partial class frmBookShelfMapping
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
            this.lblBookCode = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblWriter = new System.Windows.Forms.Label();
            this.cmbBookCode = new System.Windows.Forms.ComboBox();
            this.cmbBookName = new System.Windows.Forms.ComboBox();
            this.cmbWriter = new System.Windows.Forms.ComboBox();
            this.cmbShelfNumber = new System.Windows.Forms.ComboBox();
            this.lblShelfNumber = new System.Windows.Forms.Label();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.pnlBook.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBookCode
            // 
            this.lblBookCode.AutoSize = true;
            this.lblBookCode.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCode.Location = new System.Drawing.Point(217, 50);
            this.lblBookCode.Name = "lblBookCode";
            this.lblBookCode.Size = new System.Drawing.Size(57, 22);
            this.lblBookCode.TabIndex = 3;
            this.lblBookCode.Text = "کد کتاب";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(226, 96);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(64, 22);
            this.lblBookName.TabIndex = 4;
            this.lblBookName.Text = "نام کتاب ";
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriter.Location = new System.Drawing.Point(226, 152);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(81, 22);
            this.lblWriter.TabIndex = 5;
            this.lblWriter.Text = "نام نویسنده";
            // 
            // cmbBookCode
            // 
            this.cmbBookCode.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBookCode.FormattingEnabled = true;
            this.cmbBookCode.Location = new System.Drawing.Point(42, 47);
            this.cmbBookCode.Name = "cmbBookCode";
            this.cmbBookCode.Size = new System.Drawing.Size(121, 30);
            this.cmbBookCode.TabIndex = 6;
            this.cmbBookCode.SelectedValueChanged += new System.EventHandler(this.cmbBookCode_SelectedValueChanged);
            // 
            // cmbBookName
            // 
            this.cmbBookName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBookName.FormattingEnabled = true;
            this.cmbBookName.Location = new System.Drawing.Point(42, 93);
            this.cmbBookName.Name = "cmbBookName";
            this.cmbBookName.Size = new System.Drawing.Size(121, 30);
            this.cmbBookName.TabIndex = 7;
            this.cmbBookName.SelectedValueChanged += new System.EventHandler(this.cmbBookName_SelectedValueChanged);
            // 
            // cmbWriter
            // 
            this.cmbWriter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWriter.FormattingEnabled = true;
            this.cmbWriter.Location = new System.Drawing.Point(42, 144);
            this.cmbWriter.Name = "cmbWriter";
            this.cmbWriter.Size = new System.Drawing.Size(121, 30);
            this.cmbWriter.TabIndex = 8;
            this.cmbWriter.SelectedValueChanged += new System.EventHandler(this.cmbWriter_SelectedValueChanged);
            // 
            // cmbShelfNumber
            // 
            this.cmbShelfNumber.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShelfNumber.FormattingEnabled = true;
            this.cmbShelfNumber.Location = new System.Drawing.Point(97, 213);
            this.cmbShelfNumber.Name = "cmbShelfNumber";
            this.cmbShelfNumber.Size = new System.Drawing.Size(130, 30);
            this.cmbShelfNumber.TabIndex = 9;
            // 
            // lblShelfNumber
            // 
            this.lblShelfNumber.AutoSize = true;
            this.lblShelfNumber.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShelfNumber.Location = new System.Drawing.Point(258, 216);
            this.lblShelfNumber.Name = "lblShelfNumber";
            this.lblShelfNumber.Size = new System.Drawing.Size(86, 22);
            this.lblShelfNumber.TabIndex = 10;
            this.lblShelfNumber.Text = "شماره قفسه";
            // 
            // pnlBook
            // 
            this.pnlBook.Controls.Add(this.btnSelect);
            this.pnlBook.Controls.Add(this.cmbBookCode);
            this.pnlBook.Controls.Add(this.lblBookCode);
            this.pnlBook.Controls.Add(this.lblBookName);
            this.pnlBook.Controls.Add(this.cmbWriter);
            this.pnlBook.Controls.Add(this.lblWriter);
            this.pnlBook.Controls.Add(this.cmbBookName);
            this.pnlBook.Location = new System.Drawing.Point(425, 165);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(332, 250);
            this.pnlBook.TabIndex = 11;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(138, 211);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "انتخاب";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(174, 343);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(115, 56);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "قرار دادن";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(291, 277);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(52, 22);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = "تعداد :";
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(97, 274);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(130, 29);
            this.txtCount.TabIndex = 14;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(191, 78);
            this.btnReturn.TabIndex = 26;
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
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "تازه سازی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblClock);
            this.panel1.Location = new System.Drawing.Point(563, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 100);
            this.panel1.TabIndex = 38;
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
            // frmBookShelfMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.pnlBook);
            this.Controls.Add(this.lblShelfNumber);
            this.Controls.Add(this.cmbShelfNumber);
            this.Name = "frmBookShelfMapping";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmBookShelfMapping";
            this.Load += new System.EventHandler(this.frmBookShelfMapping_Load);
            this.pnlBook.ResumeLayout(false);
            this.pnlBook.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookCode;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblWriter;
        private System.Windows.Forms.ComboBox cmbBookCode;
        private System.Windows.Forms.ComboBox cmbBookName;
        private System.Windows.Forms.ComboBox cmbWriter;
        private System.Windows.Forms.ComboBox cmbShelfNumber;
        private System.Windows.Forms.Label lblShelfNumber;
        private System.Windows.Forms.Panel pnlBook;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClock;
    }
}