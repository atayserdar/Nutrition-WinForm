using Nutrition.BusinessLayer;
using Nutrition.Domain;
using Nutrition.Domain.Entities;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Nutrition.UI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || cmbGender.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen Bilgilerinizi Kontrol Ediniz.");
                return;
            }

            bool resultEmail = ValidateEmail();
            bool resultPassword = ValidatePassword();

            if (resultPassword == true && resultEmail == true)
            {
                SaveUser();
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            FillGenderComboBox();
        }

        private void FillGenderComboBox()
        {
            cmbGender.Items.Add(new ValueTextPair { Value = 1, Text = Constants.Man });
            cmbGender.Items.Add(new ValueTextPair { Value = 2, Text = Constants.Woman });
        }

        private void SaveUser()
        {
            User user = new User();

            user.FirstName = txtFirstName.Text.Trim();
            user.LastName = txtLastName.Text.Trim();
            user.Email = txtEmail.Text.Trim();

            user.Password = txtPassword.Text.Trim();
            user.Height = Convert.ToInt32(numHeight.Value);
            user.Weight = Convert.ToInt32(numWeight.Value);

            ValueTextPair valueTextPair = (ValueTextPair)cmbGender.SelectedItem;
            user.Gender = valueTextPair.Value;

            user.BirthDate = dtpBirthDate.Value;
            user.CreatedDate = DateTime.Now;
            user.UpdatedDate = DateTime.Now;

            UserService userService = new UserService();
            var result = userService.AddUser(user);
            if (result == Constants.ReturnValue.RecordAlreadyExist)
            {
                MessageBox.Show("Daha önce kaydedilmiş email ile tekrar kullanıcı oluşturulamaz!");
                return;
            }
            this.Hide();
            PersonalGoal personalGoal = new PersonalGoal(user);
            personalGoal.Show();
        }

        private bool ValidatePassword()
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                return false;
            }

            char[] password = txtPassword.Text.ToCharArray();
            int numberCount = 0;
            int lowerCaseCount = 0;
            int upperCaseCount = 0;
            int specialCharCount = 0;

            if (password.Length < 8 || password.Length > 16)
            {
                MessageBox.Show("Girmiş olduğunuz şifre 8 ile 16 karakter arasında olmalıdı!");
                return false;
            }

            foreach (char item in password)
            {
                int ascOfItem = (int)item;
                if (ascOfItem >= 48 && ascOfItem <= 57)
                {
                    numberCount++;
                }
                else if (ascOfItem >= 97 && ascOfItem <= 122)
                {
                    lowerCaseCount++;
                }
                else if (ascOfItem >= 65 && ascOfItem <= 90)
                {
                    upperCaseCount++;
                }
                else if (ascOfItem >= 33 && ascOfItem <= 47)
                {
                    specialCharCount++;
                }
            }

            if (numberCount < 2)
            {
                MessageBox.Show("Girmiş olduğunuz şifre içerisinde en az 2 tane sayı olmalıdır!");
                return false;
            }
            else if (lowerCaseCount < 2)
            {
                MessageBox.Show("Girmiş olduğunuz şifre içerisinde en az 2 tane küçük harf olmalıdır!");
                return false;
            }
            else if (upperCaseCount < 2)
            {
                MessageBox.Show("Girmiş olduğunuz şifre içerisinde en az 2 tane büyük harf olmalıdır!");
                return false;
            }
            else if (specialCharCount < 1)
            {
                MessageBox.Show("Girmiş olduğunuz şifre içerisinde en az 2 tane özel karakter olmalıdır!");
                return false;
            }
            return true;
        }
        private bool ValidateEmail()
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regex.Match(txtEmail.Text).Success)
            {
                MessageBox.Show("Email Adresinizi Uygun Formatta Yazınız.");
                return false;
            }
            return true;
        }
    }
}
