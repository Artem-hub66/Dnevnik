using Dnevnik.Models;

namespace Dnevnik
{
    public partial class FormMain : Form
    {
        public User CurrentUser { get; private set; }

        public FormMain(User user)
        {
            InitializeComponent();



            CurrentUser = user;

            lbUserName.Text = CurrentUser.FullName;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
