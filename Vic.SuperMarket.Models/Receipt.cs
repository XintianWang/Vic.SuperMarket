namespace Vic.SuperMarket.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Receipt" />
    /// </summary>
    public class Receipt
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ItemList
        /// </summary>
        public List<ItemBrief> ItemList { get; set; }

        /// <summary>
        /// Gets or sets the TotalPrice
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Gets or sets the TransactionTime
        /// </summary>
        public DateTime TransactionTime { get; set; }

        /// <summary>
        /// Gets or sets the CashierId
        /// </summary>
        public int CashierId { get; set; }

        /// <summary>
        /// Gets or sets the PayStyle
        /// </summary>
        public PayStyle PayStyle { get; set; }

        /// <summary>
        /// The ToString
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
