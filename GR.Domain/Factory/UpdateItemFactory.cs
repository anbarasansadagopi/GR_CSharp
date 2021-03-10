using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Domain
{
    public class UpdateItemFactory : IUpdateItemFactory
    {
        public IStockItemUpdateStrategy Create(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            switch (item.Name)
            {
                case "Aged Brie":
                    return new AgedBrieUpdateStrategy();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackStagePassesUpdateStrategy();
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryItemsUpdateStrategy();
                case "Conjured Mana Cake":
                    return new ConjuredUpdateStrategy();
                default:
                    return new StandardItemsUpdateStrategy();
            }
        }
    }
}
