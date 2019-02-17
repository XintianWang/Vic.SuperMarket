using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SuperMarket.Models;

namespace Vic.SuperMarket.Services
{
    public class Market
    {
        public List<StockItem> Stock { get; set; }
        public List<Cashier> Cashiers { get; set; }
        public List<Receipt> Transactions { get; set; }

        public void Open()
        {
            //SaveToFile();
        }

        public void Close()
        {

        }
    }
}
