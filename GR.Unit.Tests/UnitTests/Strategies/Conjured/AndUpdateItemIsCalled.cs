using GR.Common.Testing;
using GR.Domain;

namespace GR.Unit.Tests.UnitTests.Strategies.Conjured
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

            StrategyUnderTest = new ConjuredUpdateStrategy();
        }

        protected override void ArrangeAndAct()
        {
            base.ArrangeAndAct();
        }
    }
}
