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
            buttonQuestionLoad.Show();


        }

        private void buttonNewPassword_Click(object sender, EventArgs e)
        {

                string username = textBoxUsernameForgotPassword.Text;
                string newPassword = textBoxNewPassword.Text;
                string confirmNewPassword = textBoxConfirmPassword.Text;
                buttonNewPassword.Show();


                if (username == "" || newPassword == "" || confirmNewPassword == "")
                {
                    MessageBox.Show("Please make sure to enter all the data in the fields");
                    return;
                }
                else if (!username.Contains('@'))
                {
                    MessageBox.Show("Please make sure to enter a valid email address. You are missing an '@' ");
                    return;
                }
                else if (newPassword == confirmNewPassword)
                {
                    ForgotPasswordService forgotPasswordService = new ForgotPasswordService();
                    forgotPasswordService.UpdatePassword(username, newPassword);
                    MessageBox.Show("You have successfully changed your password, you will now be redirected to the loginpage");
                    this.Hide();
                    FormLoginRegister loginPage = new FormLoginRegister();
                    loginPage.ShowDialog();
                    this.Close();
                }
                /*else
                {
                    MessageBox.Show("Something went wrong while changing your password, please try again");
                    textBoxNewPassword.Clear();
                    textBoxConfirmPassword.Clear();
                }*/

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
                    buttonNewPassword.Show();
                    buttonQuestionLoad.Hide();

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
                else
                {
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
                    buttonQuestionLoad.Hide();
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
