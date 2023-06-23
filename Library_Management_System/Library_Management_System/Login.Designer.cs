
namespace Library_Management_System
{
    partial class Login
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
            usernameLabel = new System.Windows.Forms.Label();
            usernameInput = new System.Windows.Forms.TextBox();
            passwordInput = new System.Windows.Forms.TextBox();
            passwordLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            loginButton = new System.Windows.Forms.Button();
            adminRadio = new System.Windows.Forms.RadioButton();
            studentRadio = new System.Windows.Forms.RadioButton();
            librarianRadio = new System.Windows.Forms.RadioButton();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(242, 126);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(91, 25);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            // 
            // usernameInput
            // 
            usernameInput.Location = new System.Drawing.Point(242, 154);
            usernameInput.Name = "usernameInput";
            usernameInput.PlaceholderText = "Enter Username";
            usernameInput.Size = new System.Drawing.Size(309, 31);
            usernameInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            passwordInput.Location = new System.Drawing.Point(242, 216);
            passwordInput.Name = "passwordInput";
            passwordInput.PlaceholderText = "Enter Password";
            passwordInput.Size = new System.Drawing.Size(309, 31);
            passwordInput.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(242, 188);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(87, 25);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            loginLabel.Location = new System.Drawing.Point(303, 52);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(180, 74);
            loginLabel.TabIndex = 4;
            loginLabel.Text = "Login";
            // 
            // loginButton
            // 
            loginButton.BackColor = System.Drawing.Color.DodgerBlue;
            loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            loginButton.ForeColor = System.Drawing.SystemColors.Window;
            loginButton.Location = new System.Drawing.Point(242, 329);
            loginButton.Name = "loginButton";
            loginButton.Size = new System.Drawing.Size(309, 54);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // adminRadio
            // 
            adminRadio.AutoSize = true;
            adminRadio.Location = new System.Drawing.Point(243, 253);
            adminRadio.Name = "adminRadio";
            adminRadio.Size = new System.Drawing.Size(90, 29);
            adminRadio.TabIndex = 10;
            adminRadio.Text = "Admin";
            adminRadio.UseVisualStyleBackColor = true;
            // 
            // studentRadio
            // 
            studentRadio.AutoSize = true;
            studentRadio.Checked = true;
            studentRadio.Location = new System.Drawing.Point(361, 253);
            studentRadio.Name = "studentRadio";
            studentRadio.Size = new System.Drawing.Size(98, 29);
            studentRadio.TabIndex = 11;
            studentRadio.TabStop = true;
            studentRadio.Text = "Student";
            studentRadio.UseVisualStyleBackColor = true;
            // 
            // librarianRadio
            // 
            librarianRadio.AutoSize = true;
            librarianRadio.Location = new System.Drawing.Point(465, 253);
            librarianRadio.Name = "librarianRadio";
            librarianRadio.Size = new System.Drawing.Size(104, 29);
            librarianRadio.TabIndex = 12;
            librarianRadio.Text = "Librarian";
            librarianRadio.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Info;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(librarianRadio);
            Controls.Add(studentRadio);
            Controls.Add(adminRadio);
            Controls.Add(loginButton);
            Controls.Add(loginLabel);
            Controls.Add(passwordInput);
            Controls.Add(passwordLabel);
            Controls.Add(usernameInput);
            Controls.Add(usernameLabel);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.RadioButton adminRadio;
        private System.Windows.Forms.RadioButton studentRadio;
        private System.Windows.Forms.RadioButton librarianRadio;
    }
}