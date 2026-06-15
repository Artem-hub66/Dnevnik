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
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.Logo;
            Logo.Location = new Point(141, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(100, 100);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 7;
            Logo.TabStop = false;
            // 
            // lbLogin
            // 
            lbLogin.Location = new Point(0, 0);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(100, 23);
            lbLogin.TabIndex = 6;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(66, 169);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(250, 26);
            txtLogin.TabIndex = 2;
            // 
            // lbPass
            // 
            lbPass.Location = new Point(0, 0);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(100, 23);
            lbPass.TabIndex = 5;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(66, 230);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(250, 26);
            txtPass.TabIndex = 10;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(66, 262);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 40);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 133);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 8;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 198);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 9;
            label2.Text = "Пароль";
            label2.Click += Label2_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 353);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
    }
}
