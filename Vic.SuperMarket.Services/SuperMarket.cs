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
        public List<Product> ProductList { get; set; }
        public ItemStock Stock { get; set; }
        public Cashier MyCashier { get; set; }
        public List<Receipt> Transactions { get; set; }

        public void InitMarket()
        {
            LoadProductList();
            LoadStock();
            LoadTransactions();
        }


        public void LoadProductList()
        {

        }

        public void LoadStock()
        {

        }

        public void SaveStock()
        {

        }

        public void LoadTransactions()
        {

        }

        public void SaveTransactions()
        {

        }



        public object ShowItems(ProductCategory category, bool isOnlyInStock)
        {
            if (isOnlyInStock)
            {
                return Stock.Items.Join(ProductList.Where(product => product.Category == category), 
                    item => item.ProductId, 
                    product => product.Id, 
                    (item, product) => new
                    {
                        product,
                        productCount = item.ProductCount
                    });
            }
            else
            {
                return ProductList.Where(product => product.Category == category).Join(Stock.Items, 
                    product => product.Id, 
                    item => item.ProductId, 
                    (product, item) => new {
                        product,
                        productCount = item?.ProductCount ?? 0
                    });
            }
        }

        public object ShowAllItems(bool isOnlyInStock)
        {
            if (isOnlyInStock)
            {
                return Stock.Items.Join(ProductList,
                    item => item.ProductId,
                    product => product.Id,
                    (item, product) => new
                    {
                        product,
                        productCount = item.ProductCount
                    });
            }
            else
            {
                return ProductList.Join(Stock.Items,
                    product => product.Id,
                    item => item.ProductId,
                    (product, item) => new {
                        product,
                        productCount = item?.ProductCount ?? 0
                    });
            }
        }
    }
}
