using System;
using System.Windows.Forms;

namespace walletonway
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            signinlink.LinkClicked += signinlink_LinkClicked;
            supportlink.LinkClicked += supportlink_LinkClicked;
            aboutlink.LinkClicked += aboutlink_LinkClicked;
            signuplink.LinkClicked += signuplink_LinkClicked;
            contactuslink.LinkClicked += contactuslink_LinkClicked;
            ordernowbt.Click += ordernowbt_Click;
        }

        private void signinlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void supportlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form10 form10 = new Form10();
            form10.Show();
            this.Close();

        }

        private void aboutlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form9 form9 = new Form9();
            form9.Show();
            this.Close();
        }

        private void signuplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void contactuslink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
            this.Close();
        }

        private void ordernowbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}