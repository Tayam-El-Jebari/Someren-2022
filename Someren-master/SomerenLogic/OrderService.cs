using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class OrderService 
    {
        private OrderDAO orderdb;

        public OrderService()
        {
            orderdb = new OrderDAO();
        }
        public void AddRowOrders(int productId, int studentId, DateTime dateOfPurchase)
        {
            orderdb.AddRowOrders(productId,  studentId,  dateOfPurchase);

        }
    }
}
