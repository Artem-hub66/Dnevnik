namespace Dnevnik
{
    internal static class Program
    {
        static void Main()
        {
            bool exitProgram = false;

            while (!exitProgram)
            {
                using (var formLogin = new FormLogin())
                {
                    var result = formLogin.ShowDialog();

                    if (result == DialogResult.OK && formLogin.CurrentUser != null)
                    {
                        using (var formMain = new FormMain(formLogin.CurrentUser))
                        {
                            formMain.ShowDialog();  
                        }
                    }
                    else
                    {
                        exitProgram = true;
                    }
                }
            }
        }
    }
}