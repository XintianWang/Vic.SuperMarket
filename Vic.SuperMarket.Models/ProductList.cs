namespace Vic.SuperMarket.Models
{
    using System.Collections.Generic;
    using System.Runtime.Serialization.Json;
    using System.Runtime.Serialization;
    using System.IO;

    /// <summary>
    /// Defines the <see cref="ProductList" />
    /// </summary>
    public class ProductList
    {
        /// <summary>
        /// Gets or sets the Products
        /// </summary>
        public List<Product> Products { get;}

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductList"/> class.
        /// </summary>
        public ProductList()
        {
            DataContractJsonSerializer deseralizer = new DataContractJsonSerializer(typeof(List<Product>));
            using (FileStream jsonFile = File.OpenRead($"products.json"))
            {
                //jsonFile.Position = 0;
                Products = deseralizer.ReadObject(jsonFile) as List<Product>;
            }
        }
    }
}
