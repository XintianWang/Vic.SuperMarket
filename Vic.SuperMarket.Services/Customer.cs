namespace Vic.SuperMarket.Services
{
    using System;
    using Vic.SuperMarket.Models;

    /// <summary>
    /// Defines the <see cref="Customer" />
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the MyShopCart
        /// </summary>
        public ItemList MyShopCart { get; set; }

        /// <summary>
        /// Gets or sets the SuperMarket
        /// </summary>
        public Market SuperMarket { get; set; }

        /// <summary>
        /// The VisitMarket
        /// </summary>
        /// <param name="market">The market<see cref="Market"/></param>
        public void VisitMarket(Market market)
        {
            this.SuperMarket = market;
            this.MyShopCart = new ItemList();
        }

        /// <summary>
        /// The ViewProducts
        /// </summary>
        /// <param name="isOnlyInStock">The isOnlyInStock<see cref="bool"/></param>
        public void ViewProducts(bool isOnlyInStock)
        {
            var products = SuperMarket.ShowAllItems(isOnlyInStock);
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Product.Id} {item.Product.Name} {item.Product.Price} {item.Product.Category} {item.Product.Description} {item.ProductCount}");
            }
        }

        /// <summary>
        /// The ViewProducts
        /// </summary>
        /// <param name="category">The category<see cref="ProductCategory"/></param>
        /// <param name="isOnlyInStock">The isOnlyInStock<see cref="bool"/></param>
        public void ViewProducts(ProductCategory category, bool isOnlyInStock)
        {
            var products = SuperMarket.ShowItems(category, isOnlyInStock);
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Product.Id} {item.Product.Name} {item.Product.Price} {item.Product.Category} {item.Product.Description} {item.ProductCount}");
            }
        }

        /// <summary>
        /// The PickupProduct
        /// </summary>
        /// <param name="productId">The productId<see cref="int"/></param>
        /// <param name="count">The count<see cref="int"/></param>
        public void PickupProduct(int productId, int count)
        {
            try
            {
                SuperMarket.Stock.RemoveItem(productId, count);
            }
            catch (Exception e)
            {
                //handle exception
                Console.WriteLine(e.Message);
                return;
            }
            MyShopCart.AddItem(productId, count);
        }

        /// <summary>
        /// The RemoveProducts
        /// </summary>
        /// <param name="productId">The productId<see cref="int"/></param>
        /// <param name="count">The count<see cref="int"/></param>
        public void RemoveProducts(int productId, int count)
        {
            try
            {
                MyShopCart.RemoveItem(productId, count);
            }
            catch (Exception e)
            {
                //handle exception
                Console.WriteLine(e.Message);
                return;
            }
            SuperMarket.Stock.AddItem(productId, count);
        }

        /// <summary>
        /// The ClearShopCart
        /// </summary>
        public void ClearShopCart()
        {
            foreach (var item in MyShopCart.Items)
            {
                RemoveProducts(item.ProductId, item.ProductCount);
            }
        }

        /// <summary>
        /// The CheckoutRequest
        /// </summary>
        /// <param name="CashierId">The CashierId<see cref="int"/></param>
        public void CheckoutRequest(int CashierId)
        {
        }
    }
}
