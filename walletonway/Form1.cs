using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace walletonway
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        private Form3 form3;
        private Form4 form4;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            form3 = new Form3();
            form4 = new Form4(txtusernamelogin.Text);

            signuplogin.Click += signuplogin_Click; 
            nectlogin.Click += nectlogin_Click; 
            guestlogin.LinkClicked += visitAsGuest_LinkClicked; 
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void signuplogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void nectlogin_Click(object sender, EventArgs e)
        {


            if (CheckCredentials(txtusernamelogin.Text, txtpasswordlogin.Text))
            {
                this.Hide();
                form4.SetUsername(txtusernamelogin.Text); // Set the username in Form4
                form4.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

        }

        private void visitAsGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            form3.Show();
        }

        private bool CheckCredentials(string username, string password)
        {
            
            string connectionString = "Data Source=DESKTOP-N5D1GFG\\SQLEXPRESS;Initial Catalog=finalwallet;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM dbo.Register WHERE Username=@Username AND Password=@Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        private void txtusernamelogin_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void signuplogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}

