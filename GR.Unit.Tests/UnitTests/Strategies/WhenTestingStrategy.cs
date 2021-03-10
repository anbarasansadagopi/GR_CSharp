using GR.Common.Testing;
using GR.Domain;
namespace GR.Unit.Tests
{
    public abstract class WhenTestingTheStrategy : WhenTestingTheBehaviourOfSomething
    {
        protected IStockItemUpdateStrategy StrategyUnderTest { get; set; }

        protected Item StockItem { get; set; }

        protected int ActualQualityValue { get; set; }
        protected int ActualSellinValue { get; set; }
        protected int ExpectedQualityValue { get; set; }
        protected int ExpectedSellinValue { get; set; }
        
        protected override void Setup()
        {
            StockItem = ItemBuilder
                .Build
                .AnInstance();
        }

        protected override void ArrangeAndAct()
        {
            Setup();
            StrategyUnderTest.UpdateItem(StockItem);
        }
    }
}
