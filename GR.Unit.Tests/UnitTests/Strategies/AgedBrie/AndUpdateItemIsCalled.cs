using GR.Common.Testing;
using GR.Domain;

namespace GR.Unit.Tests
{
    public class AndUpdateItemIsCalled : WhenTestingTheStrategy
    {
        protected override void Setup()
        {
            StockItem = ItemBuilder
                .Build
                .WithQuality(ActualQualityValue)
                .WithSellin(ActualSellinValue)
                .AnInstance();

            StrategyUnderTest = new AgedBrieUpdateStrategy();
        }

        protected override void ArrangeAndAct()
        {
            base.ArrangeAndAct();
        }
    }
}
