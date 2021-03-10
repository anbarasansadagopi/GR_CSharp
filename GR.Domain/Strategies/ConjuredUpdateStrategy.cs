using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Domain
{
    public class ConjuredUpdateStrategy : IStockItemUpdateStrategy
    {
        public void UpdateItem(Item item)
        {
            item.Quality -= 2;
            if (item.SellIn > 0)
                item.SellIn--;
            if (item.SellIn <= 0)
                item.Quality -= 2;
        }
    }
}
