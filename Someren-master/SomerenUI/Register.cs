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
            try
            {
                if (username == "" || password == "" || passwordReenter == "" || licenseKey == "" || question == "" || answer == "")
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please make sure to enter all the data in the fields");
            }
            try
            {
                if (password != passwordReenter)
                {
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
                if (licenseKey != "XsZAb - tgz3PsD - qYh69un - WQCEx" || licenseKey != "XsZAbtgz3PsDqYh69unWQCEx" || licenseKey != "XsZAb-tgz3PsD-qYh69un-WQCEx")
                {
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
                    textBoxQuestionRegister.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You are missing a question mark in the question. Please try again");
            }
        }

        private void labelLicenseKey_Click(object sender, EventArgs e)
        {

        }
    }
}
