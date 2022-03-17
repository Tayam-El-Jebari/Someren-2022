using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class RevenueReport
    {

        public int sales { get; set; }
        
        public int price { get; set; }

        public int turnover { get { return (sales * price); } set { } }

        public int numberOfCustomers {get; set;}


    }
}
