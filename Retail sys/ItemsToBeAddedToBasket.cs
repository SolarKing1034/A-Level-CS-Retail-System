using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_sys
{
    class ItemsToBeAddedToBasket
    {

        public static List<string> ItemNames = new List<string>();
        public static List<decimal> IndividualItemPrices = new List<decimal>();
        public static List<int> ItemindividualQuantities = new List<int>();
        public static List<decimal> GrossPricePerItemList = new List<decimal>();

        
        public static int ItemTotalQuantities = ItemindividualQuantities.Sum(x => Convert.ToInt32(x));
        public static int NumberOfUniqueItemsPurchased = ItemNames.Count();

    }
}
