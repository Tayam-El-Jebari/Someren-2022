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
    public partial class ForgotPasswordScreen : Form
    {
        public ForgotPasswordScreen()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

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
                if (newPassword != confirmNewPassword)
                {
                    MessageBox.Show("Password is not the same, please try again");
                    textBoxNewPassword.Clear();
                    textBoxConfirmPassword.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Password is not the same, please try again");
            }
        }

        private void buttonCodeForgotPassword_Click(object sender, EventArgs e)
        {
            U
            labelDisplayQuestion = ;
            if (textBoxUsernameForgotPassword.Text == )

        }

    }
}
