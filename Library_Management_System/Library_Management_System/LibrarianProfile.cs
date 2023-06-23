using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class LibrarianProfile : Form
    {
        DataTable studentData = new DataTable();
        private Librarian librarian;
        string issueBook = "EXEC LMS.dbo.GenerateReport @bookId,@studentId,@librarianId";
        string returnBook = "EXEC LMS.dbo.ReturnBook @reportId";
        public LibrarianProfile(int id, string name, string email, string password, string city, int salary)
        {
            InitializeComponent();
            librarian = new Librarian(id, name, email, password, city, salary);
            DisplayProfile();
            using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("select concat(StudentName, \' \' , StudentID) as StudentName,StudentID from LMS.dbo.Students", sqlCon))
                {
                    try
                    {

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(studentData);
                            comboBox1.DataSource = studentData;
                            comboBox1.DisplayMember = "StudentName";
                            resetAll();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Enter data with correct Data type");
                    }
                }
            }

        }
        private void DisplayProfile()
        {
            id.Text = (librarian.id).ToString();
            name.Text = librarian.name;
            email.Text = librarian.email;
            pass.Text = librarian.password;
            city.Text = librarian.city;
            salary.Text = (librarian.salary).ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.librarian = null;
            Login form = new Login();
            form.ShowDialog();
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (txtBookId.Text != "" && txtStdId.Text != "")
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(issueBook, sqlCon))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@bookId", int.Parse(txtBookId.Text));
                            command.Parameters.AddWithValue("@StudentId", int.Parse(txtStdId.Text));
                            command.Parameters.AddWithValue("@librarianId", librarian.id);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                                resetAll();
                                MessageBox.Show("Book Issued");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Enter data with correct Data type");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Some credentials are missing");
            }
        }
        private void resetAll()
        {
            txtStdId.Text = "";
            txtStdIdP.Text = "";
            txtBookId.Text = "";
            txtReportId.Text = "";

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (txtReportId.Text != "")
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(returnBook, sqlCon))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@reportId", int.Parse(txtReportId.Text));
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                                MessageBox.Show("Book with ID:");
                                resetAll();
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Enter data with correct Data type");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Some credentials are missing");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(studentData.Rows[comboBox1.SelectedIndex]["StudentId"].ToString());
        }

        private void btnOpenPanel_Click(object sender, EventArgs e)
        {
           // LibraryPanel form = new LibraryPanel();
            //form.ShowDialog();
        }
    }
}
