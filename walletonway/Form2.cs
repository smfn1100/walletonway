
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace walletonway
{
    public partial class Form2 : Form
    {

        private SqlConnection sqlConnection;

        public Form2()
            {
                InitializeComponent();
                sqlConnection = new SqlConnection("Data Source=DESKTOP-N5D1GFG\\SQLEXPRESS;Initial Catalog=finalwallet;Integrated Security=True");
            }

        private void firstnameregister_TextChanged(object sender, EventArgs e)
        {
        }

        private void Regisiter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstnameregister.Text) ||
                string.IsNullOrWhiteSpace(Lastnameregister.Text) ||
                string.IsNullOrWhiteSpace(Emailregister.Text) ||
                string.IsNullOrWhiteSpace(usernameregister.Text) ||
                string.IsNullOrWhiteSpace(passwordregister.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                sqlConnection.Open();
                string checkQuery = "SELECT COUNT(*) FROM Register WHERE Username = @username";
                SqlCommand checkCommand = new SqlCommand(checkQuery, sqlConnection);
                checkCommand.Parameters.AddWithValue("@username", usernameregister.Text);
                int existingUserCount = (int)checkCommand.ExecuteScalar();

                if (existingUserCount > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different one.");
                    return;
                }

                string insertQuery = "INSERT INTO Register (First_name, Last_name, Email, Username, Password) VALUES (@firstName, @lastName, @email, @username, @password)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.Parameters.AddWithValue("@firstName", firstnameregister.Text);
                insertCommand.Parameters.AddWithValue("@lastName", Lastnameregister.Text);
                insertCommand.Parameters.AddWithValue("@email", Emailregister.Text);
                insertCommand.Parameters.AddWithValue("@username", usernameregister.Text);
                insertCommand.Parameters.AddWithValue("@password", passwordregister.Text);
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Registration successful!");

                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }



        private void usernameregister_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lastnameregister_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

