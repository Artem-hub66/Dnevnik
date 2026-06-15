namespace Dnevnik
{
    partial class FormProfile
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
            pnLogoProfile = new Panel();
            lbUserNameProfile = new Label();
            btnExitProfile = new Button();
            pbLogoProfile = new PictureBox();
            pnFillProfile = new Panel();
            dgvUserProfile = new DataGridView();
            pnUpdateProfile = new Panel();
            pndvgProfile = new Panel();
            btnUpdateProfile = new Button();
            pnLogoProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoProfile).BeginInit();
            pnFillProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserProfile).BeginInit();
            pnUpdateProfile.SuspendLayout();
            pndvgProfile.SuspendLayout();
            SuspendLayout();
            // 
            // pnLogoProfile
            // 
            pnLogoProfile.Controls.Add(lbUserNameProfile);
            pnLogoProfile.Controls.Add(btnExitProfile);
            pnLogoProfile.Controls.Add(pbLogoProfile);
            pnLogoProfile.Dock = DockStyle.Top;
            pnLogoProfile.Location = new Point(10, 10);
            pnLogoProfile.Margin = new Padding(10);
            pnLogoProfile.Name = "pnLogoProfile";
            pnLogoProfile.Padding = new Padding(10);
            pnLogoProfile.Size = new Size(1117, 79);
            pnLogoProfile.TabIndex = 1;
            // 
            // lbUserNameProfile
            // 
            lbUserNameProfile.AutoSize = true;
            lbUserNameProfile.Dock = DockStyle.Right;
            lbUserNameProfile.Location = new Point(959, 10);
            lbUserNameProfile.Name = "lbUserNameProfile";
            lbUserNameProfile.Size = new Size(45, 19);
            lbUserNameProfile.TabIndex = 3;
            lbUserNameProfile.Text = "label1";
            // 
            // btnExitProfile
            // 
            btnExitProfile.BackColor = Color.DodgerBlue;
            btnExitProfile.Dock = DockStyle.Right;
            btnExitProfile.FlatAppearance.BorderSize = 0;
            btnExitProfile.FlatStyle = FlatStyle.Flat;
            btnExitProfile.ForeColor = Color.White;
            btnExitProfile.Location = new Point(1004, 10);
            btnExitProfile.Name = "btnExitProfile";
            btnExitProfile.Size = new Size(103, 59);
            btnExitProfile.TabIndex = 2;
            btnExitProfile.Text = "Выход";
            btnExitProfile.UseVisualStyleBackColor = false;
            btnExitProfile.Click += BtnExitProfile_Click;
            // 
            // pbLogoProfile
            // 
            pbLogoProfile.Dock = DockStyle.Left;
            pbLogoProfile.Image = Properties.Resources.LogoMain;
            pbLogoProfile.Location = new Point(10, 10);
            pbLogoProfile.Name = "pbLogoProfile";
            pbLogoProfile.Size = new Size(160, 59);
            pbLogoProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoProfile.TabIndex = 1;
            pbLogoProfile.TabStop = false;
            // 
            // pnFillProfile
            // 
            pnFillProfile.Controls.Add(pndvgProfile);
            pnFillProfile.Controls.Add(pnUpdateProfile);
            pnFillProfile.Dock = DockStyle.Fill;
            pnFillProfile.Location = new Point(10, 89);
            pnFillProfile.Name = "pnFillProfile";
            pnFillProfile.Size = new Size(1117, 611);
            pnFillProfile.TabIndex = 2;
            // 
            // dgvUserProfile
            // 
            dgvUserProfile.BackgroundColor = Color.White;
            dgvUserProfile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserProfile.Dock = DockStyle.Fill;
            dgvUserProfile.Location = new Point(10, 10);
            dgvUserProfile.Name = "dgvUserProfile";
            dgvUserProfile.Size = new Size(1097, 527);
            dgvUserProfile.TabIndex = 0;
            // 
            // pnUpdateProfile
            // 
            pnUpdateProfile.Controls.Add(btnUpdateProfile);
            pnUpdateProfile.Dock = DockStyle.Top;
            pnUpdateProfile.Location = new Point(0, 0);
            pnUpdateProfile.Name = "pnUpdateProfile";
            pnUpdateProfile.Padding = new Padding(10);
            pnUpdateProfile.Size = new Size(1117, 64);
            pnUpdateProfile.TabIndex = 1;
            // 
            // pndvgProfile
            // 
            pndvgProfile.Controls.Add(dgvUserProfile);
            pndvgProfile.Dock = DockStyle.Fill;
            pndvgProfile.Location = new Point(0, 64);
            pndvgProfile.Name = "pndvgProfile";
            pndvgProfile.Padding = new Padding(10);
            pndvgProfile.Size = new Size(1117, 547);
            pndvgProfile.TabIndex = 2;
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.BackColor = Color.DodgerBlue;
            btnUpdateProfile.FlatStyle = FlatStyle.Flat;
            btnUpdateProfile.ForeColor = Color.White;
            btnUpdateProfile.Location = new Point(10, 13);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(160, 34);
            btnUpdateProfile.TabIndex = 0;
            btnUpdateProfile.Text = "Редактировать";
            btnUpdateProfile.UseVisualStyleBackColor = false;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1137, 710);
            Controls.Add(pnFillProfile);
            Controls.Add(pnLogoProfile);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormProfile";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Профиль";
            pnLogoProfile.ResumeLayout(false);
            pnLogoProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoProfile).EndInit();
            pnFillProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserProfile).EndInit();
            pnUpdateProfile.ResumeLayout(false);
            pndvgProfile.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnLogoProfile;
        private Label lbUserNameProfile;
        private Button btnExitProfile;
        private PictureBox pbLogoProfile;
        private Panel pnFillProfile;
        private Panel pndvgProfile;
        private DataGridView dgvUserProfile;
        private Panel pnUpdateProfile;
        private Button btnUpdateProfile;
    }
}