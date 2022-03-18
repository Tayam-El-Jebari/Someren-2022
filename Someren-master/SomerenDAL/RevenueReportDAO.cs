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
    public class RevenueReportDAO : BaseDao
    {
        public List<RevenueReport> GetReport(DateTime startDate, DateTime endDate)
        {
            try
            {
                string query = $"Select COUNT(ORDERID) AS sales, SUM(salesValue) AS [turn over], count(DISTINCT o.studentId) AS countOfStudents " +
                    $"FROM [ORDER] AS O JOIN drink AS d ON O.productId = d.productID WHERE dateOfPurchase between " +
                    $"'{startDate.ToString("yyyy-MM-dd")}' and '{endDate.ToString("yyyy-MM-dd")}'";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters), startDate, endDate);
            }
            catch (Exception e)
            {
                throw new Exception("Reports could not be loaded properly. Error : \n" + e.Message);
            }
        }
        public List<RevenueReport> GetReportR(DateTime startDate, DateTime endDate)
        {
            try
            {
                string query = $"Select COUNT(ORDERID) AS sales, SUM(salesValue) AS [turn over], count(DISTINCT o.studentId) AS countOfStudents " +
                    $"FROM [ORDER] AS O JOIN drink AS d ON O.productId = d.productID WHERE dateOfPurchase between " +
                    $"'{startDate.ToString("yyyy-MM-dd")}' and '{endDate.ToString("yyyy-MM-dd")}'";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters), startDate, endDate);
            }
            catch (Exception e)
            {
                throw new Exception("Reports could not be loaded properly. Error : \n" + e.Message);
            }
        }
        private List<RevenueReport> ReadTables(DataTable dataTable, DateTime startDate, DateTime endDate)
        {
            try
            {
                List<RevenueReport> revenueReport = new List<RevenueReport>();
                foreach (DataRow dr in dataTable.Rows)
                {
                    RevenueReport revenueReportProduct = new RevenueReport()
                    {
                        sales = (int)dr["sales"],
                        turnOver = (int)dr["turn over"],
                        numberOfCustomers = (int)dr["countOfstudents"],
                    };
                    revenueReport.Add(revenueReportProduct);
                }
                    return revenueReport;
            }
            catch(InvalidCastException)
            {
                throw new Exception($"No sales found in database in the date range {startDate.ToString("yyyy-MM-dd")} to {endDate.ToString("yyyy-MM-dd")}");
            }
            catch (Exception e)
            {

                throw new Exception("Data could not be retrieved from the database. Please try agian" + e.Message);
            }

        }
    }
}
