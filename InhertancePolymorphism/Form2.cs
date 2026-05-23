using InhertancePolymorphism.InhertancePolymorphism;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InhertancePolymorphism
{
    public partial class Form2 : Form
    {
        private Administrator loggedAdmin;

        public Form2(Administrator admin)
        {
            InitializeComponent();
            loggedAdmin = admin;
            UpdateWelcomeHeader();
        }

        private void UpdateWelcomeHeader()
        {
            // Update the label that shows the admin name
            lblAdminName.Text = loggedAdmin.getAdminName();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit the application?",
                                                      "Exit",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true; // prevent closing
                }
            }

        }

        private void btnUpdatePassword_Click_1(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text.Trim();
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Password cannot be empty.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Polymorphic call – updatePassword is virtual in User, overridden in Administrator
            loggedAdmin.updatePassword(newPassword);

            MessageBox.Show($"Password successfully updated for {loggedAdmin.getUserId()}.",
                            "Update Password",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            txtNewPassword.Clear();
        }

        private void btnUpdateAdminName_Click_1(object sender, EventArgs e)
        {
            string newName = txtNewAdminName.Text.Trim();
            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Admin name cannot be empty.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            loggedAdmin.updateAdminName(newName);
            MessageBox.Show($"Admin name changed to '{newName}'.",
                            "Update Admin Name",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            UpdateWelcomeHeader();   // refresh the header label
            txtNewAdminName.Clear();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            // Close dashboard and show login form again
            this.Close();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }
    }
}
