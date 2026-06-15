using Dnevnik.Models;
using Microsoft.EntityFrameworkCore;

namespace Dnevnik
{
    public partial class FormProfile : Form
    {
        public User CurrentUser { get; private set; }

        public FormProfile(User user)
        {
            InitializeComponent();

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 70;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvUserProfile.Columns.AddRange(
            [
                colInfo
            ]);

            CurrentUser = user;
            lbUserNameProfile.Text = CurrentUser.FullName;

            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            try
            {
                using (var db = new DnevnikContext())
                {
                    var orders = db.Users
                        .Include(i => i.Teacher)
                        .Include(i => i.Student)
                        .ToList();

                    dgvUserProfile.SuspendLayout();
                    dgvUserProfile.Rows.Clear();

                    foreach (var order in orders)
                    {
                        int rowIndex = dgvUserProfile.Rows.Add();
                        var row = dgvUserProfile.Rows[rowIndex];

                        row.Cells["colInfo"].Value = FormatUserProfileInfo(user);
                    }

                    dgvUserProfile.ResumeLayout();
                    dgvUserProfile.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatUserProfileInfo(User user)
        {
            string info = "";
            foreach (var userInfo in user.Student.ToList())
            {
                info = info + " " + userInfo.Student.FullName;
            }

            return $"Имя: {user.FullName}" + Environment.NewLine +
                $"Email: {user.Email}" + Environment.NewLine +
                $"Номер телефона: {user.Phone}" + Environment.NewLine +
                $"Класс: {user.Student.Class.ClassName}" + Environment.NewLine;
        }

        private void BtnExitProfile_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
