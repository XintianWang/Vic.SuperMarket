using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vic.SuperMarket.Models
{
    public class Receipt
    {
        public int Id { get; set; }
        public List<StockItem> ItemList { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime TransactionTime { get; set; }
        public int CashierId { get; set; }
        public PayStyle PayStyle { get; set; }

        public override string ToString()
        {
            return base.ToString();){

            }
        }
    }
}
