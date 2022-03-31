using SomerenDAL;
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
            string firstName = textBoxFirstnameRegister.Text;
            string lastName = textBoxLastnameRegister.Text;
            string email = textBoxUsernameRegister.Text;
            string password = textBoxPasswordRegister.Text;
            string passwordReenter = textBoxPasswordReenterRegister.Text;
            string licenseKey = textBoxLicenseKey.Text;
            string question = textBoxQuestionRegister.Text;
            string answer = textBoxAnswerRegister.Text;
            string correctLicenseKey = "XsZAb - tgz3PsD - qYh69un - WQCEx";
            try
            {
                if (firstName == "" || lastName == "" || email == "" || password == "" || passwordReenter == "" || licenseKey == "" || question == "" || answer == "")
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
                if (!email.Contains('@'))
                {
                    MessageBox.Show("Please make sure to enter a valid email address. You are missing an '@' ");
                    textBoxUsernameRegister.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please make sure to enter a valid email address. You are missing an '@' ");
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
                if (licenseKey != correctLicenseKey)
                {
                    MessageBox.Show("This is not the right license key! Please try again. Make sure you enter the licensekey as following" +
                        " 'XXXXX - XXXXX - XXXXX - XXXXX'");
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

            RegisterDAO registerDAO = new RegisterDAO();
            registerDAO.AddRowRegister(firstName, lastName, email, password, question, answer);
        }

    }
}
