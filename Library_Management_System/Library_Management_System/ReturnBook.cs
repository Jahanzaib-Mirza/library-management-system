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
    public partial class ReturnBook : Form
    {
        private int librarianId;
        int studentId;
        int ReportId;
        DataTable studentData = new DataTable();
        DataTable BookData = new DataTable();
        string returnBook = "EXEC LMS.dbo.ReturnBook @reportId";

        public ReturnBook(int id)
        {
            InitializeComponent();
            this.librarianId = id;
            getStudents();
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

        private void cbStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStudentId.SelectedIndex >= 0)
            {
                studentId = (int)studentData.Rows[cbStudentId.SelectedIndex]["StudentId"];
                BookData.Clear();
                cbBookId.DataSource = null;
               // MessageBox.Show(studentData.Rows[cbStudentId.SelectedIndex]["StudentName"].ToString());
                cbStudentId.Text = studentData.Rows[cbStudentId.SelectedIndex]["StudentName"].ToString();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand($"exec LMS.dbo.getReportRefStudent {studentId}", sqlCon))
                    {
                        try
                        {

                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(BookData);
                                cbBookId.DataSource = BookData;
                                cbBookId.DisplayMember = "BookTitle";
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
                //ReportId = BookData.Rows[cbBookId.SelectedIndex]["ReportID"];

            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(studentId.ToString()) && cbBookId.SelectedIndex >= 0)
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(returnBook, sqlCon))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@reportId", BookData.Rows[cbBookId.SelectedIndex]["ReportID"]);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                                this.Close();
                               // resetAll();
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
