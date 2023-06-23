namespace Library_Management_System
{
    partial class LibraryPanel
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
            librarianGridView = new System.Windows.Forms.DataGridView();
            btnSeeReport = new System.Windows.Forms.Button();
            btnOpenIssue = new System.Windows.Forms.Button();
            btnReturnBook = new System.Windows.Forms.Button();
            label16 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            btnGenerateReport = new System.Windows.Forms.Button();
            lblLibrarian = new System.Windows.Forms.Label();
            btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)librarianGridView).BeginInit();
            SuspendLayout();
            // 
            // librarianGridView
            // 
            librarianGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            librarianGridView.Location = new System.Drawing.Point(2, 2);
            librarianGridView.Name = "librarianGridView";
            librarianGridView.RowHeadersWidth = 62;
            librarianGridView.RowTemplate.Height = 33;
            librarianGridView.Size = new System.Drawing.Size(950, 446);
            librarianGridView.TabIndex = 0;
            // 
            // btnSeeReport
            // 
            btnSeeReport.BackColor = System.Drawing.Color.DarkSlateGray;
            btnSeeReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnSeeReport.Location = new System.Drawing.Point(997, 163);
            btnSeeReport.Name = "btnSeeReport";
            btnSeeReport.Size = new System.Drawing.Size(179, 44);
            btnSeeReport.TabIndex = 74;
            btnSeeReport.Text = "Get";
            btnSeeReport.UseVisualStyleBackColor = false;
            btnSeeReport.Click += btnSeeReport_Click;
            // 
            // btnOpenIssue
            // 
            btnOpenIssue.BackColor = System.Drawing.SystemColors.Highlight;
            btnOpenIssue.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnOpenIssue.Location = new System.Drawing.Point(997, 226);
            btnOpenIssue.Name = "btnOpenIssue";
            btnOpenIssue.Size = new System.Drawing.Size(179, 42);
            btnOpenIssue.TabIndex = 75;
            btnOpenIssue.Text = "Issue Books";
            btnOpenIssue.UseVisualStyleBackColor = false;
            btnOpenIssue.Click += btnOpenIssue_Click;
            // 
            // btnReturnBook
            // 
            btnReturnBook.BackColor = System.Drawing.SystemColors.Highlight;
            btnReturnBook.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnReturnBook.Location = new System.Drawing.Point(997, 287);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new System.Drawing.Size(179, 42);
            btnReturnBook.TabIndex = 76;
            btnReturnBook.Text = "Return Books";
            btnReturnBook.UseVisualStyleBackColor = false;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(971, 92);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(133, 25);
            label16.TabIndex = 78;
            label16.Text = "Select Student :";
            label16.Click += label16_Click;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(980, 122);
            comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(210, 33);
            comboBox1.TabIndex = 79;
            comboBox1.TextChanged += comboBox1_TextChanged;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = System.Drawing.SystemColors.Highlight;
            btnGenerateReport.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnGenerateReport.Location = new System.Drawing.Point(997, 353);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new System.Drawing.Size(179, 42);
            btnGenerateReport.TabIndex = 80;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // lblLibrarian
            // 
            lblLibrarian.AutoSize = true;
            lblLibrarian.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblLibrarian.Location = new System.Drawing.Point(958, 9);
            lblLibrarian.Name = "lblLibrarian";
            lblLibrarian.Size = new System.Drawing.Size(200, 26);
            lblLibrarian.TabIndex = 81;
            lblLibrarian.Text = "Select Student :";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.Red;
            btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogout.ForeColor = System.Drawing.SystemColors.Window;
            btnLogout.Location = new System.Drawing.Point(997, 401);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(179, 47);
            btnLogout.TabIndex = 82;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // LibraryPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Info;
            ClientSize = new System.Drawing.Size(1234, 450);
            Controls.Add(btnLogout);
            Controls.Add(lblLibrarian);
            Controls.Add(btnGenerateReport);
            Controls.Add(comboBox1);
            Controls.Add(label16);
            Controls.Add(btnReturnBook);
            Controls.Add(btnOpenIssue);
            Controls.Add(btnSeeReport);
            Controls.Add(librarianGridView);
            Name = "LibraryPanel";
            Text = "LibraryPanel";
            ((System.ComponentModel.ISupportInitialize)librarianGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView librarianGridView;
        private System.Windows.Forms.Button btnSeeReport;
        private System.Windows.Forms.Button btnOpenIssue;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label lblLibrarian;
        private System.Windows.Forms.Button btnLogout;
    }
}