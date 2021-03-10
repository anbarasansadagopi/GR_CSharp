using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Domain
{
    public interface IStockItemUpdateStrategy
    {
        void UpdateItem(Item item);
    }
}
