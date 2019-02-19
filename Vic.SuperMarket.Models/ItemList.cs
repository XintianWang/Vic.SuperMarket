namespace Vic.SuperMarket.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="Models.ItemList" />
    /// </summary>
    public class ItemList
    {
        /// <summary>
        /// Gets or sets the Items
        /// </summary>
        public List<ItemBrief> Items { get; set; }

        /// <summary>
        /// The AddItem
        /// </summary>
        /// <param name="productId">The productId<see cref="int"/></param>
        /// <param name="productCount">The count<see cref="int"/></param>
        public void AddItem(int productId, int productCount)
        {
            var item = Items.FirstOrDefault(i => i.ProductId == productId);
            if (item == null)
            {
                Items.Add(new ItemBrief { ProductId = productId, ProductCount = productCount });
            }
            else
            {
                item.ProductCount += productCount;
            }
        }

        /// <summary>
        /// The RemoveItem
        /// </summary>
        /// <param name="productId">The ProductId<see cref="int"/></param>
        /// <param name="productCount">The count<see cref="int"/></param>
        public void RemoveItem(int productId, int productCount)
        {
            var item = Items.FirstOrDefault(i => i.ProductId == productId);
            if (item == null)
            {
                throw new ArgumentNullException("producd_Id", "There is no such product.");
            }
            else if (item.ProductCount < productCount)
            {
                throw new InvalidOperationException("There is no enough product.");
            }
            else if (item.ProductCount == productCount)
            {
                Items.Remove(item);
            }
            else
            {
                item.ProductCount -= productCount;
            }
        }
    }
}
