using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System
{
    public partial class StudentProfile : Form
    {
        private Student student;
        private const string searchBooks = "EXEC LMS.dbo.SearchBookByTitle @text";
        public StudentProfile(int id, string name, string email, string password, string department, string semester, string city)
        {
            InitializeComponent();
            student = new Student(id, name, email, password, department, semester, city);
            getBookData(id);
            DisplayProfile();
        }

        private void DisplayProfile()
        {
            idLabel.Text = (student.id).ToString();
            nameLabel.Text = student.name;
            emailLabel.Text = student.email;
            passLabel.Text = student.password;
            dptLabel.Text = student.department;
            semLabel.Text = student.semester;
            CityLabel.Text = student.city;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.student = null;
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
        public void getBookData(int id)
        {
            var dataTable = new DataTable();

            using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand($"exec LMS.dbo.getStudentBooks {id}", sqlCon))
                {
                    try
                    {

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                            booksGridView.DataSource = dataTable;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Enter data with correct Data type");
                    }
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var dataTable = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand(searchBooks, sqlCon))
                {
                    command.Parameters.AddWithValue("@text", textInput.Text);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        if (dataTable.Rows.Count > 0) booksGridView.DataSource = dataTable;
                        else MessageBox.Show("No Book Found");


                    }
                }
            }
        }
    }
}
