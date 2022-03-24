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
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

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

        // maybe the where needs to be changed. Will take a look later
        public void UpdateRowActivities(string activityName, string description, DateTime startTime, DateTime endTime)
        {
            string query = $"UPDATE Activity SET activityName=@activityName, description=@description, startTime=@startTime, endTime=@endTime WHERE activityNumber=@activityNumber";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@activityName", activityName);
            sqlParameters[1] = new SqlParameter("@description", description);
            sqlParameters[2] = new SqlParameter("@startTime", startTime);
            sqlParameters[3] = new SqlParameter("@endTime", endTime);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteRowActivities(string activityNumber)
        {
            string query = $"DELETE FROM Activity WHERE activityNumber=@activityNumber";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@activityNumber", activityNumber);
            ExecuteEditQuery(query, sqlParameters);
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
    }
}
