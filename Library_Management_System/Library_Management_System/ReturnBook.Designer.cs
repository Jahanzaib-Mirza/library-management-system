namespace Library_Management_System
{
    partial class ReturnBook
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
            cbBookId = new System.Windows.Forms.ComboBox();
            lblBookId = new System.Windows.Forms.Label();
            cbStudentId = new System.Windows.Forms.ComboBox();
            label16 = new System.Windows.Forms.Label();
            btnReturnBook = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // cbBookId
            // 
            cbBookId.AllowDrop = true;
            cbBookId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbBookId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbBookId.FormattingEnabled = true;
            cbBookId.Location = new System.Drawing.Point(370, 178);
            cbBookId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbBookId.Name = "cbBookId";
            cbBookId.Size = new System.Drawing.Size(210, 33);
            cbBookId.TabIndex = 89;
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Location = new System.Drawing.Point(230, 178);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new System.Drawing.Size(113, 25);
            lblBookId.TabIndex = 88;
            lblBookId.Text = "Select Book :";
            // 
            // cbStudentId
            // 
            cbStudentId.AllowDrop = true;
            cbStudentId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbStudentId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbStudentId.FormattingEnabled = true;
            cbStudentId.Location = new System.Drawing.Point(370, 107);
            cbStudentId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbStudentId.Name = "cbStudentId";
            cbStudentId.Size = new System.Drawing.Size(210, 33);
            cbStudentId.TabIndex = 87;
            cbStudentId.SelectedIndexChanged += cbStudentId_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(220, 107);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(133, 25);
            label16.TabIndex = 86;
            label16.Text = "Select Student :";
            // 
            // btnReturnBook
            // 
            btnReturnBook.BackColor = System.Drawing.Color.DodgerBlue;
            btnReturnBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnReturnBook.Location = new System.Drawing.Point(359, 252);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new System.Drawing.Size(179, 44);
            btnReturnBook.TabIndex = 85;
            btnReturnBook.Text = "Return Book";
            btnReturnBook.UseVisualStyleBackColor = false;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Info;
            ClientSize = new System.Drawing.Size(800, 402);
            Controls.Add(cbBookId);
            Controls.Add(lblBookId);
            Controls.Add(cbStudentId);
            Controls.Add(label16);
            Controls.Add(btnReturnBook);
            Name = "ReturnBook";
            Text = "ReturnBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbBookId;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.ComboBox cbStudentId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnReturnBook;
    }
}