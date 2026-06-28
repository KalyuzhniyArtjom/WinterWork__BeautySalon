using BeautySalonLib.Managers;

namespace BeautySalon
{
    public partial class LoginForm : Form

    {
        private UserManager _userManager = new UserManager();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Пожалуйста, заполните поля логин и пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _userManager.Authenticate(txtLogin.Text, txtPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль. Попробуйте снова", "Ошибка авторизации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            if (user.Role == "Admin")
            {
                var adminForm = new AdminForm(_userManager.CurrentUser);
                adminForm.ShowDialog();
            }
            else if (user.Role == "Master")
            {
                var masterForm = new MasterForm(_userManager.CurrentUser);
                masterForm.ShowDialog();
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

