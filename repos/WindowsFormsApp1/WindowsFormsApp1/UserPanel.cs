using MySql.Data.MySqlClient;
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
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
            UserEmailField.Text = "Введите email";
            UserPasswordField.Text = "Введите пароль";
        }
        public void TextBox_Enter(object sender, EventArgs eventArgs)
        {
                       
            if (((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "Введите email")
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
           
            if (((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "")
            {
                UserEmailField.Text = "Введите email";
            }
            else if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "")
            {
                UserPasswordField.Text = "Введите пароль";
                UserPasswordField.UseSystemPasswordChar = false;
            }

        }

        private void UserPanelBut_Click(object sender, EventArgs e)
        {
            
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
            else
            {

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE  `users` SET `password` = @password, `email` = @email  WHERE `login` = 'admin'", db.GetConnection());
                command.Parameters.AddWithValue("password", Hash(UserPasswordField.Text));
                command.Parameters.AddWithValue("email", UserEmailField.Text);

                db.OpenConnection();
                UserPanelBut.Text = "Готово";
                int countUser = Convert.ToInt32(command.ExecuteScalar());              
                db.CloseConnection();
            }
           
        }
        private string Hash(string input)
        {
            byte[] temp = Encoding.UTF8.GetBytes(input);
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(temp);
                return Convert.ToBase64String(hash);
            }
        }

      
        private void UserPanel_Load_1(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }
    }
}
