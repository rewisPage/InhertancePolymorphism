namespace InhertancePolymorphism
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            pnlLoginContainer = new ReaLTaiizor.Controls.Panel();
            lblRoleInfo = new ReaLTaiizor.Controls.BigLabel();
            lblAdminName = new ReaLTaiizor.Controls.BigLabel();
            lblWelcome = new ReaLTaiizor.Controls.BigLabel();
            panel1 = new ReaLTaiizor.Controls.Panel();
            btnUpdatePassword = new ReaLTaiizor.Controls.HopeButton();
            txtNewPassword = new ReaLTaiizor.Controls.HopeTextBox();
            lblNewPassword = new ReaLTaiizor.Controls.BigLabel();
            panel2 = new ReaLTaiizor.Controls.Panel();
            btnUpdateAdminName = new ReaLTaiizor.Controls.HopeButton();
            txtNewAdminName = new ReaLTaiizor.Controls.HopeTextBox();
            lblNewAdminName = new ReaLTaiizor.Controls.BigLabel();
            btnLogout = new ReaLTaiizor.Controls.HopeButton();
            pnlLoginContainer.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // controlBox1
            // 
            controlBox1.BackColor = Color.FromArgb(20, 22, 31);
            controlBox1.CloseHoverColor = Color.FromArgb(230, 17, 35);
            controlBox1.DefaultLocation = true;
            controlBox1.Dock = DockStyle.Right;
            controlBox1.EnableHoverHighlight = true;
            controlBox1.EnableMaximizeButton = false;
            controlBox1.EnableMinimizeButton = false;
            controlBox1.ForeColor = Color.FromArgb(155, 155, 155);
            controlBox1.Location = new Point(460, 0);
            controlBox1.MaximizeHoverColor = Color.FromArgb(74, 74, 74);
            controlBox1.MinimizeHoverColor = Color.FromArgb(63, 63, 65);
            controlBox1.Name = "controlBox1";
            controlBox1.Size = new Size(90, 25);
            controlBox1.TabIndex = 1;
            controlBox1.Text = "controlBox1";
            // 
            // pnlLoginContainer
            // 
            pnlLoginContainer.BackColor = Color.FromArgb(26, 30, 42);
            pnlLoginContainer.Controls.Add(lblRoleInfo);
            pnlLoginContainer.Controls.Add(lblAdminName);
            pnlLoginContainer.Controls.Add(lblWelcome);
            pnlLoginContainer.EdgeColor = Color.FromArgb(20, 22, 31);
            pnlLoginContainer.Location = new Point(29, 48);
            pnlLoginContainer.Margin = new Padding(20);
            pnlLoginContainer.Name = "pnlLoginContainer";
            pnlLoginContainer.Padding = new Padding(20);
            pnlLoginContainer.Size = new Size(492, 100);
            pnlLoginContainer.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pnlLoginContainer.TabIndex = 2;
            pnlLoginContainer.Text = "panel1";
            // 
            // lblRoleInfo
            // 
            lblRoleInfo.AutoSize = true;
            lblRoleInfo.BackColor = Color.Transparent;
            lblRoleInfo.Font = new Font("Segoe UI", 9F);
            lblRoleInfo.ForeColor = Color.FromArgb(143, 155, 179);
            lblRoleInfo.Location = new Point(61, 55);
            lblRoleInfo.Name = "lblRoleInfo";
            lblRoleInfo.Size = new Size(205, 15);
            lblRoleInfo.TabIndex = 5;
            lblRoleInfo.Text = "You are logged in as an Administrator";
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.BackColor = Color.Transparent;
            lblAdminName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminName.ForeColor = Color.FromArgb(224, 231, 255);
            lblAdminName.Location = new Point(159, 19);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(143, 30);
            lblAdminName.TabIndex = 4;
            lblAdminName.Text = "Admin Name";
            lblAdminName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 16F);
            lblWelcome.ForeColor = Color.FromArgb(224, 231, 255);
            lblWelcome.Location = new Point(23, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(144, 30);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "👋 Welcome,";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 30, 42);
            panel1.Controls.Add(btnUpdatePassword);
            panel1.Controls.Add(txtNewPassword);
            panel1.Controls.Add(lblNewPassword);
            panel1.EdgeColor = Color.FromArgb(20, 22, 31);
            panel1.Location = new Point(29, 188);
            panel1.Margin = new Padding(20);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(492, 170);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 3;
            panel1.Text = "panel1";
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = Color.FromArgb(76, 110, 255);
            btnUpdatePassword.BorderColor = Color.FromArgb(220, 223, 230);
            btnUpdatePassword.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnUpdatePassword.DangerColor = Color.FromArgb(245, 108, 108);
            btnUpdatePassword.DefaultColor = Color.FromArgb(255, 255, 255);
            btnUpdatePassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdatePassword.ForeColor = Color.White;
            btnUpdatePassword.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnUpdatePassword.InfoColor = Color.FromArgb(144, 147, 153);
            btnUpdatePassword.Location = new Point(317, 107);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Padding = new Padding(10);
            btnUpdatePassword.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnUpdatePassword.Size = new Size(152, 35);
            btnUpdatePassword.SuccessColor = Color.FromArgb(103, 194, 58);
            btnUpdatePassword.TabIndex = 5;
            btnUpdatePassword.Text = "Update Password";
            btnUpdatePassword.TextColor = Color.White;
            btnUpdatePassword.WarningColor = Color.FromArgb(230, 162, 60);
            btnUpdatePassword.Click += btnUpdatePassword_Click_1;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.FromArgb(11, 13, 20);
            txtNewPassword.BaseColor = Color.FromArgb(44, 55, 66);
            txtNewPassword.BorderColorA = Color.FromArgb(46, 52, 64);
            txtNewPassword.BorderColorB = Color.FromArgb(46, 52, 64);
            txtNewPassword.Font = new Font("Segoe UI", 10F);
            txtNewPassword.ForeColor = Color.White;
            txtNewPassword.Hint = "";
            txtNewPassword.Location = new Point(23, 59);
            txtNewPassword.MaxLength = 32767;
            txtNewPassword.Multiline = false;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '\0';
            txtNewPassword.ScrollBars = ScrollBars.None;
            txtNewPassword.SelectedText = "";
            txtNewPassword.SelectionLength = 0;
            txtNewPassword.SelectionStart = 0;
            txtNewPassword.Size = new Size(446, 34);
            txtNewPassword.TabIndex = 6;
            txtNewPassword.TabStop = false;
            txtNewPassword.Text = "Enter new password";
            txtNewPassword.UseSystemPasswordChar = false;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.BackColor = Color.Transparent;
            lblNewPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNewPassword.ForeColor = Color.FromArgb(185, 199, 221);
            lblNewPassword.Location = new Point(23, 20);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(131, 19);
            lblNewPassword.TabIndex = 5;
            lblNewPassword.Text = "✏️ New Password";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 30, 42);
            panel2.Controls.Add(btnUpdateAdminName);
            panel2.Controls.Add(txtNewAdminName);
            panel2.Controls.Add(lblNewAdminName);
            panel2.EdgeColor = Color.FromArgb(20, 22, 31);
            panel2.Location = new Point(29, 398);
            panel2.Margin = new Padding(20);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20);
            panel2.Size = new Size(492, 170);
            panel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel2.TabIndex = 4;
            panel2.Text = "panel2";
            // 
            // btnUpdateAdminName
            // 
            btnUpdateAdminName.BackColor = Color.FromArgb(76, 110, 255);
            btnUpdateAdminName.BorderColor = Color.FromArgb(220, 223, 230);
            btnUpdateAdminName.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnUpdateAdminName.DangerColor = Color.FromArgb(245, 108, 108);
            btnUpdateAdminName.DefaultColor = Color.FromArgb(255, 255, 255);
            btnUpdateAdminName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateAdminName.ForeColor = Color.White;
            btnUpdateAdminName.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnUpdateAdminName.InfoColor = Color.FromArgb(144, 147, 153);
            btnUpdateAdminName.Location = new Point(317, 107);
            btnUpdateAdminName.Name = "btnUpdateAdminName";
            btnUpdateAdminName.Padding = new Padding(10);
            btnUpdateAdminName.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnUpdateAdminName.Size = new Size(152, 35);
            btnUpdateAdminName.SuccessColor = Color.FromArgb(103, 194, 58);
            btnUpdateAdminName.TabIndex = 5;
            btnUpdateAdminName.Text = "Update Name";
            btnUpdateAdminName.TextColor = Color.White;
            btnUpdateAdminName.WarningColor = Color.FromArgb(230, 162, 60);
            btnUpdateAdminName.Click += btnUpdateAdminName_Click_1;
            // 
            // txtNewAdminName
            // 
            txtNewAdminName.BackColor = Color.FromArgb(11, 13, 20);
            txtNewAdminName.BaseColor = Color.FromArgb(44, 55, 66);
            txtNewAdminName.BorderColorA = Color.FromArgb(46, 52, 64);
            txtNewAdminName.BorderColorB = Color.FromArgb(46, 52, 64);
            txtNewAdminName.Font = new Font("Segoe UI", 10F);
            txtNewAdminName.ForeColor = Color.White;
            txtNewAdminName.Hint = "";
            txtNewAdminName.Location = new Point(23, 59);
            txtNewAdminName.MaxLength = 32767;
            txtNewAdminName.Multiline = false;
            txtNewAdminName.Name = "txtNewAdminName";
            txtNewAdminName.PasswordChar = '\0';
            txtNewAdminName.ScrollBars = ScrollBars.None;
            txtNewAdminName.SelectedText = "";
            txtNewAdminName.SelectionLength = 0;
            txtNewAdminName.SelectionStart = 0;
            txtNewAdminName.Size = new Size(446, 34);
            txtNewAdminName.TabIndex = 6;
            txtNewAdminName.TabStop = false;
            txtNewAdminName.Text = "Change admin name";
            txtNewAdminName.UseSystemPasswordChar = false;
            // 
            // lblNewAdminName
            // 
            lblNewAdminName.AutoSize = true;
            lblNewAdminName.BackColor = Color.Transparent;
            lblNewAdminName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNewAdminName.ForeColor = Color.FromArgb(185, 199, 221);
            lblNewAdminName.Location = new Point(23, 20);
            lblNewAdminName.Name = "lblNewAdminName";
            lblNewAdminName.Size = new Size(155, 19);
            lblNewAdminName.TabIndex = 5;
            lblNewAdminName.Text = "🏷️ New Admin Name";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(76, 110, 255);
            btnLogout.BorderColor = Color.FromArgb(220, 223, 230);
            btnLogout.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnLogout.DangerColor = Color.FromArgb(245, 108, 108);
            btnLogout.DefaultColor = Color.FromArgb(255, 255, 255);
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnLogout.InfoColor = Color.FromArgb(144, 147, 153);
            btnLogout.Location = new Point(346, 591);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10);
            btnLogout.PrimaryColor = Color.FromArgb(61, 46, 62);
            btnLogout.Size = new Size(152, 35);
            btnLogout.SuccessColor = Color.FromArgb(103, 194, 58);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "LOG OUT";
            btnLogout.TextColor = Color.FromArgb(255, 180, 162);
            btnLogout.WarningColor = Color.FromArgb(230, 162, 60);
            btnLogout.Click += btnLogout_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 22, 31);
            ClientSize = new Size(550, 650);
            Controls.Add(btnLogout);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlLoginContainer);
            Controls.Add(controlBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            pnlLoginContainer.ResumeLayout(false);
            pnlLoginContainer.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ControlBox controlBox1;
        private ReaLTaiizor.Controls.Panel pnlLoginContainer;
        private ReaLTaiizor.Controls.BigLabel lblWelcome;
        private ReaLTaiizor.Controls.BigLabel lblAdminName;
        private ReaLTaiizor.Controls.BigLabel lblRoleInfo;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.BigLabel lblNewPassword;
        private ReaLTaiizor.Controls.HopeTextBox txtNewPassword;
        private ReaLTaiizor.Controls.HopeButton btnUpdatePassword;
        private ReaLTaiizor.Controls.Panel panel2;
        private ReaLTaiizor.Controls.HopeButton btnUpdateAdminName;
        private ReaLTaiizor.Controls.HopeTextBox txtNewAdminName;
        private ReaLTaiizor.Controls.BigLabel lblNewAdminName;
        private ReaLTaiizor.Controls.HopeButton btnLogout;
    }
}