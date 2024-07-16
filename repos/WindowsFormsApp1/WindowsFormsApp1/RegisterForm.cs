using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            UserLoginField.Text = "Введите имя";
            UserEmailField.Text = "Введите email";
            UserPasswordField.Text = "Введите пароль";
            this.Text = "Регистрация в программе";
        }

        public void TextBox_Enter(object sender, EventArgs eventArgs)
        {
            if(((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "Введите имя")
            {
                UserLoginField.Text = "";              

            }
            else if(((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "Введите email")
            {
                UserEmailField.Text = "";             
            }
            else if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "Введите пароль")
            {
                UserPasswordField.Text = "";               
                UserPasswordField.UseSystemPasswordChar = true;
            }

        }
        public void TextBox_Leave(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "")
            {
                UserLoginField.Text = "Введите имя";
               
            }
            else if (((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "")
            {
                UserEmailField.Text = "Введите email";
            }
            else if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "")
            {
                UserPasswordField.Text = "Введите пароль";
                UserPasswordField.UseSystemPasswordChar = false;
            }

        }

        private void RegBut_Click(object sender, EventArgs e)
        {
            if(UserLoginField.Text.Trim() == "" || UserLoginField.Text.Trim() == "Введите имя")
            {
                MessageBox.Show("Вы не ввели имя");
                return;
            }
            if (UserEmailField.Text.Trim() == "" || UserEmailField.Text.Trim() == "Введите email")
            {
                MessageBox.Show("Вы не ввели email");
                return;
            }
            if (UserPasswordField.Text.Trim() == "" || UserPasswordField.Text.Trim() == "Введите пароль")
            {
                MessageBox.Show("Вы не ввели пароль");
                return;
            }


            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (login, password, email) VALUES(@login, @password, @email)", db.GetConnection());
            command.Parameters.AddWithValue("login", UserLoginField.Text);
            command.Parameters.AddWithValue("password", Hash(UserPasswordField.Text));
            command.Parameters.AddWithValue("email", UserEmailField.Text);

            db.OpenConnection();
            try
                {

                if (command.ExecuteNonQuery() == 1) MessageBox.Show("Аккаунт создан");
                else MessageBox.Show("Ошибка");
                }catch(MySqlException ex)
                    {
                if (ex.Message.Contains("Duplicate entry ")) MessageBox.Show("Такой логин уже существует");
                MessageBox.Show(ex.Message);

                    }
            db.CloseConnection();
        }
        private string Hash(string input)
        {
            byte[] temp = Encoding.UTF8.GetBytes(input);
            using(SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(temp);
                return Convert.ToBase64String(hash);
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AuchForm auchForm = new AuchForm();
            auchForm.ShowDialog();
            this.Close();
        }
    }
}

