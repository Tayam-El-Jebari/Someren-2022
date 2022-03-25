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
        public void AddRowTeachers(string firstname, string lastname, char gender, DateTime dateOfBirth, int activityNumber, int roomNumber)
        {
            teacherdb.AddRowTeachers(firstname, lastname, gender, dateOfBirth, activityNumber, roomNumber);
        }
        public void UpdateRowTeachers(string firstname, string lastname, char gender, DateTime dateOfBirth, int activityNumber, int roomNumber)
        {
            teacherdb.UpdateRowTeachers(firstname, lastname, gender, dateOfBirth, activityNumber, roomNumber);
        }
        public void UpdateTeachersInRow(string firstname, string newFirstname, string lastname, string newLastname)
        {
            teacherdb.UpdateTeachersInRow(firstname, newFirstname, lastname, newLastname);
        }
        public void DeleteRowTeachers(string firstname, string lastname)
        {
            teacherdb.DeleteRowTeachers(firstname, lastname);
        }
    }
}
