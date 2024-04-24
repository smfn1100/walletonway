using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace walletonway
{
    public partial class Form4 : Form
    {
        private string loggedInUsername;
        private string connectionString = "Data Source=DESKTOP-N5D1GFG\\SQLEXPRESS;Initial Catalog = finalwallet; Integrated Security = True"; // Replace with your actual connection string

        public Form4()
        {
            InitializeComponent();
            button4.Click += button4_Click;
            dataGridView1.Visible = false;
            
        }
        public void SetUsername(string username)
        {
            loggedInUsername = username;
        }

        public Form4(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = label3.Text;
            string productPrice = label8.Text;
            int productAmount = 1;

            string connectionString = "Data Source=DESKTOP-N5D1GFG\\SQLEXPRESS;Initial Catalog=finalwallet;Integrated Security=True";

            string insertQuery = "INSERT INTO cartitem (productname, productprice, username, productamount) VALUES (@ProductName, @ProductPrice, @Username, @ProductAmount)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@ProductPrice", productPrice);
                    command.Parameters.AddWithValue("@Username", loggedInUsername);
                    command.Parameters.AddWithValue("@ProductAmount", productAmount);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No rows were affected.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }








        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void supportlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            this.Hide();
        }

        private void aboutlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide();
        }

        private void contactuslink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
            this.Hide();
        }

        private void logoutlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form14 form14 = new Form14(loggedInUsername);
            form14.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string productName = label5.Text;
            string productPrice = label11.Text;
            string userName = loggedInUsername;
            int productAmount = 1;

            string connectionString = "Data Source=DESKTOP-N5D1GFG\\SQLEXPRESS;Initial Catalog=finalwallet;Integrated Security=True";

            string insertQuery = "INSERT INTO cartitem (productname, productprice, username, productamount) VALUES (@ProductName, @ProductPrice, @Username, @ProductAmount)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {

                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@ProductPrice", productPrice);
                    command.Parameters.AddWithValue("@Username", userName);
                    command.Parameters.AddWithValue("@ProductAmount", productAmount);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No rows were affected.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertProduct(label6.Text, label12.Text);
        }

        private void InsertProduct(string productName, string productPrice)
        {
            string connectionString = "Data Source=DESKTOP-N5D1GFG\\SQLEXPRESS;Initial Catalog=finalwallet;Integrated Security=True";

            string insertQuery = "INSERT INTO cartitem (productname, productprice, username, productamount) VALUES (@ProductName, @ProductPrice, @Username, @ProductAmount)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@ProductPrice", productPrice);
                    command.Parameters.AddWithValue("@Username", loggedInUsername);
                    command.Parameters.AddWithValue("@ProductAmount", 1);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No rows were affected.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string productName = textBox1.Text.Trim();

            
            if (!string.IsNullOrWhiteSpace(productName))
            {
                string selectQuery = "SELECT * FROM item WHERE productname LIKE '%' + @ProductName + '%'"; 

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ProductName", productName);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        
                        dataGridView1.DataSource = null;
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        dataGridView1.Refresh(); 

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                            dataGridView1.Visible = true; 
                        }
                        else
                        {
                            dataGridView1.Visible = false; 
                            MessageBox.Show("No products found with the given name.");
                        }
                    }
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh(); 
                dataGridView1.Visible = false; 
                MessageBox.Show("Please enter a product name.");
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}















