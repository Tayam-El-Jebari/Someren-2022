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
    }
}
