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
    public class OrderDAO : BaseDao
    {

        public void AddRowOrders(int productId, int studentId, DateTime dateOfPurchase)
        {
            string query = "INSERT INTO [Order](productId, studentId, dateOfPurchase)VALUES(@productId, @studentId, @dateOfPurchase)";
            SqlParameter[] sqlParameters = new SqlParameter[3]
            {
                new SqlParameter("@productId", productId),
                new SqlParameter("@studentId", studentId),
                new SqlParameter("@dateOfPurchase", dateOfPurchase)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
