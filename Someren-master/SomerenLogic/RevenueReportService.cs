using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class RevenueReportService
    {
        private RevenueReportDAO revenuedb;

        public RevenueReportService()
        {
            revenuedb = new RevenueReportDAO();
        }

        public List<RevenueReport> GetRevenueReports(DateTime startDateTime, DateTime endDateTime)
        {
            List<RevenueReport> revenueReports = revenuedb.GetReport(startDateTime, endDateTime);
            return revenueReports;
        }
    }
}
