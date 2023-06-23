namespace Library_Management_System
{
    partial class IssueBook
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
            cbStudentId = new System.Windows.Forms.ComboBox();
            label16 = new System.Windows.Forms.Label();
            btnIssueBook = new System.Windows.Forms.Button();
            cbBookId = new System.Windows.Forms.ComboBox();
            lblBookId = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // cbStudentId
            // 
            cbStudentId.AllowDrop = true;
            cbStudentId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbStudentId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbStudentId.FormattingEnabled = true;
            cbStudentId.Location = new System.Drawing.Point(361, 86);
            cbStudentId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbStudentId.Name = "cbStudentId";
            cbStudentId.Size = new System.Drawing.Size(210, 33);
            cbStudentId.TabIndex = 82;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(211, 86);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(133, 25);
            label16.TabIndex = 81;
            label16.Text = "Select Student :";
            // 
            // btnIssueBook
            // 
            btnIssueBook.BackColor = System.Drawing.Color.DodgerBlue;
            btnIssueBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnIssueBook.Location = new System.Drawing.Point(350, 231);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new System.Drawing.Size(179, 44);
            btnIssueBook.TabIndex = 80;
            btnIssueBook.Text = "Issue Book";
            btnIssueBook.UseVisualStyleBackColor = false;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // cbBookId
            // 
            cbBookId.AllowDrop = true;
            cbBookId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbBookId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbBookId.FormattingEnabled = true;
            cbBookId.Location = new System.Drawing.Point(361, 157);
            cbBookId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbBookId.Name = "cbBookId";
            cbBookId.Size = new System.Drawing.Size(210, 33);
            cbBookId.TabIndex = 84;
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Location = new System.Drawing.Point(221, 157);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new System.Drawing.Size(113, 25);
            lblBookId.TabIndex = 83;
            lblBookId.Text = "Select Book :";
            // 
            // IssueBook
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Info;
            ClientSize = new System.Drawing.Size(800, 371);
            Controls.Add(cbBookId);
            Controls.Add(lblBookId);
            Controls.Add(cbStudentId);
            Controls.Add(label16);
            Controls.Add(btnIssueBook);
            Name = "IssueBook";
            Text = "IssueBook";
            Load += IssueBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbStudentId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.ComboBox cbBookId;
        private System.Windows.Forms.Label lblBookId;
    }
}