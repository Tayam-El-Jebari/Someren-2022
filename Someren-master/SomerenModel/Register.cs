using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Register
    {
        public string Username { get; set; }
        public string Password { get; set; }
        //does PasswordAgain need to be in the database? Or password in general
        public string PasswordAgain { get; set; }
        public string LicenseKey { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
