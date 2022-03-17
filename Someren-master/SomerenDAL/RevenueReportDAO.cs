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
                string query = $"SELECT D.productId, drinkName, numberOfDrinkSold, salesValue, count(S.studentId) AS customersCount FROM Drink AS D JOIN[Order] " +
                    $"as O ON d.[productId] = O.productId JOIN Student as S ON S.[studentId] = O.studentId WHERE O.dateOfPurchase between '{startDate.ToString("yyyy-MM-dd")}' " +
                    $"and '{endDate.ToString("yyyy-MM-dd")}' GROUP BY D.productId, drinkName, numberOfDrinkSold, salesvalue, S.studentid";
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
                        productId = (int)dr["productId"],
                        drinkName = (string)dr["drinkName"],
                        sales = (int)dr["numberOfDrinkSold"],
                        price = (int)dr["salesValue"],
                        numberOfCustomers = (int)dr["customersCount"],
                    };
                    revenueReport.Add(revenueReportProduct);
                }
                    return revenueReport;
            }
            catch(IndexOutOfRangeException)
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
