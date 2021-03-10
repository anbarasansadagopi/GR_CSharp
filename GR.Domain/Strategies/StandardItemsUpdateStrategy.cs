using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Domain
{
    public class StandardItemsUpdateStrategy : IStockItemUpdateStrategy
    {
        public void UpdateItem(Item item)
        {
            item.SellIn--;
            if (item.Quality > 0)
                item.Quality--;
            if (item.SellIn < 0)
            {
                if (item.Quality > 0)
                     item.Quality--;
            }
        }
    }
}
