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
    public partial class AdminBook : Form
    {
        private string addBook = "Exec LMS.dbo.AddBook @title,@price,@author,@edition,@copies";
        private string updateBook = "Exec LMS.dbo.UpdateBook @id,@title,@price,@author,@edition,@copies";
        private string deleteBook = "Exec LMS.dbo.DeleteBook @id";
        private string searchBook = "Exec LMS.dbo.SearchBookById @id";
        public AdminBook()
        {
            InitializeComponent();
        }

        private void resetAll()
        {
            txtId.Text = "";
            title.Text = "";
            author.Text = "";
            price.Text = "";
            edition.Text = "";
            copies.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (title.Text != "" && author.Text != "" && price.Text != "" && edition.Text != "" && copies.Text != "")
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(addBook, sqlCon))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@title", title.Text);
                            command.Parameters.AddWithValue("@author", author.Text);
                            command.Parameters.AddWithValue("@price", Convert.ToInt32(price.Text));
                            command.Parameters.AddWithValue("@edition", edition.Text);
                            command.Parameters.AddWithValue("@copies", Convert.ToInt32(copies.Text));
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                                resetAll();
                                MessageBox.Show("Book Added");
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
            if (txtId.Text != "" && title.Text != "" && author.Text != "" && price.Text != "" && edition.Text != "" && copies.Text != "")
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(updateBook, sqlCon))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                            command.Parameters.AddWithValue("@title", title.Text);
                            command.Parameters.AddWithValue("@author", author.Text);
                            command.Parameters.AddWithValue("@price", Convert.ToInt32(price.Text));
                            command.Parameters.AddWithValue("@edition", edition.Text);
                            command.Parameters.AddWithValue("@copies", Convert.ToInt32(copies.Text));
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                                MessageBox.Show("Book with ID:" + txtId.Text + " is Updated");
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
            if (txtId.Text != "")
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(deleteBook, sqlCon))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                                MessageBox.Show("Book with ID:" + txtId.Text + " is Deleted");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection("Data Source=JAHANZAIB\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlCon.Open();
                    using (SqlCommand command = new SqlCommand(searchBook, sqlCon))
                    {
                        command.Parameters.AddWithValue("@id", txtId.Text);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0)
                            {
                                foreach (DataRow row in dataTable.Rows)
                                {
                                    title.Text = row["BookTitle"].ToString();
                                    price.Text = row["BookPrice"].ToString();
                                    author.Text = row["BookAuthor"].ToString();
                                    edition.Text = row["BookEdition"].ToString();
                                    copies.Text = row["NoOfCopies"].ToString();
                                }
                            }
                            else MessageBox.Show("No Book Found");


                        }
                    }
                }
            }
            else MessageBox.Show("Enter Book Id");
        }
    }
}
