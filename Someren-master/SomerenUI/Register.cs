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
    }
}
