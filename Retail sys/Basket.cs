using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_sys
{
    class Basket
    {
        public static List<string> ItemInformationFromItemsToBeAddedToBasket = new List<string>();
        public static List<int> ItemQuantity = new List<int>();
        public static List<decimal> ItemPrices = new List<decimal>();


        public static int TotalQuantityOfAllItemsPurchased = 0;
        public static decimal TotalPriceOfAllItemsPurchased = 0;
        public static string CustomersName = "";
        public static int CustomersID = 0;
    }
}
