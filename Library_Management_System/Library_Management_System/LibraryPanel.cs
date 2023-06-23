using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class LibraryPanel : Form
    {
        DataTable studentData = new DataTable();
        private Librarian librarian;

        public LibraryPanel(int id, string name, string email, string password, string city, int salary)
        {
            InitializeComponent();
            librarian = new Librarian(id, name, email, password, city, salary);
            lblLibrarian.Text = name;
            getStudents();
            //MessageBox.Show(studentData.Rows[comboBox1.SelectedIndex]["StudentId"].ToString());

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        private void getStudents()
        {
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
                            comboBox1.Text = "Select Student";
                            //comboBox1.Items.Add("NOne");
                            comboBox1.SelectedIndex = -1;

                            //resetAll();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Enter data with correcttttt Data type");
                    }
                }
            }
        }

        private void btnSeeReport_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex > 0)
            {
                var id = studentData.Rows[comboBox1.SelectedIndex]["StudentId"];
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
                                librarianGridView.DataSource = dataTable;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Enter data with correct Data type");
                        }
                    }
                }
            }
            else MessageBox.Show("Select Student");

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedIndex < 0)
            //{
            //    comboBox1.Text = "Select Student";
            //}
            //else
            //{
            //    comboBox1.Text = comboBox1.SelectedText;
            //}
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var dataTable = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand($"exec LMS.dbo.getStats", sqlCon))
                {
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                            librarianGridView.DataSource = dataTable;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Enter data with correct Data type");
                    }
                }
            }
        }

        private void btnOpenIssue_Click(object sender, EventArgs e)
        {
            IssueBook form = new IssueBook(librarian.id);
            form.ShowDialog();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBook form = new ReturnBook(librarian.id);
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.librarian = null;
            Login form = new Login();
            form.ShowDialog();
            this.Close();
        }
    }
}
