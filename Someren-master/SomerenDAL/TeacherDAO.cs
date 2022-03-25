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
            string query = "SELECT teacherID, firstname, lastname, gender, dateOfbirth, activityNumber, roomNumber FROM [Teacher]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddRowTeachers(string firstname, string lastname, char gender, DateTime dateOfBirth, int activityNumber, int roomNumber)
        {
            string query = string.Empty;
                query = "INSERT INTO [Teacher](firstname, lastname, gender, dateOfbirth, activityNumber, roomNumber) VALUES(@firstname, @lastname, @gender, @dateOfbirth, @activityNumber, @roomNumber)";
            SqlParameter[] sqlParameters = new SqlParameter[6]
            {
            new SqlParameter("@firstname", firstname),
            new SqlParameter("@lastname", lastname),
            new SqlParameter("@gender", gender),
            new SqlParameter("@dateOfbirth", dateOfBirth),
            new SqlParameter("@activityNumber", activityNumber),
            new SqlParameter("@roomNumber", roomNumber)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateRowTeachers(string firstname, string lastname, char gender, DateTime dateOfBirth, int activityNumber, int roomNumber)
        {
            string query = $"UPDATE Teacher SET firstname=@firstname, lastname=@lastname, activityNumber=@activityNumber, roomNumber =@roomNumber WHERE firstname=@firstname AND lastname=@lastname";
            SqlParameter[] sqlParameters = new SqlParameter[6]
            {
            new SqlParameter("@firstname", firstname),
            new SqlParameter("@lastname", lastname),
            new SqlParameter("@gender", gender),
            new SqlParameter("@dateOfbirth", dateOfBirth),
            new SqlParameter("@activityNumber", activityNumber),
            new SqlParameter("@roomNumber", roomNumber) 
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateTeachersInRow(string firstname, string newFirstname, string lastname, string newLastname)
        {
            string query = "UPDATE Teacher SET firstname=@firstname, lastname=@lastname WHERE firstname=@firstname AND lastname=@lastname";
            SqlParameter[] sqlParameters = new SqlParameter[4] 
            {
            new SqlParameter("@newFirstname", newFirstname),
            new SqlParameter("@firstname", firstname),
            new SqlParameter("@newLastname", newLastname),
            new SqlParameter("@lastname", lastname)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        // Delete Row
        public void DeleteRowTeachers(string firstname, string lastname)
        {
            string query = $"DELETE FROM Teacher WHERE firstname=@firstname AND lastname=@lastname";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
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
