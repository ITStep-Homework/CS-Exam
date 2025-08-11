using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using exam.Models;
using exam.Storage;

namespace exam
{
    public partial class Form1 : Form
    {
        private List<User> users;

        public Form1()
        {
            InitializeComponent();
            users = DataStorage.LoadUsers();

            signInButton.Click += SignInButton_Click;
            signUpButton.Click += SignUpButton_Click;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string login = loginSignUpTextBox.Text.Trim();
            string password = passwordSignUpTextBox.Text.Trim();
            DateTime birthDate = signUpCalendar.SelectionStart;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (users.Any(u => u.Login.Equals(login, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Такой логин уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = new User
            {
                Login = login,
                BirthDate = birthDate.ToString("yyyy-MM-dd")
            };
            user.SetPassword(password);

            users.Add(user);
            DataStorage.SaveUsers(users);

            MessageBox.Show("Регистрация прошла успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loginSignUpTextBox.Clear();
            passwordSignUpTextBox.Clear();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string login = loginSIgnInTextBox.Text.Trim();
            string password = passwordSignInTextBox.Text.Trim();

            var user = users.FirstOrDefault(u =>
                u.Login.Equals(login, StringComparison.OrdinalIgnoreCase)
            );

            if (user != null && user.VerifyPassword(password))
            {
                MessageBox.Show($"Добро пожаловать, {user.Login}!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 form2 = new Form2(user);
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
