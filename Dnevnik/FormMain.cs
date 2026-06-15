using Dnevnik.Models;

namespace Dnevnik
{
    public partial class FormMain : Form
    {
        public User CurrentUser { get; private set; }

        public FormMain(User user)
        {
            InitializeComponent();

            ComboBoxQuarterMain.Items.Add("1 Четверть");
            ComboBoxQuarterMain.Items.Add("2 Четверть");
            ComboBoxQuarterMain.Items.Add("3 Четверть");
            ComboBoxQuarterMain.Items.Add("4 Четверть");
            ComboBoxQuarterMain.Items.Add("Год");

            //ComboBoxQuarterMain.SelectedIndex = 0;

            CurrentUser = user;
            lbUserName.Text = CurrentUser.FullName;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxQuarterMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = ComboBoxQuarterMain.SelectedItem.ToString();
        }

        private void BtnProfileMain_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile();
            formProfile.ShowDialog();
            this.Close();
        }
    }
}