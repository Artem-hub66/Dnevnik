namespace Dnevnik
{
    partial class FormMain
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
            pnLogoMain = new Panel();
            pbLogoMain = new PictureBox();
            btnExit = new Button();
            lbUserName = new Label();
            pnNavMain = new Panel();
            btnPageMain = new Button();
            btnProfileMain = new Button();
            pnScheduleMain = new Panel();
            lbScheduleMain = new Label();
            comboBoxDateMain = new ComboBox();
            flpScheduleMain = new FlowLayoutPanel();
            pnLogoMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoMain).BeginInit();
            pnNavMain.SuspendLayout();
            pnScheduleMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnLogoMain
            // 
            pnLogoMain.Controls.Add(lbUserName);
            pnLogoMain.Controls.Add(btnExit);
            pnLogoMain.Controls.Add(pbLogoMain);
            pnLogoMain.Dock = DockStyle.Top;
            pnLogoMain.Location = new Point(10, 10);
            pnLogoMain.Margin = new Padding(10);
            pnLogoMain.Name = "pnLogoMain";
            pnLogoMain.Padding = new Padding(10);
            pnLogoMain.Size = new Size(1117, 79);
            pnLogoMain.TabIndex = 0;
            // 
            // pbLogoMain
            // 
            pbLogoMain.Dock = DockStyle.Left;
            pbLogoMain.Image = Properties.Resources.LogoMain;
            pbLogoMain.Location = new Point(10, 10);
            pbLogoMain.Name = "pbLogoMain";
            pbLogoMain.Size = new Size(160, 59);
            pbLogoMain.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoMain.TabIndex = 1;
            pbLogoMain.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DodgerBlue;
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1004, 10);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(103, 59);
            btnExit.TabIndex = 2;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Dock = DockStyle.Right;
            lbUserName.Location = new Point(959, 10);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(45, 19);
            lbUserName.TabIndex = 3;
            lbUserName.Text = "label1";
            // 
            // pnNavMain
            // 
            pnNavMain.BackColor = Color.DodgerBlue;
            pnNavMain.Controls.Add(btnProfileMain);
            pnNavMain.Controls.Add(btnPageMain);
            pnNavMain.Dock = DockStyle.Top;
            pnNavMain.Location = new Point(10, 89);
            pnNavMain.Margin = new Padding(10);
            pnNavMain.Name = "pnNavMain";
            pnNavMain.Padding = new Padding(10);
            pnNavMain.Size = new Size(1117, 67);
            pnNavMain.TabIndex = 1;
            // 
            // btnPageMain
            // 
            btnPageMain.Dock = DockStyle.Left;
            btnPageMain.FlatAppearance.BorderSize = 0;
            btnPageMain.FlatStyle = FlatStyle.Flat;
            btnPageMain.ForeColor = Color.White;
            btnPageMain.Location = new Point(10, 10);
            btnPageMain.Margin = new Padding(10);
            btnPageMain.Name = "btnPageMain";
            btnPageMain.Size = new Size(126, 47);
            btnPageMain.TabIndex = 0;
            btnPageMain.Text = "Моя страница";
            btnPageMain.UseVisualStyleBackColor = true;
            // 
            // btnProfileMain
            // 
            btnProfileMain.Dock = DockStyle.Left;
            btnProfileMain.FlatAppearance.BorderSize = 0;
            btnProfileMain.FlatStyle = FlatStyle.Flat;
            btnProfileMain.ForeColor = Color.White;
            btnProfileMain.Location = new Point(136, 10);
            btnProfileMain.Margin = new Padding(10);
            btnProfileMain.Name = "btnProfileMain";
            btnProfileMain.Size = new Size(125, 47);
            btnProfileMain.TabIndex = 1;
            btnProfileMain.Text = "Профиль";
            btnProfileMain.UseVisualStyleBackColor = true;
            // 
            // pnScheduleMain
            // 
            pnScheduleMain.Controls.Add(flpScheduleMain);
            pnScheduleMain.Controls.Add(comboBoxDateMain);
            pnScheduleMain.Controls.Add(lbScheduleMain);
            pnScheduleMain.Dock = DockStyle.Right;
            pnScheduleMain.Location = new Point(857, 156);
            pnScheduleMain.Name = "pnScheduleMain";
            pnScheduleMain.Padding = new Padding(10);
            pnScheduleMain.Size = new Size(270, 544);
            pnScheduleMain.TabIndex = 2;
            // 
            // lbScheduleMain
            // 
            lbScheduleMain.AutoSize = true;
            lbScheduleMain.Location = new Point(87, 10);
            lbScheduleMain.Name = "lbScheduleMain";
            lbScheduleMain.Size = new Size(89, 19);
            lbScheduleMain.TabIndex = 0;
            lbScheduleMain.Text = "Расписание";
            // 
            // comboBoxDateMain
            // 
            comboBoxDateMain.FormattingEnabled = true;
            comboBoxDateMain.Location = new Point(10, 42);
            comboBoxDateMain.Name = "comboBoxDateMain";
            comboBoxDateMain.Size = new Size(250, 27);
            comboBoxDateMain.TabIndex = 1;
            // 
            // flpScheduleMain
            // 
            flpScheduleMain.Location = new Point(10, 75);
            flpScheduleMain.Name = "flpScheduleMain";
            flpScheduleMain.Padding = new Padding(10);
            flpScheduleMain.Size = new Size(250, 456);
            flpScheduleMain.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1137, 710);
            Controls.Add(pnScheduleMain);
            Controls.Add(pnNavMain);
            Controls.Add(pnLogoMain);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormMain";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная";
            pnLogoMain.ResumeLayout(false);
            pnLogoMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoMain).EndInit();
            pnNavMain.ResumeLayout(false);
            pnScheduleMain.ResumeLayout(false);
            pnScheduleMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnLogoMain;
        private PictureBox pbLogoMain;
        private Button btnExit;
        private Label lbUserName;
        private Panel pnNavMain;
        private Button btnPageMain;
        private Button btnProfileMain;
        private Panel pnScheduleMain;
        private ComboBox comboBoxDateMain;
        private Label lbScheduleMain;
        private FlowLayoutPanel flpScheduleMain;
    }
}