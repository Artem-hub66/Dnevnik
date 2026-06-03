using Dnevnik.Models;
using System.Data;

namespace Dnevnik
{
    public partial class FormLogin : Form
    {
        public User CurrentUser { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtLogin.Text) || String.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DnevnikContext())
            {
                var user = db.Users.Where(w =>   w.PasswordHash == txtPass.Text && w.Login == txtLogin.Text).FirstOrDefault();

                if (user != null)
                {
                    CurrentUser = user;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}