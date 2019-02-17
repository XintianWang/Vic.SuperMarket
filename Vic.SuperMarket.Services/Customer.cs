using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SuperMarket.Models;

namespace Vic.SuperMarket.Services
{
    public class Customer
    {
        public ShopCart MyShopCartId { get; set; }
        public Market SuperMarket { get; set; }

        public void VisitMarket(Market market)
        {
            this.SuperMarket = market;
            this.MyShopCartId = new ShopCart();
        }

        public List<Product> ViewProducts(bool isInStock)
        {
            return this.SuperMarket
        }

        public void PickupProduct(int ProductId, int count)
        {
        }

        public void RemoveProducts(int ProductId, int count)
        {

        }

        public void ClearShopCart()
        {

        }

        public void CheckoutRequest(int CashierId)
        {

        }
    }
}
