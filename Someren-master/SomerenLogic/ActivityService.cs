using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class ActivityService
    {
        private ActivityDAO activitydb;

        public ActivityService() 
        {
            activitydb = new ActivityDAO();
        }

        public List<Activity> GetDrinks()
        {
            List<Activity> activities = activitydb.GetAllActivities();
            return activities;
        }

        public void AddRowActivity(string activityName, string description, DateTime startTime, DateTime endTime)
        {
            activitydb.AddRowActivities(activityName, description, startTime, endTime);
        }

        public void UpdateRowActivity(string activityName, string description, DateTime startTime, DateTime endTime)
        {
            activitydb.UpdateRowActivities(activityName, description, startTime, endTime);
        }

        public void DeleteRowActivity(string activityName) 
        {
            activitydb.DeleteRowActivities(activityName);
        }
    }
}
