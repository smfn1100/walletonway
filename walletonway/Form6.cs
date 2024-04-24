using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace walletonway
{
    public partial class Form6 : Form
    {


        private string label5Value;


        public Form6(string label3Value)
        {
            InitializeComponent();
            label5Value = label3Value; 
            label5.Text = label5Value; 
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-N5D1GFG\\SQLEXPRESS;Initial Catalog=finalwallet;Integrated Security=True"))
            {
                connection.Open();
                string query = "INSERT INTO payment (Cardno, expirydate, cvv) VALUES (@CardNumber, @ExpiryDate, @CVV)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CardNumber", textBox1.Text);
                    command.Parameters.AddWithValue("@ExpiryDate", textBox2.Text);
                    command.Parameters.AddWithValue("@CVV", textBox3.Text);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Payment successful!");
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
