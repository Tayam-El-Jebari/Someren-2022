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
    class ActivityDAO : BaseDao
    {
        // change SQL? (ID, Description, StartDateTime, EndDateTime) are the necessary tables for the assignment
        public List<Activity> GetAllActivities() 
        {
            try
            {
                // change attributes? 
                string query = "SELECT ..., ..., ..., ..., FROM [Activity] ";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddRowActivities(string description, DateTime startTime, DateTime endTime) 
        {
            string query = "INSERT INTO [Activity](Description, StartDateTime, EndDateTime) VALUES (@Description, @StartDateTime, @EndDateTime)";
            SqlParameter[] sqlParameter = new SqlParameter[3];
            sqlParameter[0] = new SqlParameter("@Description", description);
            sqlParameter[1] = new SqlParameter("@StartDateTime", startTime);
            sqlParameter[1] = new SqlParameter("@EndDateTime", endTime);
            ExecuteEditQuery(query, sqlParameter);
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            try
            {
                List<Activity> activities = new List<Activity>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    Activity activity = new Activity()
                    {
                        ActivityID = (int)dr["activityID"],
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
    }
}
