using GR.Common.Testing;
using GR;
using GR.Domain;
using System.Collections.Generic;

namespace GR.Unit.Tests
{
    public abstract class WhenTestingTheQuality : WhenTestingTheBehaviourOfSomething
    {
        //Item under test
        protected Program GRConsole { get; set; }

        protected Item StockItemUnderTest { get; set; }
        protected List<Item> StockItemsUnderTest { get; set; }
        protected string ActualName { get; set; }
        protected int ActualSellinValue { get; set; }
        protected int ActualQualityValue { get; set; }
        protected int ExpectedQualityValue { get; set; }
        
        protected IUpdateItemFactory MockStrategyFactory { get; set; }

        public WhenTestingTheQuality()
        {
            var ioc = new Ioc();
            var updateStrategyFactory = ioc.Resolve<IUpdateItemFactory>();
            GRConsole = new Program(updateStrategyFactory);
            //GRConsole.SetUpdateItemStrategyFactory(updateStrategyFactory);

        }

        protected override void Setup()
        {
            //Some defaults 
            StockItemUnderTest = ItemBuilder.Build.AnInstance();
            StockItemsUnderTest = new List<Item> { StockItemUnderTest };
            GRConsole.Items = StockItemsUnderTest;
        }

        protected override void ArrangeAndAct()
        {
            Setup();
            GRConsole.UpdateQuality();
        }

        public Item GetFirstItemInInventory()
        {
            return GRConsole.Items[0];
        }
    }
}
