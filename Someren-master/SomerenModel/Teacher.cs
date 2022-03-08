using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Teacher
    {
        public int TeacherID { get; set; } // LecturerNumber, e.g. 47198

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ActivityNumber { get; set; }
        public bool Supervisor {
            get;
            set;
        }

    }
}
