using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class TeacherDAO : BaseDao
    {
        const int FirstActivityNumber = 300;
        public List<Teacher>GetAllTeachers()
        {
            string query = "SELECT teacherID, firstname, lastname, activityNumber, roomNumber FROM [Teacher]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher();
                teacher.TeacherID = (int)dr["teacherID"];
                teacher.FirstName = (string)dr["firstName"];
                teacher.LastName = (string)dr["lastName"];
                teacher.RoomNumber = (int)dr["roomNumber"];
                // try catch because an int cannot be null. If it is null, teacher has no group assigned, thus the teacher is no supervisor.
                try
                {
                    if ((int)dr["activityNumber"] >= FirstActivityNumber)
                    {
                        teacher.Supervisor = true;
                    }
                }
                catch
                {
                    teacher.Supervisor = false;
                }
                teachers.Add(teacher);
            }
            return teachers;
                   
        }
    }
}
