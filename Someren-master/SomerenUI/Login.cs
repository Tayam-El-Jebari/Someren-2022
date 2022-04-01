using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class FormLoginRegister : Form
    {
        public FormLoginRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegisterScreen formRegisterScreen = new FormRegisterScreen();
            formRegisterScreen.ShowDialog();
            this.Close(); 
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();
            try
            {
                SomerenUI somerenUIScreen = new SomerenUI(loginService.LoginUser(textBoxUsernameLogin.Text, textBoxPasswordLogin.Text));
                this.Hide();
                somerenUIScreen.ShowDialog();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBoxPasswordLogin.Clear();
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
                textBoxPasswordLogin.PasswordChar = '\0';
            else
                textBoxPasswordLogin.PasswordChar = '*';
        }
        private void buttonForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPasswordScreen forgotPassword = new ForgotPasswordScreen();
            forgotPassword.ShowDialog();
            this.Close();
        }
    }
}
