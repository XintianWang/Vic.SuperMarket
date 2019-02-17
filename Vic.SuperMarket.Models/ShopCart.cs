using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vic.SuperMarket.Models
{
    public class ShopCart
    {
        public int Id { get; set; }
        List<Item> ItemList { get; set; }

        public void AddItem(int ProductId, int count)
        {

        }

        public void RemoveItem(int ProductId, int count)
        {

        }

    }
}
