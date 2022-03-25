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

        public List<Activity> GetActivity()
        {
            List<Activity> activities = activitydb.GetAllActivities();
            return activities;
        }
        public List<Student> GetParticipants(int activityNumber)
        {
            return activitydb.GetAllParticipants(activityNumber);
        }

        public void AddRowActivity(string activityName, string description, DateTime startTime, DateTime endTime)
        {
            activitydb.AddRowActivities(activityName, description, startTime, endTime);
        }

        public void UpdateRowActivity(string activityName, string description, DateTime startTime, DateTime endTime)
        {
            activitydb.UpdateRowActivities(activityName, description, startTime, endTime);
        }

        public void DeleteRowActivity(string activityNumber)
        {
            activitydb.DeleteRowActivities(activityNumber);
        }
        public void AddParticipant(int studentId, int activityNumber)
        {
            activitydb.AddParticipant(studentId, activityNumber);
        }
        public void DeleteParticipant(int studentId, int activityNumber)
        {
            activitydb.DeleteRowParticipant(studentId, activityNumber);
        }
        public List<Teacher> GetSupervisors(int activityNumber)
        {
            return activitydb.GetAllSupervisors(activityNumber);
        }
        public void AddSupervisor(int teacherId, int activityNumber)
        {
            activitydb.AddParticipant(teacherId, activityNumber);
        }
        public void DeleteSupervisor(int teacherId, int activityNumber)
        {
            activitydb.DeleteRowParticipant(teacherId, activityNumber);
        }
    }
}
