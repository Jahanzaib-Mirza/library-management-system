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
    public partial class AdminProfile : Form
    {
        private string getStudents = "select * from LMS.dbo.Students";
        private string getAdmins = "select * from LMS.dbo.Admins";
        private string getLibrarians = "select * from LMS.dbo.Librarians";
        private string getFaculty = "select * from LMS.dbo.Faculty";
        private string getBooks = "select * from LMS.dbo.Books";
        private Admin adminInstance;
        public AdminProfile(int id, string name, string email, string password, string designation, string hiredate, string retiredate)
        {
            InitializeComponent();
             adminInstance =  Admin.GetInstance(id, name, email, password, designation, hiredate, retiredate);
            DisplayProfile();
        }
        private void DisplayProfile()
        {
            idLabel.Text = (adminInstance.id).ToString();
            nameLabel.Text = adminInstance.name;
            emailLabel.Text = adminInstance.email;
            passLabel.Text = adminInstance.password;
            dsgntnLabel.Text = adminInstance.designation;
            hrdateLabel.Text = adminInstance.hiredate;
            rtrdateLabel.Text = adminInstance.retiredate;
        }

        private DataTable getTable(string query)
        {
            var dataTable = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand(query, sqlCon))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = getTable(getAdmins);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = getTable(getStudents);
        }

        private void btnLibrarian_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = getTable(getLibrarians);
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = getTable(getFaculty);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = getTable(getBooks);
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            AdminAddAdmin form = new AdminAddAdmin();
            form.ShowDialog();
        }

        private void btnMngStudent_Click(object sender, EventArgs e)
        {
            AdminStudent form = new AdminStudent(adminInstance.id);
            form.ShowDialog();
        }

        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
            AdminAddLibrarian form = new AdminAddLibrarian();
            form.ShowDialog();
        }

        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            AdminAddFaculty form = new AdminAddFaculty();
            form.ShowDialog();
        }

        private void btnMngBook_Click(object sender, EventArgs e)
        {
            AdminBook form = new AdminBook();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.DestroyInstance();
            Login form = new Login();
            form.ShowDialog();
            this.Close();
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
                            dataGridView.DataSource = dataTable;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Enter data with correct Data type");
                    }
                }
            }
        }

        private void btnBookHistort_Click(object sender, EventArgs e)
        {
            var dataTable = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand($"exec LMS.dbo.AdminBookHistory", sqlCon))
                {
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                            dataGridView.DataSource = dataTable;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Enter data with correct Data type");
                    }
                }
            }
        }
    }
}
