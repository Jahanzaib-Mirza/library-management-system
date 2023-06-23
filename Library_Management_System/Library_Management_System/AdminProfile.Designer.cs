
using System;

namespace Library_Management_System
{
    partial class AdminProfile
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
            btnAdmin = new System.Windows.Forms.Button();
            dataGridView = new System.Windows.Forms.DataGridView();
            btnLogout = new System.Windows.Forms.Button();
            btnStudent = new System.Windows.Forms.Button();
            btnLibrarian = new System.Windows.Forms.Button();
            btnMngStudent = new System.Windows.Forms.Button();
            rtrdateLabel = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            hrdateLabel = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            dsgntnLabel = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            passLabel = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnBook = new System.Windows.Forms.Button();
            btnMngBook = new System.Windows.Forms.Button();
            btnGenerateReport = new System.Windows.Forms.Button();
            btnBookHistort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            btnAdmin.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnAdmin.Location = new System.Drawing.Point(12, 12);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new System.Drawing.Size(179, 42);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "See Admins";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new System.Drawing.Point(197, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new System.Drawing.Size(591, 420);
            dataGridView.TabIndex = 6;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.Red;
            btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogout.ForeColor = System.Drawing.SystemColors.Window;
            btnLogout.Location = new System.Drawing.Point(12, 386);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(112, 46);
            btnLogout.TabIndex = 44;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = System.Drawing.SystemColors.Highlight;
            btnStudent.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnStudent.Location = new System.Drawing.Point(12, 60);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new System.Drawing.Size(179, 42);
            btnStudent.TabIndex = 45;
            btnStudent.Text = "See Students";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnLibrarian
            // 
            btnLibrarian.BackColor = System.Drawing.SystemColors.Highlight;
            btnLibrarian.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnLibrarian.Location = new System.Drawing.Point(12, 108);
            btnLibrarian.Name = "btnLibrarian";
            btnLibrarian.Size = new System.Drawing.Size(179, 42);
            btnLibrarian.TabIndex = 46;
            btnLibrarian.Text = "See Librarians";
            btnLibrarian.UseVisualStyleBackColor = false;
            btnLibrarian.Click += btnLibrarian_Click;
            // 
            // btnMngStudent
            // 
            btnMngStudent.BackColor = System.Drawing.Color.DarkOrange;
            btnMngStudent.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnMngStudent.Location = new System.Drawing.Point(12, 250);
            btnMngStudent.Name = "btnMngStudent";
            btnMngStudent.Size = new System.Drawing.Size(179, 40);
            btnMngStudent.TabIndex = 48;
            btnMngStudent.Text = "Manage Students";
            btnMngStudent.UseVisualStyleBackColor = false;
            btnMngStudent.Click += btnMngStudent_Click;
            // 
            // rtrdateLabel
            // 
            rtrdateLabel.AutoSize = true;
            rtrdateLabel.Location = new System.Drawing.Point(990, 303);
            rtrdateLabel.Name = "rtrdateLabel";
            rtrdateLabel.Size = new System.Drawing.Size(120, 25);
            rtrdateLabel.TabIndex = 65;
            rtrdateLabel.Text = "StudentName";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(907, 303);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(76, 25);
            label15.TabIndex = 64;
            label15.Text = "RtrDate:";
            // 
            // hrdateLabel
            // 
            hrdateLabel.AutoSize = true;
            hrdateLabel.Location = new System.Drawing.Point(990, 269);
            hrdateLabel.Name = "hrdateLabel";
            hrdateLabel.Size = new System.Drawing.Size(120, 25);
            hrdateLabel.TabIndex = 63;
            hrdateLabel.Text = "StudentName";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(907, 269);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(72, 25);
            label9.TabIndex = 62;
            label9.Text = "HrDate:";
            // 
            // dsgntnLabel
            // 
            dsgntnLabel.AutoSize = true;
            dsgntnLabel.Location = new System.Drawing.Point(990, 235);
            dsgntnLabel.Name = "dsgntnLabel";
            dsgntnLabel.Size = new System.Drawing.Size(120, 25);
            dsgntnLabel.TabIndex = 61;
            dsgntnLabel.Text = "StudentName";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(907, 235);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(74, 25);
            label11.TabIndex = 60;
            label11.Text = "Dsgntn:";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new System.Drawing.Point(990, 201);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(120, 25);
            passLabel.TabIndex = 59;
            passLabel.Text = "StudentName";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(907, 201);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(74, 25);
            label13.TabIndex = 58;
            label13.Text = "Passwd:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(990, 170);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(120, 25);
            emailLabel.TabIndex = 57;
            emailLabel.Text = "StudentName";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(907, 170);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(58, 25);
            label7.TabIndex = 56;
            label7.Text = "Email:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(990, 136);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(120, 25);
            nameLabel.TabIndex = 55;
            nameLabel.Text = "StudentName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(907, 136);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 25);
            label3.TabIndex = 54;
            label3.Text = "Name:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(990, 102);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(96, 25);
            idLabel.TabIndex = 53;
            idLabel.Text = "Student ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(907, 102);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(32, 25);
            label5.TabIndex = 52;
            label5.Text = "Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(874, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(282, 54);
            label1.TabIndex = 51;
            label1.Text = "Admin Profile";
            // 
            // btnBook
            // 
            btnBook.BackColor = System.Drawing.Color.DarkSlateGray;
            btnBook.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnBook.Location = new System.Drawing.Point(802, 390);
            btnBook.Name = "btnBook";
            btnBook.Size = new System.Drawing.Size(179, 42);
            btnBook.TabIndex = 66;
            btnBook.Text = "See Books";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnMngBook
            // 
            btnMngBook.BackColor = System.Drawing.SystemColors.InfoText;
            btnMngBook.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnMngBook.Location = new System.Drawing.Point(990, 390);
            btnMngBook.Name = "btnMngBook";
            btnMngBook.Size = new System.Drawing.Size(232, 42);
            btnMngBook.TabIndex = 67;
            btnMngBook.Text = "Manage Books Data";
            btnMngBook.UseVisualStyleBackColor = false;
            btnMngBook.Click += btnMngBook_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = System.Drawing.SystemColors.Highlight;
            btnGenerateReport.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnGenerateReport.Location = new System.Drawing.Point(12, 156);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new System.Drawing.Size(179, 42);
            btnGenerateReport.TabIndex = 68;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnBookHistort
            // 
            btnBookHistort.BackColor = System.Drawing.SystemColors.Highlight;
            btnBookHistort.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnBookHistort.Location = new System.Drawing.Point(12, 204);
            btnBookHistort.Name = "btnBookHistort";
            btnBookHistort.Size = new System.Drawing.Size(179, 42);
            btnBookHistort.TabIndex = 70;
            btnBookHistort.Text = "Book Catalog";
            btnBookHistort.UseVisualStyleBackColor = false;
            btnBookHistort.Click += btnBookHistort_Click;
            // 
            // AdminProfile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Info;
            ClientSize = new System.Drawing.Size(1234, 450);
            Controls.Add(btnBookHistort);
            Controls.Add(btnGenerateReport);
            Controls.Add(btnMngBook);
            Controls.Add(btnBook);
            Controls.Add(rtrdateLabel);
            Controls.Add(label15);
            Controls.Add(hrdateLabel);
            Controls.Add(label9);
            Controls.Add(dsgntnLabel);
            Controls.Add(label11);
            Controls.Add(passLabel);
            Controls.Add(label13);
            Controls.Add(emailLabel);
            Controls.Add(label7);
            Controls.Add(nameLabel);
            Controls.Add(label3);
            Controls.Add(idLabel);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnMngStudent);
            Controls.Add(btnLibrarian);
            Controls.Add(btnStudent);
            Controls.Add(btnLogout);
            Controls.Add(dataGridView);
            Controls.Add(btnAdmin);
            Name = "AdminProfile";
            Text = "AdminProfile";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnLibrarian;
        private System.Windows.Forms.Button btnMngStudent;
        private System.Windows.Forms.Label rtrdateLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label hrdateLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dsgntnLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnMngBook;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnBookHistort;
    }
}