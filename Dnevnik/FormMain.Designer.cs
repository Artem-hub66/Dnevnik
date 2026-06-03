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
            lbUserName = new Label();
            btnExit = new Button();
            pbLogoMain = new PictureBox();
            pnNavMain = new Panel();
            btnProfileMain = new Button();
            btnPageMain = new Button();
            pnScheduleMain = new Panel();
            dgvScheduleMain = new DataGridView();
            comboBoxDateMain = new ComboBox();
            lbScheduleMain = new Label();
            pnQuarterMain = new Panel();
            comboBoxQuarterMain = new ComboBox();
            dgvGradesMain = new DataGridView();
            pnLogoMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoMain).BeginInit();
            pnNavMain.SuspendLayout();
            pnScheduleMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScheduleMain).BeginInit();
            pnQuarterMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGradesMain).BeginInit();
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
            btnExit.Click += BtnExit_Click;
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
            // pnScheduleMain
            // 
            pnScheduleMain.Controls.Add(dgvScheduleMain);
            pnScheduleMain.Controls.Add(comboBoxDateMain);
            pnScheduleMain.Controls.Add(lbScheduleMain);
            pnScheduleMain.Dock = DockStyle.Right;
            pnScheduleMain.Location = new Point(857, 156);
            pnScheduleMain.Name = "pnScheduleMain";
            pnScheduleMain.Padding = new Padding(10);
            pnScheduleMain.Size = new Size(270, 544);
            pnScheduleMain.TabIndex = 2;
            // 
            // dgvScheduleMain
            // 
            dgvScheduleMain.BackgroundColor = Color.White;
            dgvScheduleMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvScheduleMain.Dock = DockStyle.Bottom;
            dgvScheduleMain.Location = new Point(10, 78);
            dgvScheduleMain.Name = "dgvScheduleMain";
            dgvScheduleMain.Size = new Size(250, 456);
            dgvScheduleMain.TabIndex = 3;
            // 
            // comboBoxDateMain
            // 
            comboBoxDateMain.FormattingEnabled = true;
            comboBoxDateMain.Location = new Point(10, 42);
            comboBoxDateMain.Name = "comboBoxDateMain";
            comboBoxDateMain.Size = new Size(250, 27);
            comboBoxDateMain.TabIndex = 1;
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
            // pnQuarterMain
            // 
            pnQuarterMain.Controls.Add(comboBoxQuarterMain);
            pnQuarterMain.Dock = DockStyle.Top;
            pnQuarterMain.Location = new Point(10, 156);
            pnQuarterMain.Margin = new Padding(10);
            pnQuarterMain.Name = "pnQuarterMain";
            pnQuarterMain.Padding = new Padding(10);
            pnQuarterMain.Size = new Size(847, 55);
            pnQuarterMain.TabIndex = 4;
            // 
            // comboBoxQuarterMain
            // 
            comboBoxQuarterMain.FormattingEnabled = true;
            comboBoxQuarterMain.Location = new Point(10, 13);
            comboBoxQuarterMain.Name = "comboBoxQuarterMain";
            comboBoxQuarterMain.Size = new Size(160, 27);
            comboBoxQuarterMain.TabIndex = 0;
            // 
            // dgvGradesMain
            // 
            dgvGradesMain.BackgroundColor = Color.White;
            dgvGradesMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradesMain.Dock = DockStyle.Bottom;
            dgvGradesMain.Location = new Point(10, 224);
            dgvGradesMain.Margin = new Padding(10);
            dgvGradesMain.Name = "dgvGradesMain";
            dgvGradesMain.Size = new Size(847, 476);
            dgvGradesMain.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1137, 710);
            Controls.Add(dgvGradesMain);
            Controls.Add(pnQuarterMain);
            Controls.Add(pnScheduleMain);
            Controls.Add(pnNavMain);
            Controls.Add(pnLogoMain);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)dgvScheduleMain).EndInit();
            pnQuarterMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGradesMain).EndInit();
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
        private DataGridView dgvScheduleMain;
        private DataGridView dgvRatingsMain;
        private Panel pnQuarterMain;
        private ComboBox comboBoxQuarterMain;
        private DataGridView dgvGradesMain;
    }
}