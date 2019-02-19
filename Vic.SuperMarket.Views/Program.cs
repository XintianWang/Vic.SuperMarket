namespace Vic.SuperMarket.Views
{
    using System.Collections.Generic;
    using Vic.SuperMarket.Models;
    using System.Runtime.Serialization.Json;
    using System.Runtime.Serialization;
    using System.IO;
    using Vic.SuperMarket.Services;

    /// <summary>
    /// Defines the <see cref="Program" />
    /// </summary>
    class Program
    {
        /// <summary>
        /// The Main
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/></param>
        static void Main(string[] args)
        {
            var superMarket = new Market();
            var customer1 = new Customer();
        }
    }
}
