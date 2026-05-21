namespace Dnevnik
{
    partial class FormLogin
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
            Logo = new PictureBox();
            lbLogin = new Label();
            txtLogin = new TextBox();
            lbPass = new Label();
            txtPass = new TextBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.Logo;
            Logo.Location = new Point(138, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(100, 100);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            Logo.Click += this.pictureBox1_Click;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(156, 130);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(64, 22);
            lbLogin.TabIndex = 1;
            lbLogin.Text = "Логин";
            lbLogin.Click += this.lbLogin_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(63, 155);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(250, 30);
            txtLogin.TabIndex = 2;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(152, 199);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(72, 22);
            lbPass.TabIndex = 3;
            lbPass.Text = "Пароль";
            lbPass.Click += this.lbPass_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(63, 224);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(250, 30);
            txtPass.TabIndex = 4;
            txtPass.UseSystemPasswordChar = true;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DeepSkyBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(63, 275);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += this.btnLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 353);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(lbPass);
            Controls.Add(txtLogin);
            Controls.Add(lbLogin);
            Controls.Add(Logo);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private Label lbLogin;
        private TextBox txtLogin;
        private Label lbPass;
        private TextBox txtPass;
        private Button btnLogin;
    }
}
