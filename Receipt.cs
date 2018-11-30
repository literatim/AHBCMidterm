using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    class Receipt
    {
        public List<Menu> ItemsPurchased { get; set; }
        public double Taxes { get; set; }
        public double Subtotal { get; set; }
        public double GrandTotal { get; set; }
        public object PaymentDetails { get; set; }


        public static Receipt CreateReceipt(List<Menu> itemsPurchased, double orderTotal, double taxOwed, double grandTotal, object paymentDetails)
        {
            var orderReceipt = new Receipt
            {
                ItemsPurchased = itemsPurchased,
                Taxes = taxOwed,
                Subtotal = orderTotal,
                GrandTotal = grandTotal,
                PaymentDetails = paymentDetails
            };

            return orderReceipt;
        }
    }
}
