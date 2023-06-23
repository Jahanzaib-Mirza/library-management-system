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
    public partial class IssueBook : Form
    {
        private int librarianId;
        DataTable studentData = new DataTable();
        DataTable BookData = new DataTable();
        string issueBook = "EXEC LMS.dbo.GenerateReport @bookId,@studentId,@librarianId";

        //public IssueBook()
        //{


        //}
        public IssueBook(int id)
        {
            this.librarianId = id;
            InitializeComponent();
            getStudents();
            getBooks();
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
                            cbStudentId.DataSource = studentData;
                            cbStudentId.DisplayMember = "StudentName";
                            cbStudentId.Text = "Select Student";
                            //comboBox1.Items.Add("NOne");
                            cbStudentId.SelectedIndex = -1;

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
        private void getBooks()
        {
            using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("select concat(BookTitle, \' \' , BookID) as BookName,BookID from LMS.dbo.BOOKS", sqlCon))
                {
                    try
                    {

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(BookData);
                            cbBookId.DataSource = BookData;
                            cbBookId.DisplayMember = "BookName";
                            cbBookId.Text = "Select Book";
                            //comboBox1.Items.Add("NOne");
                            cbBookId.SelectedIndex = -1;

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

        private void IssueBook_Load(object sender, EventArgs e)
        {

        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (cbBookId.SelectedIndex > 0 && cbStudentId.SelectedIndex >0)
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(issueBook, sqlCon))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@bookId", BookData.Rows[cbBookId.SelectedIndex]["BookId"]);
                            command.Parameters.AddWithValue("@StudentId", studentData.Rows[cbStudentId.SelectedIndex]["StudentId"]);
                            command.Parameters.AddWithValue("@librarianId", librarianId);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                                MessageBox.Show("Book Issued");
                                this.Close();
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
    }
}
