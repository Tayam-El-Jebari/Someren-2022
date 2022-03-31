using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenDAL;
using SomerenModel;

namespace SomerenUI
{
    public partial class ForgotPasswordScreen : Form
    {
        public bool CanPushbuttonCodeForgotPassword;
        public ForgotPasswordScreen()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            ForgotPassword password = new ForgotPassword();
            labelDisplayQuestion.Show();
            labelQuestionLabel.Show();
            labelAnswerLabel.Show();
            textBoxAnswerForgotPassword.Show();
            labelEnterNewPasswordLabel.Hide();
            labelConfirmNewPasswordLabel.Hide();
            textBoxNewPassword.Hide();
            textBoxConfirmPassword.Hide();
            buttonNewPassword.Hide();
            if (textBoxUsernameForgotPassword.Text == password.Username)
            {
                labelDisplayQuestion.Text = password.Question;
                string inputAnswer = textBoxAnswerForgotPassword.Text;
                if (inputAnswer == password.Answer)
                {
                    CanPushbuttonCodeForgotPassword = true;
                }
            }
        }

        private void buttonNewPassword_Click(object sender, EventArgs e)
        {
            string username = textBoxUsernameForgotPassword.Text;
            string newPassword = textBoxNewPassword.Text;
            string confirmNewPassword = textBoxConfirmPassword.Text;
            try
            {
                if (username == "" || newPassword == "" || confirmNewPassword == "")
                {
                    MessageBox.Show("Please make sure to enter all the data in the fields");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please make sure to enter all the data in the fields");
                return;

            }
            try
            {
                if (!username.Contains('@'))
                {
                    MessageBox.Show("Please make sure to enter a valid email address. You are missing an '@' ");
                    return;

                }
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                if (newPassword != confirmNewPassword)
                {
                    MessageBox.Show("Password is not the same, please try again");
                    textBoxNewPassword.Clear();
                    textBoxConfirmPassword.Clear();
                }
                else
                {
                    ForgotPassword password = new ForgotPassword();
                    ForgotPasswordDAO forgotPasswordDAO = new ForgotPasswordDAO();
                    forgotPasswordDAO.UpdatePassword(password.Password, newPassword);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Password is not the same, please try again");
            }
        }

        private void buttonCodeForgotPassword_Click(object sender, EventArgs e)
        {
            string username = textBoxUsernameForgotPassword.Text;
            string newPassword = textBoxNewPassword.Text;
            string confirmNewPassword = textBoxConfirmPassword.Text;

            try
            {
                if (username == "" || newPassword == "" || confirmNewPassword == "")
                {
                    MessageBox.Show("Please make sure to enter all the data in the fields");
                    return;

                }
                else
                {
                    labelDisplayQuestion.Hide();
                    labelQuestionLabel.Hide();
                    labelAnswerLabel.Hide();
                    textBoxAnswerForgotPassword.Hide();
                    labelEnterNewPasswordLabel.Show();
                    labelConfirmNewPasswordLabel.Show();
                    textBoxNewPassword.Show();
                    textBoxConfirmPassword.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please make sure to enter all the data in the fields");
                return;

            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
