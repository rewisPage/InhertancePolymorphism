namespace InhertancePolymorphism
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            pnlLoginContainer = new ReaLTaiizor.Controls.Panel();
            txtPassword = new ReaLTaiizor.Controls.HopeTextBox();
            lblPassword = new ReaLTaiizor.Controls.BigLabel();
            txtUserId = new ReaLTaiizor.Controls.HopeTextBox();
            lblUserId = new ReaLTaiizor.Controls.BigLabel();
            lblTitle = new ReaLTaiizor.Controls.BigLabel();
            lblSubtitle = new ReaLTaiizor.Controls.BigLabel();
            btnLogin = new ReaLTaiizor.Controls.HopeButton();
            pnlLoginContainer.SuspendLayout();
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
            controlBox1.Location = new Point(410, 0);
            controlBox1.MaximizeHoverColor = Color.FromArgb(74, 74, 74);
            controlBox1.MinimizeHoverColor = Color.FromArgb(63, 63, 65);
            controlBox1.Name = "controlBox1";
            controlBox1.Size = new Size(90, 25);
            controlBox1.TabIndex = 0;
            controlBox1.Text = "controlBox1";
            // 
            // pnlLoginContainer
            // 
            pnlLoginContainer.BackColor = Color.FromArgb(26, 30, 42);
            pnlLoginContainer.Controls.Add(txtPassword);
            pnlLoginContainer.Controls.Add(lblPassword);
            pnlLoginContainer.Controls.Add(txtUserId);
            pnlLoginContainer.Controls.Add(lblUserId);
            pnlLoginContainer.EdgeColor = Color.FromArgb(20, 22, 31);
            pnlLoginContainer.Location = new Point(29, 192);
            pnlLoginContainer.Margin = new Padding(20);
            pnlLoginContainer.Name = "pnlLoginContainer";
            pnlLoginContainer.Padding = new Padding(20);
            pnlLoginContainer.Size = new Size(442, 198);
            pnlLoginContainer.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pnlLoginContainer.TabIndex = 1;
            pnlLoginContainer.Text = "panel1";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(11, 13, 20);
            txtPassword.BaseColor = Color.FromArgb(44, 55, 66);
            txtPassword.BorderColorA = Color.FromArgb(46, 52, 64);
            txtPassword.BorderColorB = Color.FromArgb(46, 52, 64);
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Hint = "";
            txtPassword.Location = new Point(23, 141);
            txtPassword.MaxLength = 32767;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.ScrollBars = ScrollBars.None;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.Size = new Size(396, 34);
            txtPassword.TabIndex = 7;
            txtPassword.TabStop = false;
            txtPassword.UseSystemPasswordChar = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(185, 199, 221);
            lblPassword.Location = new Point(23, 110);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 19);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "PASSWORD:";
            // 
            // txtUserId
            // 
            txtUserId.BackColor = Color.FromArgb(11, 13, 20);
            txtUserId.BaseColor = Color.FromArgb(44, 55, 66);
            txtUserId.BorderColorA = Color.FromArgb(46, 52, 64);
            txtUserId.BorderColorB = Color.FromArgb(46, 52, 64);
            txtUserId.Font = new Font("Segoe UI", 10F);
            txtUserId.ForeColor = Color.White;
            txtUserId.Hint = "";
            txtUserId.Location = new Point(23, 54);
            txtUserId.MaxLength = 32767;
            txtUserId.Multiline = false;
            txtUserId.Name = "txtUserId";
            txtUserId.PasswordChar = '\0';
            txtUserId.ScrollBars = ScrollBars.None;
            txtUserId.SelectedText = "";
            txtUserId.SelectionLength = 0;
            txtUserId.SelectionStart = 0;
            txtUserId.Size = new Size(396, 34);
            txtUserId.TabIndex = 5;
            txtUserId.TabStop = false;
            txtUserId.UseSystemPasswordChar = false;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.BackColor = Color.Transparent;
            lblUserId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUserId.ForeColor = Color.FromArgb(185, 199, 221);
            lblUserId.Location = new Point(23, 20);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(88, 19);
            lblUserId.TabIndex = 4;
            lblUserId.Text = "USERNAME:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 25F);
            lblTitle.ForeColor = Color.FromArgb(224, 231, 255);
            lblTitle.Location = new Point(29, 72);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(373, 46);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "🔐 Administrator Login";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(143, 155, 179);
            lblSubtitle.Location = new Point(93, 125);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(204, 15);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "Enter credentials to access dashboard";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(76, 110, 255);
            btnLogin.BorderColor = Color.FromArgb(220, 223, 230);
            btnLogin.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnLogin.DangerColor = Color.FromArgb(245, 108, 108);
            btnLogin.DefaultColor = Color.FromArgb(255, 255, 255);
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnLogin.InfoColor = Color.FromArgb(144, 147, 153);
            btnLogin.Location = new Point(319, 413);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(10);
            btnLogin.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnLogin.Size = new Size(152, 35);
            btnLogin.SuccessColor = Color.FromArgb(103, 194, 58);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Log In";
            btnLogin.TextColor = Color.White;
            btnLogin.WarningColor = Color.FromArgb(230, 162, 60);
            btnLogin.Click += btnLogin_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 22, 31);
            ClientSize = new Size(500, 480);
            Controls.Add(btnLogin);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(pnlLoginContainer);
            Controls.Add(controlBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login – Inheritance Demo";
            pnlLoginContainer.ResumeLayout(false);
            pnlLoginContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ControlBox controlBox1;
        private ReaLTaiizor.Controls.Panel pnlLoginContainer;
        private ReaLTaiizor.Controls.BigLabel lblTitle;
        private ReaLTaiizor.Controls.BigLabel lblSubtitle;
        private ReaLTaiizor.Controls.BigLabel lblUserId;
        private ReaLTaiizor.Controls.HopeTextBox txtUserId;
        private ReaLTaiizor.Controls.BigLabel lblPassword;
        private ReaLTaiizor.Controls.HopeTextBox txtPassword;
        private ReaLTaiizor.Controls.HopeButton btnLogin_Click;
        private ReaLTaiizor.Controls.HopeButton btnLogin;
    }
}
