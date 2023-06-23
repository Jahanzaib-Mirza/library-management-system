
namespace Library_Management_System
{
    partial class AdminBook
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
            label10 = new System.Windows.Forms.Label();
            btnRemove = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            btnUpdate = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            copies = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            price = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            edition = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            author = new System.Windows.Forms.TextBox();
            label18 = new System.Windows.Forms.Label();
            title = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(21, 12);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(259, 48);
            label10.TabIndex = 136;
            label10.Text = "Book Controls";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = System.Drawing.SystemColors.MenuHighlight;
            btnRemove.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnRemove.Location = new System.Drawing.Point(21, 373);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(203, 55);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Remove Book";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(93, 322);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(80, 25);
            label9.TabIndex = 134;
            label9.Text = "Book ID:";
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(199, 319);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(213, 31);
            txtId.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnUpdate.Location = new System.Drawing.Point(230, 373);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(337, 55);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update Book";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            btnAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnAdd.Location = new System.Drawing.Point(573, 373);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(206, 55);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add Book";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(364, 250);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(97, 25);
            label4.TabIndex = 124;
            label4.Text = "No of Cps:";
            // 
            // copies
            // 
            copies.Location = new System.Drawing.Point(470, 247);
            copies.Name = "copies";
            copies.Size = new System.Drawing.Size(309, 31);
            copies.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(364, 176);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(53, 25);
            label3.TabIndex = 120;
            label3.Text = "Price:";
            // 
            // price
            // 
            price.Location = new System.Drawing.Point(470, 173);
            price.Name = "price";
            price.Size = new System.Drawing.Size(309, 31);
            price.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(364, 213);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 25);
            label2.TabIndex = 118;
            label2.Text = "Edition:";
            // 
            // edition
            // 
            edition.Location = new System.Drawing.Point(470, 210);
            edition.Name = "edition";
            edition.Size = new System.Drawing.Size(309, 31);
            edition.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(364, 139);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 25);
            label1.TabIndex = 116;
            label1.Text = "Author:";
            // 
            // author
            // 
            author.Location = new System.Drawing.Point(470, 136);
            author.Name = "author";
            author.Size = new System.Drawing.Size(309, 31);
            author.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(364, 102);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(48, 25);
            label18.TabIndex = 114;
            label18.Text = "Title:";
            // 
            // title
            // 
            title.Location = new System.Drawing.Point(470, 99);
            title.Name = "title";
            title.Size = new System.Drawing.Size(309, 31);
            title.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            btnSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnSearch.Location = new System.Drawing.Point(418, 315);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(87, 38);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // AdminBook
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Info;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(label10);
            Controls.Add(btnRemove);
            Controls.Add(label9);
            Controls.Add(txtId);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(copies);
            Controls.Add(label3);
            Controls.Add(price);
            Controls.Add(label2);
            Controls.Add(edition);
            Controls.Add(label1);
            Controls.Add(author);
            Controls.Add(label18);
            Controls.Add(title);
            Name = "AdminBook";
            Text = "AdminBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox copies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button btnSearch;
    }
}