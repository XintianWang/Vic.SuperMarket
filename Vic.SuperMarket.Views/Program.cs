using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SuperMarket.Services;

namespace Vic.SuperMarket.Views
{
    class Program
    {
        static void Main(string[] args)
        {
            var superMarket = new Market();
            superMarket.Open();
            while (true)
            {

            }
        }
    }
}
