using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vic.SuperMarket.Models
{
    public class Stock
    {
        List<StockItem> ItemList { get; set; }

        public void StockUp(int productId, int count)
        {

        }

        public void StockOut(int productId, int count)
        {

        }

        public void SaveToRepository()
        {

        }

        public void LoadFromRepository()
        {

        }
    }
}
