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
using SomerenLogic;
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
            labelDisplayQuestion.Hide();
            labelQuestionLabel.Hide();
            labelAnswerLabel.Hide();
            textBoxAnswerForgotPassword.Hide();
            labelEnterNewPasswordLabel.Hide();
            labelConfirmNewPasswordLabel.Hide();
            textBoxNewPassword.Hide();
            textBoxConfirmPassword.Hide();
            buttonNewPassword.Hide();
            buttonCodeForgotPassword.Hide();

        }

        private void buttonNewPassword_Click(object sender, EventArgs e)
        {
            string username = textBoxUsernameForgotPassword.Text;
            string newPassword = textBoxNewPassword.Text;
            string confirmNewPassword = textBoxConfirmPassword.Text;
            buttonNewPassword.Show();

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
                    ForgotPasswordService forgotPasswordService = new ForgotPasswordService();
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
                if (username == "")
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
                    buttonCodeForgotPassword.Hide();
                    buttonNewPassword.Hide();

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

        private void buttonQuestionLoad_Click(object sender, EventArgs e)
        {
            string username = textBoxUsernameForgotPassword.Text;

            labelDisplayQuestion.Show();
            labelQuestionLabel.Show();
            labelAnswerLabel.Show();
            textBoxAnswerForgotPassword.Show();
            labelEnterNewPasswordLabel.Hide();
            labelConfirmNewPasswordLabel.Hide();
            textBoxNewPassword.Hide();
            textBoxConfirmPassword.Hide();
            buttonNewPassword.Hide();
            buttonCodeForgotPassword.Show();
            ForgotPassword password = new ForgotPassword();
            if (textBoxUsernameForgotPassword.Text == password.Username)
            {
                labelDisplayQuestion.Text = password.Question;
                string inputAnswer = textBoxAnswerForgotPassword.Text;
                if (inputAnswer == password.Answer)
                {
                    CanPushbuttonCodeForgotPassword = true;
                }
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
            ForgotPasswordService acc = new ForgotPasswordService();

            labelDisplayQuestion.Text = acc.Question(username);

        }
    }
}
