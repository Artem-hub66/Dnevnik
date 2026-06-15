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
            panel2 = new Panel();
            dgvScheduleMain = new DataGridView();
            panel1 = new Panel();
            lbScheduleMain = new Label();
            dateTimePickerSheduleMain = new DateTimePicker();
            pnQuarterMain = new Panel();
            ComboBoxQuarterMain = new ComboBox();
            dgvGradesMain = new DataGridView();
            pnLogoMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoMain).BeginInit();
            pnNavMain.SuspendLayout();
            pnScheduleMain.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScheduleMain).BeginInit();
            panel1.SuspendLayout();
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
            pnNavMain.Padding = new Padding(0, 10, 10, 10);
            pnNavMain.Size = new Size(1117, 67);
            pnNavMain.TabIndex = 1;
            // 
            // btnProfileMain
            // 
            btnProfileMain.Dock = DockStyle.Left;
            btnProfileMain.FlatAppearance.BorderSize = 0;
            btnProfileMain.FlatStyle = FlatStyle.Flat;
            btnProfileMain.ForeColor = Color.White;
            btnProfileMain.Location = new Point(126, 10);
            btnProfileMain.Margin = new Padding(10);
            btnProfileMain.Name = "btnProfileMain";
            btnProfileMain.Size = new Size(125, 47);
            btnProfileMain.TabIndex = 1;
            btnProfileMain.Text = "Профиль";
            btnProfileMain.UseVisualStyleBackColor = true;
            btnProfileMain.Click += BtnProfileMain_Click;
            // 
            // btnPageMain
            // 
            btnPageMain.Dock = DockStyle.Left;
            btnPageMain.FlatAppearance.BorderSize = 0;
            btnPageMain.FlatStyle = FlatStyle.Flat;
            btnPageMain.ForeColor = Color.White;
            btnPageMain.Location = new Point(0, 10);
            btnPageMain.Margin = new Padding(10);
            btnPageMain.Name = "btnPageMain";
            btnPageMain.Size = new Size(126, 47);
            btnPageMain.TabIndex = 0;
            btnPageMain.Text = "Моя страница";
            btnPageMain.UseVisualStyleBackColor = true;
            // 
            // pnScheduleMain
            // 
            pnScheduleMain.Controls.Add(panel2);
            pnScheduleMain.Controls.Add(panel1);
            pnScheduleMain.Dock = DockStyle.Right;
            pnScheduleMain.Location = new Point(857, 156);
            pnScheduleMain.Name = "pnScheduleMain";
            pnScheduleMain.Padding = new Padding(10, 0, 10, 0);
            pnScheduleMain.Size = new Size(270, 544);
            pnScheduleMain.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvScheduleMain);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 489);
            panel2.TabIndex = 5;
            // 
            // dgvScheduleMain
            // 
            dgvScheduleMain.BackgroundColor = Color.White;
            dgvScheduleMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvScheduleMain.Dock = DockStyle.Fill;
            dgvScheduleMain.Location = new Point(0, 0);
            dgvScheduleMain.Name = "dgvScheduleMain";
            dgvScheduleMain.Size = new Size(250, 489);
            dgvScheduleMain.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbScheduleMain);
            panel1.Controls.Add(dateTimePickerSheduleMain);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 55);
            panel1.TabIndex = 4;
            // 
            // lbScheduleMain
            // 
            lbScheduleMain.AutoSize = true;
            lbScheduleMain.FlatStyle = FlatStyle.Flat;
            lbScheduleMain.Location = new Point(79, 3);
            lbScheduleMain.Name = "lbScheduleMain";
            lbScheduleMain.Size = new Size(89, 19);
            lbScheduleMain.TabIndex = 0;
            lbScheduleMain.Text = "Расписание";
            // 
            // dateTimePickerSheduleMain
            // 
            dateTimePickerSheduleMain.Location = new Point(0, 29);
            dateTimePickerSheduleMain.Name = "dateTimePickerSheduleMain";
            dateTimePickerSheduleMain.Size = new Size(250, 26);
            dateTimePickerSheduleMain.TabIndex = 5;
            // 
            // pnQuarterMain
            // 
            pnQuarterMain.Controls.Add(ComboBoxQuarterMain);
            pnQuarterMain.Dock = DockStyle.Top;
            pnQuarterMain.Location = new Point(10, 156);
            pnQuarterMain.Margin = new Padding(10);
            pnQuarterMain.Name = "pnQuarterMain";
            pnQuarterMain.Padding = new Padding(0, 10, 10, 10);
            pnQuarterMain.Size = new Size(847, 55);
            pnQuarterMain.TabIndex = 4;
            // 
            // ComboBoxQuarterMain
            // 
            ComboBoxQuarterMain.FormattingEnabled = true;
            ComboBoxQuarterMain.Location = new Point(0, 13);
            ComboBoxQuarterMain.Name = "ComboBoxQuarterMain";
            ComboBoxQuarterMain.Size = new Size(157, 27);
            ComboBoxQuarterMain.TabIndex = 0;
            // 
            // dgvGradesMain
            // 
            dgvGradesMain.BackgroundColor = Color.White;
            dgvGradesMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradesMain.Dock = DockStyle.Fill;
            dgvGradesMain.Location = new Point(10, 211);
            dgvGradesMain.Margin = new Padding(10);
            dgvGradesMain.Name = "dgvGradesMain";
            dgvGradesMain.Size = new Size(847, 489);
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
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvScheduleMain).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label lbScheduleMain;
        private DataGridView dgvRatingsMain;
        private Panel pnQuarterMain;
        private DataGridView dgvGradesMain;
        private DateTimePicker dateTimePickerSheduleMain;
        private ComboBox ComboBoxQuarterMain;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvScheduleMain;
    }
}