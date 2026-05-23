using System;
using System.Windows.Forms;
using UserNameSpace;

namespace InhertancePolymorphism
{
    public partial class Form1 : Form
    {
        private Administrator admin;

        public Form1()
        {
            InitializeComponent();
            admin = new Administrator("Ariel Alberto", "admin1", "password");

            txtUserId.Text = "admin1";
            txtPassword.Text = "";
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUserId.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.",
                                "Login Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (admin.verifyLogin(username, password))
            {
                MessageBox.Show("Login successful! Opening dashboard...",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Open Form2 and pass the admin reference
                Form2 dashboard = new Form2(admin);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.\nTry Again.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}