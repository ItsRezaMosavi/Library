namespace Library
{
    partial class frmBookManagement
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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.clmBookCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWriter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInShelfCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lblBookCode = new System.Windows.Forms.Label();
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.btnSearchByBookCode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchByBookName = new System.Windows.Forms.Button();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearchByWriter = new System.Windows.Forms.Button();
            this.txtWriterName = new System.Windows.Forms.TextBox();
            this.lblWriter = new System.Windows.Forms.Label();
            this.btnBookInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmBookCode,
            this.clmBookName,
            this.clmWriter,
            this.clmCount,
            this.clmInShelfCount});
            this.dgvBooks.Location = new System.Drawing.Point(1, 419);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.Size = new System.Drawing.Size(1247, 372);
            this.dgvBooks.TabIndex = 0;
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
            // clmWriter
            // 
            this.clmWriter.HeaderText = "نویسنده";
            this.clmWriter.Name = "clmWriter";
            this.clmWriter.ReadOnly = true;
            // 
            // clmCount
            // 
            this.clmCount.HeaderText = "تعداد کل";
            this.clmCount.Name = "clmCount";
            this.clmCount.ReadOnly = true;
            // 
            // clmInShelfCount
            // 
            this.clmInShelfCount.HeaderText = "تعداد کتاب ها در قفسه";
            this.clmInShelfCount.Name = "clmInShelfCount";
            this.clmInShelfCount.ReadOnly = true;
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
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(1037, 267);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(198, 71);
            this.btnAddBook.TabIndex = 25;
            this.btnAddBook.Text = "افزودن کتاب";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lblBookCode
            // 
            this.lblBookCode.AutoSize = true;
            this.lblBookCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCode.Location = new System.Drawing.Point(247, 15);
            this.lblBookCode.Name = "lblBookCode";
            this.lblBookCode.Size = new System.Drawing.Size(48, 18);
            this.lblBookCode.TabIndex = 26;
            this.lblBookCode.Text = "کد کتاب";
            // 
            // txtBookCode
            // 
            this.txtBookCode.Location = new System.Drawing.Point(167, 55);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.Size = new System.Drawing.Size(138, 20);
            this.txtBookCode.TabIndex = 27;
            // 
            // btnSearchByBookCode
            // 
            this.btnSearchByBookCode.Location = new System.Drawing.Point(12, 43);
            this.btnSearchByBookCode.Name = "btnSearchByBookCode";
            this.btnSearchByBookCode.Size = new System.Drawing.Size(140, 46);
            this.btnSearchByBookCode.TabIndex = 28;
            this.btnSearchByBookCode.Text = "جستجو کد کتاب";
            this.btnSearchByBookCode.UseVisualStyleBackColor = true;
            this.btnSearchByBookCode.Click += new System.EventHandler(this.btnSearchByBookCode_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSearchByBookCode);
            this.panel1.Controls.Add(this.lblBookCode);
            this.panel1.Controls.Add(this.txtBookCode);
            this.panel1.Location = new System.Drawing.Point(705, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 121);
            this.panel1.TabIndex = 29;
            // 
            // SearchByBookName
            // 
            this.SearchByBookName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByBookName.Location = new System.Drawing.Point(18, 36);
            this.SearchByBookName.Name = "SearchByBookName";
            this.SearchByBookName.Size = new System.Drawing.Size(137, 56);
            this.SearchByBookName.TabIndex = 30;
            this.SearchByBookName.Text = "جستجو نام کتاب";
            this.SearchByBookName.UseVisualStyleBackColor = true;
            this.SearchByBookName.Click += new System.EventHandler(this.SearchByBookName_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(173, 57);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(132, 32);
            this.txtBookName.TabIndex = 31;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(243, 17);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(66, 24);
            this.lblBookName.TabIndex = 32;
            this.lblBookName.Text = "نام کتاب";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.SearchByBookName);
            this.panel2.Controls.Add(this.lblBookName);
            this.panel2.Controls.Add(this.txtBookName);
            this.panel2.Location = new System.Drawing.Point(375, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 121);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearchByWriter);
            this.panel3.Controls.Add(this.txtWriterName);
            this.panel3.Controls.Add(this.lblWriter);
            this.panel3.Location = new System.Drawing.Point(50, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 121);
            this.panel3.TabIndex = 34;
            // 
            // btnSearchByWriter
            // 
            this.btnSearchByWriter.Location = new System.Drawing.Point(27, 38);
            this.btnSearchByWriter.Name = "btnSearchByWriter";
            this.btnSearchByWriter.Size = new System.Drawing.Size(126, 51);
            this.btnSearchByWriter.TabIndex = 2;
            this.btnSearchByWriter.Text = "جستجو نویسنده";
            this.btnSearchByWriter.UseVisualStyleBackColor = true;
            this.btnSearchByWriter.Click += new System.EventHandler(this.btnSearchByWriter_Click);
            // 
            // txtWriterName
            // 
            this.txtWriterName.Location = new System.Drawing.Point(191, 59);
            this.txtWriterName.Name = "txtWriterName";
            this.txtWriterName.Size = new System.Drawing.Size(100, 20);
            this.txtWriterName.TabIndex = 1;
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.Location = new System.Drawing.Point(243, 11);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(61, 13);
            this.lblWriter.TabIndex = 0;
            this.lblWriter.Text = "نام نویسنده";
            // 
            // btnBookInsert
            // 
            this.btnBookInsert.Location = new System.Drawing.Point(1037, 168);
            this.btnBookInsert.Name = "btnBookInsert";
            this.btnBookInsert.Size = new System.Drawing.Size(145, 73);
            this.btnBookInsert.TabIndex = 35;
            this.btnBookInsert.Text = "قرار دادن در قفسه";
            this.btnBookInsert.UseVisualStyleBackColor = true;
            this.btnBookInsert.Click += new System.EventHandler(this.btnBookInsert_Click);
            // 
            // frmBookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 791);
            this.Controls.Add(this.btnBookInsert);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvBooks);
            this.Name = "frmBookManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت کتاب ها";
            this.Load += new System.EventHandler(this.frmBookManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBookCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWriter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInShelfCount;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lblBookCode;
        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.Button btnSearchByBookCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchByBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearchByWriter;
        private System.Windows.Forms.TextBox txtWriterName;
        private System.Windows.Forms.Label lblWriter;
        private System.Windows.Forms.Button btnBookInsert;
    }
}