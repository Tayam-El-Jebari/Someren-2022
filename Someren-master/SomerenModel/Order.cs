using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public Order(int productId, int studentId, DateTime dateOfPurchase)
        {
            ProductId = productId;
            StudentId = studentId;
            DateOfPurchase = dateOfPurchase;
        }
        public Order()
        {

        }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int StudentId { get; set; }
        public DateTime DateOfPurchase { get; set; }
    }


}
