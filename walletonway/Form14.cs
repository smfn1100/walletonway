using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace walletonway
{
    public partial class Form14 : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-N5D1GFG\\SQLEXPRESS;Initial Catalog=finalwallet;Integrated Security=True"; // Provide your connection string here
        private string loggedInUsername = "";

        public Form14(string username = "")
        {
            InitializeComponent();
            loggedInUsername = username;
            LoadData();
        }

        private void LoadData()
        {
            if (string.IsNullOrEmpty(loggedInUsername))
            {
                return;
            }

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT productname, productamount, productprice FROM cartitem WHERE username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", loggedInUsername);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            SetDataGridViewDataSource(dataTable);
            CalculateTotalPrice();
        }

        public void SetDataGridViewDataSource(DataTable dataTable)
        {
            dataGridView1.DataSource = dataTable;
        }

        private void CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                decimal price = Convert.ToDecimal(row.Cells[2].Value.ToString().Replace("$", ""));
                int amount = Convert.ToInt32(row.Cells[1].Value);

                totalPrice += price * amount;
            }

            label3.Text = $"Total Price: ${totalPrice:F2}";
        }

        private void RemoveProductsForUser(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM cartitem WHERE username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                command.ExecuteNonQuery();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveProductsForUser(loggedInUsername);
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string label3Value = label3.Text; 
            Form7 form7 = new Form7(label3Value); 
            form7.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form4 = new Form4(loggedInUsername);
            form4.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }
    }
}