using GR.Domain;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR
{
    public class Ioc : IIocGateway
    {
        private IKernel ninjectKernel;

        public Ioc()
        {
            ninjectKernel = new StandardKernel();
            Register();
        }

        public T Resolve<T>()
        {
            return ninjectKernel.Get<T>();
        }

        private void Register()
        {
            ninjectKernel.Bind<IUpdateItemFactory>().To<UpdateItemFactory>().InSingletonScope();
            ninjectKernel.Bind<IStockItemUpdateStrategy>().To<AgedBrieUpdateStrategy>().InTransientScope();
            ninjectKernel.Bind<IStockItemUpdateStrategy>().To<BackStagePassesUpdateStrategy>().InTransientScope();
            ninjectKernel.Bind<IStockItemUpdateStrategy>().To<ConjuredUpdateStrategy>().InTransientScope();
            ninjectKernel.Bind<IStockItemUpdateStrategy>().To<LegendaryItemsUpdateStrategy>().InTransientScope();
            ninjectKernel.Bind<IStockItemUpdateStrategy>().To<StandardItemsUpdateStrategy>().InTransientScope();
        }
    }
}
