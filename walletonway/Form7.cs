using System;

using System.Data.SqlClient;
using System.Windows.Forms;



namespace walletonway
{
    public partial class Form7 : Form
    {
        private string label5Value;

        public Form7()
        {
            
                InitializeComponent();
            
        }

        public Form7(string label3Value) : this()
        {
            label5Value = label3Value; 
            label5.Text = label5Value; 
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-N5D1GFG\\SQLEXPRESS;Initial Catalog=finalwallet;Integrated Security=True"))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO addressss (First_Name, Last_Name, buildingname, City, Country) VALUES (@first_name,@last_name,@BuildingName,@city,@country)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@first_name", textBox1.Text);
                        command.Parameters.AddWithValue("@last_name", textBox2.Text);
                        command.Parameters.AddWithValue("@BuildingName", textBox3.Text);
                        command.Parameters.AddWithValue("@city", textBox4.Text);
                        command.Parameters.AddWithValue("@country", textBox5.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thank You for Giving Us The Details !");

                        this.Close();
                        Form6 form6 = new Form6(label5Value); 
                        form6.Show();
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }
    }
    
}
