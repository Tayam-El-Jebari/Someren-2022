using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class TeacherService
    {
        private TeacherDAO teacherdb;

        public TeacherService()
        {
            teacherdb = new TeacherDAO();
        }

        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = teacherdb.GetAllTeachers();
            return teachers;
        }
    }
}
