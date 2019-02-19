namespace Vic.SuperMarket.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Vic.SuperMarket.Models;

    /// <summary>
    /// Defines the <see cref="Market" />
    /// </summary>
    public class Market
    {
        /// <summary>
        /// Gets or sets the AllProducts
        /// </summary>
        public ProductList AllProducts { get; set; }

        /// <summary>
        /// Gets or sets the Stock
        /// </summary>
        public ItemList Stock { get; set; }

        /// <summary>
        /// Gets or sets the MyCashier
        /// </summary>
        public Cashier MyCashier { get; set; }

        /// <summary>
        /// Gets or sets the Transactions
        /// </summary>
        public List<Receipt> Transactions { get; set; }

        public Market()
        {
            AllProducts = new ProductList();
        }
        /// <summary>
        /// The LoadProductList
        /// </summary>
        public void LoadProductList()
        {
        }

        /// <summary>
        /// The LoadStock
        /// </summary>
        public void LoadStock()
        {
        }

        /// <summary>
        /// The SaveStock
        /// </summary>
        public void SaveStock()
        {
        }

        /// <summary>
        /// The LoadTransactions
        /// </summary>
        public void LoadTransactions()
        {
        }

        /// <summary>
        /// The SaveTransactions
        /// </summary>
        public void SaveTransactions()
        {
        }

        /// <summary>
        /// The ShowItems
        /// </summary>
        /// <param name="category">The category<see cref="ProductCategory"/></param>
        /// <param name="isOnlyInStock">The isOnlyInStock<see cref="bool"/></param>
        /// <returns>The <see cref="List{ItemDetailView}"/></returns>
        public List<ItemDetailView> ShowItems(ProductCategory category, bool isOnlyInStock)
        {
            if (isOnlyInStock)
            {
                return Stock.Items.Join(AllProducts.Products.Where(product => product.Category == category),
                    item => item.ProductId,
                    product => product.Id,
                    (item, product) => new ItemDetailView
                    {
                        Product = product,
                        ProductCount = item.ProductCount
                    }) as List<ItemDetailView>;
            }
            else
            {
                return AllProducts.Products.Where(product => product.Category == category).Join(Stock.Items,
                    product => product.Id,
                    item => item.ProductId,
                    (product, item) => new ItemDetailView
                    {
                        Product = product,
                        ProductCount = item?.ProductCount ?? 0
                    }) as List<ItemDetailView>;
            }
        }

        /// <summary>
        /// The ShowAllItems
        /// </summary>
        /// <param name="isOnlyInStock">The isOnlyInStock<see cref="bool"/></param>
        /// <returns>The <see cref="List{ItemDetailView}"/></returns>
        public List<ItemDetailView> ShowAllItems(bool isOnlyInStock)
        {
            if (isOnlyInStock)
            {
                return Stock.Items.Join(AllProducts.Products,
                    item => item.ProductId,
                    product => product.Id,
                    (item, product) => new ItemDetailView
                    {
                        Product = product,
                        ProductCount = item.ProductCount
                    }) as List<ItemDetailView>;
            }
            else
            {
                return AllProducts.Products.Join(Stock.Items,
                    product => product.Id,
                    item => item.ProductId,
                    (product, item) => new ItemDetailView
                    {
                        Product = product,
                        ProductCount = item?.ProductCount ?? 0
                    }) as List<ItemDetailView>;
            }
        }
    }
}
