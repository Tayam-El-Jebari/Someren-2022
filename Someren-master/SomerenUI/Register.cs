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
    public partial class FormRegisterScreen : Form
    {
        public FormRegisterScreen()
        {
            InitializeComponent();
        }

        private void FormRegisterScreen_Load(object sender, EventArgs e)
        {

        }

        private void buttonBackTologin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoginRegister formLoginRegister = new FormLoginRegister();
            formLoginRegister.ShowDialog();
            this.Close();
        }

        private void buttonRegisterRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxUsernameRegister.Text;
            string password = textBoxPasswordRegister.Text;
            string passwordReenter = textBoxPasswordReenterRegister.Text;
            string licenseKey = textBoxLicenseKey.Text;
            string question = textBoxQuestionRegister.Text;
            string answer = textBoxAnswerRegister.Text;
            string correctLicenseKey = "XsZAbtgz3PsDqYh69unWQCEx";
            string correctLicenseKeyAlternative = "XsZAb-tgz3PsD-qYh69un-WQCEx";
            string correctLicenseKeyAlternative2 = "XsZAb - tgz3PsD - qYh69un - WQCEx";
            try
            {
                if (username == "" || password == "" || passwordReenter == "" || licenseKey == "" || question == "" || answer == "")
                {
                    MessageBox.Show("Please make sure to enter all the data in the fields");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please make sure to enter all the data in the fields");
            }
            try
            {
                if (!username.Contains('@'))
                {
                    MessageBox.Show("Please make sure to enter a valid email address. You are missing an '@' ");
                }
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                if (password != passwordReenter)
                {
                    MessageBox.Show("Password is not the same, please try again");
                    textBoxPasswordRegister.Clear();
                    textBoxPasswordReenterRegister.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Password is not the same, please try again");
            }
            try
            {
                if (licenseKey == correctLicenseKey || licenseKey == correctLicenseKeyAlternative || licenseKey == correctLicenseKeyAlternative2)
                {

                }
                else
                {
                    MessageBox.Show("This is not the right license key! Please try again");
                    textBoxLicenseKey.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("This is not the right license key! Please try again");
            }
            try
            {
                if (!question.Contains('?'))
                {
                    MessageBox.Show("You are missing a question mark in the question. Please try again");
                    textBoxQuestionRegister.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You are missing a question mark in the question. Please try again");
            }
        }

    }
}
