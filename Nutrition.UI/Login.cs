using Nutrition.BusinessLayer;
using Nutrition.Domain.Entities;
using System.Windows.Forms;

namespace Nutrition.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, System.EventArgs e)
        {
            var email = txtEmail.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Kullanıcı Adı veya Password Boş Geçilemez !");
                return;
            }

            UserService userService = new UserService();
            var user = userService.GetByEmailAndPassword(email, password);
            if (user == null)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreniz Hatalıdır !");
                return;
            }
            this.Hide();
            HomePage homePage = new HomePage(user);
            homePage.Show();
        }
    }
}
