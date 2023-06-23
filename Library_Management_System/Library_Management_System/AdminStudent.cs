using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Library_Management_System
{
    public partial class AdminStudent : Form
    {
        public int adminID;
        private string insertStudent = "EXEC LMS.dbo.InsertStudentsRecord @name,@email,@password,@dept,@sem,@city, @adminID";
        private string updateStudent = "EXEC LMS.dbo.UpdateStudentRecord @id,@name,@email,@password,@dept,@sem,@city";
        private string deleteStudent = "EXEC LMS.dbo.DeleteStudentRecord @id";
        private string getStudent = "EXEC LMS.dbo.ReadStudentRecord @id";
        public AdminStudent(int adminID)
        {
            InitializeComponent();
            this.adminID = adminID;
        }

        private void resetAll()
        {
            id.Text = "";
            name.Text = "";
            email.Text = "";
            pass.Text = "";
            dept.Text = "";
            smstr.Text = "";
            city.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && email.Text != "" && pass.Text != "" && dept.Text != "" && smstr.Text != "" && city.Text != "")
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(insertStudent, sqlCon))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@name", name.Text);
                            command.Parameters.AddWithValue("@email", email.Text);
                            command.Parameters.AddWithValue("@password", pass.Text);
                            command.Parameters.AddWithValue("@dept", dept.Text);
                            command.Parameters.AddWithValue("@sem", Convert.ToInt32(smstr.Text));
                            command.Parameters.AddWithValue("@city", city.Text);
                            command.Parameters.AddWithValue("@adminID", adminID.ToString());
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                                resetAll();
                                MessageBox.Show("Student Added");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id.Text != "" && name.Text != "" && email.Text != "" && pass.Text != "" && dept.Text != "" && smstr.Text != "" && city.Text != "")
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(updateStudent, sqlCon))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text));
                            command.Parameters.AddWithValue("@name", name.Text);
                            command.Parameters.AddWithValue("@email", email.Text);
                            command.Parameters.AddWithValue("@password", pass.Text);
                            command.Parameters.AddWithValue("dept", dept.Text);
                            command.Parameters.AddWithValue("sem", Convert.ToInt32(smstr.Text));
                            command.Parameters.AddWithValue("city", city.Text);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                                MessageBox.Show("Student with ID:" + id.Text + " is Updated");
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (id.Text != "")
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(deleteStudent, sqlCon))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@id", int.Parse(id.Text));
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                                MessageBox.Show("Student with ID:" + id.Text + " is Deleted");
                                resetAll();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Student is used in Another Table.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("ID is missing");
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (id.Text != "")
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(getStudent, sqlCon))
                    {
                        command.Parameters.AddWithValue("@id", id.Text);
                        //var reader = await command.ExecuteReaderAsync();
                        //name.Text = reader.GetOrdinal("StudentName").ToString();
                        //email.Text = reader.GetOrdinal("StudentEmail").ToString();
                        //pass.Text = reader.GetOrdinal("StudentPassword").ToString();
                        //dept.Text = reader.GetOrdinal("StudentDepartment").ToString();
                        //smstr.Text = reader.GetOrdinal("StudentSemester").ToString();
                        //city.Text = reader.GetOrdinal("StudentCity").ToString();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0)
                            {
                                foreach (DataRow row in dataTable.Rows)
                                {
                                    name.Text = row["StudentName"].ToString();
                                    email.Text = row["StudentEmail"].ToString();
                                    pass.Text = row["StudentPassword"].ToString();
                                    dept.Text = row["StudentDepartment"].ToString();
                                    smstr.Text = row["StudentSemester"].ToString();
                                    city.Text = row["StudentCity"].ToString();
                                }
                            }
                            else MessageBox.Show("No Student Found");

                        }
                    }
                }
            }
            else MessageBox.Show("Enter Student Id");
        }
    }
}
