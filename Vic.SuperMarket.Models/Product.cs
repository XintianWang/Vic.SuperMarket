namespace Vic.SuperMarket.Models
{
    /// <summary>
    /// Defines the <see cref="Product" />
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Category
        /// </summary>
        public ProductCategory Category { get; set; }

        /// <summary>
        /// Gets or sets the Price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        public string Description { get; set; }
    }
}
