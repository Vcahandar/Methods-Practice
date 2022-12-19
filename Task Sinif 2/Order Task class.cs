using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Sinif_2
{
    internal class Order_Task_class
    {
        public DateTime Date { get; set; }
        public double Price { get; set; } 

        public Order_Task_class(DateTime date, double price)
        {
            Date= date;
            Price= price;

        }

    }
}
