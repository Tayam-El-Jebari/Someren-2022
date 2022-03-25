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
    public class ActivityDAO : BaseDao
    {
        // change SQL? (ID, Description, StartDateTime, EndDateTime) are the necessary tables for the assignment
        public List<Activity> GetAllActivities()
        {
            // change attributes
            string query = "SELECT activityNumber, activityName, description, startDateTime, endDateTime FROM [Activity]";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesActivity(ExecuteSelectQuery(query, sqlParameters));

        }
        public List<Student> GetAllParticipants(int activityNumber)
        {
            string query = $"SELECT studentID, firstname, lastName FROM Student WHERE studentID IN (SELECT studentId FROM [Participates_In] WHERE ActivityNumber = @activityNumber)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@activityNumber", activityNumber);
            return ReadTablesParticipants(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddParticipant(int studentId, int activityNumber)
        {
            string query = "SELECT STUDENTID, ACTIVITYNUMBER FROM Participates_In GROUP BY studentID, ActivityNumber HAVING studentId = @studentId AND activityNumber = @activityNumber";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@activityNumber", activityNumber);
            sqlParameters[1] = new SqlParameter("@studentId", studentId);
            if(ExecuteSelectQuery(query, sqlParameters).Rows.Count == 0)

            {
                string queryToAdd = "INSERT INTO Participates_In VALUES(@studentId, @activityNumber)";
                SqlParameter[] sqlParametersForAdding = new SqlParameter[2];
                sqlParametersForAdding[0] = new SqlParameter("@activityNumber", activityNumber);
                sqlParametersForAdding[1] = new SqlParameter("@studentId", studentId);
                ExecuteSelectQuery(queryToAdd, sqlParametersForAdding);
            }
            else
            {
                throw new Exception("The student has already been added to this activity!");
            }
        }
        public void DeleteRowParticipant(int studentId, int activityNumber)
        {
            string query = "DELETE FROM Participates_In WHERE (studentId = @studentId) AND (activityNumber = @activityNumber)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@activityNumber", activityNumber);
            sqlParameters[1] = new SqlParameter("@studentId", studentId);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void AddRowActivities(string activityName, string description, DateTime startTime, DateTime endTime)
        {
            string query = "INSERT INTO [Activity](ActivityName, [description], StartDateTime, EndDateTime) VALUES (@activityName, @description, @StartDateTime, @EndDateTime)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@activityName", activityName);
            sqlParameters[1] = new SqlParameter("@description", description);
            sqlParameters[2] = new SqlParameter("@StartDateTime", startTime);
            sqlParameters[3] = new SqlParameter("@EndDateTime", endTime);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateRowActivities(string activityName, string description, DateTime startTime, DateTime endTime)
        {
            string query = $"UPDATE Activity SET activityName=@activityName, [description]=@description, StartDateTime=@StartDateTime, EndDateTime=@EndDateTime WHERE activityName=@activityName";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@activityName", activityName);
            sqlParameters[1] = new SqlParameter("@description", description);
            sqlParameters[2] = new SqlParameter("@StartDateTime", startTime);
            sqlParameters[3] = new SqlParameter("@EndDateTime", endTime);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteRowActivities(string activityNumber)
        {
            string query = $"DELETE FROM Activity WHERE activityNumber=@activityNumber";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@activityNumber", activityNumber);
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Activity> ReadTablesActivity(DataTable dataTable)
        {
            try
            {
                List<Activity> activities = new List<Activity>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    Activity activity = new Activity()
                    {
                        ActivityNumber = (int)dr["activityNumber"],
                        ActivityName = (string)dr["activityName"],

                        Description = (string)dr["description"],
                        StartDateTime = (DateTime)dr["startDateTime"],
                        EndDateTime = (DateTime)dr["endDateTime"]
                    };
                    activities.Add(activity);
                };
                return activities;
            }
            catch (Exception e)
            {
                throw new Exception("Data could not be retrieved from the database. Please try again" + e.Message);
            }
        }
        private List<Student> ReadTablesParticipants(DataTable dataTable)
        {
            try
            {
                List<Student> studentsParticipating = new List<Student>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    Student student = new Student()
                    {
                        StudentId = (int)dr["studentID"],
                        FirstName = (string)dr["firstname"],
                        LastName = (string)dr["lastName"],
                    };
                    studentsParticipating.Add(student);
                };
                return studentsParticipating;
            }
            catch (Exception e)
            {
                throw new Exception("Data could not be retrieved from the database. Please try again" + e.Message);
            }
        }
        public List<Teacher> GetAllSupervisors(int activityNumber)
        {
            string query = $"SELECT teacherId, firstname, lastName FROM Teacher WHERE teacherID IN (SELECT teacherId FROM [Supervised_By] WHERE ActivityNumber = @activityNumber)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@activityNumber", activityNumber);
            return ReadTablesSupervisor(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddSupervisor(int teacherId, int activityNumber)//moet nog bij dat er max 1 supervisor mag zijn
        {
            string query = "SELECT TEACHERID, ACTIVITYNUMBER FROM Supervised_By GROUP BY teacherID, ActivityNumber HAVING teacherId = @teacherId AND activityNumber = @activityNumber";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@activityNumber", activityNumber);
            sqlParameters[1] = new SqlParameter("@teacherId", teacherId);
            if (ExecuteSelectQuery(query, sqlParameters).Rows.Count == 0)//misschien dit
            {
                string queryToAdd = "INSERT INTO Supervised_By VALUES(@teacherId, @activityNumber)";
                SqlParameter[] sqlParametersForAdding = new SqlParameter[2];
                sqlParametersForAdding[0] = new SqlParameter("@activityNumber", activityNumber);
                sqlParametersForAdding[1] = new SqlParameter("@teacherId", teacherId);
                ExecuteSelectQuery(queryToAdd, sqlParametersForAdding);
            }
            else
            {
                throw new Exception("There is already a supervisor!");
            }
        }
        public void DeleteRowSupervisor(int teacherId, int activityNumber)
        {
            string query = "DELETE FROM Supervised_By WHERE (teacherId = @teacherId) AND (activityNumber = @activityNumber)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@activityNumber", activityNumber);
            sqlParameters[1] = new SqlParameter("@teacherId", teacherId);
            ExecuteEditQuery(query, sqlParameters);
        }
        private List<Teacher> ReadTablesSupervisor(DataTable dataTable)
        {
            try
            {
                List<Teacher> teacherParticipating = new List<Teacher>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    Teacher teacher = new Teacher()
                    {
                        TeacherID = (int)dr["teacherID"],
                        FirstName = (string)dr["firstname"],
                        LastName = (string)dr["lastName"],
                    };
                    teacherParticipating.Add(teacher);
                };
                return teacherParticipating;
            }
            catch (Exception e)
            {
                throw new Exception("Data could not be retrieved from the database. Please try again" + e.Message);
            }
        }
    }
}
