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
            colInfo.FillWeight = 100;
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
                    // Загружаем данные текущего пользователя с связанными сущностями
                    var userWithDetails = db.Users
                        .Include(i => i.Teacher)
                        .Include(i => i.Student)
                        .ThenInclude(s => s.Class) // Добавляем Include для Class
                        .FirstOrDefault(u => u.Id == CurrentUser.Id); // Загружаем только текущего пользователя

                    if (userWithDetails == null)
                    {
                        MessageBox.Show("Пользователь не найден", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    dgvUserProfile.SuspendLayout();
                    dgvUserProfile.Rows.Clear();

                    int rowIndex = dgvUserProfile.Rows.Add();
                    var row = dgvUserProfile.Rows[rowIndex];
                    row.Cells["colInfo"].Value = FormatUserProfileInfo(userWithDetails);

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
            string info = $"Имя: {user.FullName}" + Environment.NewLine +
                $"Email: {user.Email}" + Environment.NewLine +
                $"Номер телефона: {user.Phone}" + Environment.NewLine;

            // Проверяем, является ли пользователь студентом
            if (user.Student != null)
            {
                info += $"Класс: {user.Student.Class?.ClassName ?? "Не указан"}" + Environment.NewLine;
            }

            // Проверяем, является ли пользователь учителем
            if (user.Teacher != null && user.Teacher.TeacherSubjectClasses != null && user.Teacher.TeacherSubjectClasses.Any())
            {
                // Вариант 1: Показать только первый предмет
                var firstSubject = user.Teacher.TeacherSubjectClasses.FirstOrDefault();
                info += $"Предмет: {firstSubject?.Subject?.SubjectName ?? "Не указан"}" + Environment.NewLine;
            }
            else if (user.Teacher != null)
            {
                info += $"Предмет: Не указан" + Environment.NewLine;
            }

            return info;
        }

        private void BtnExitProfile_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}