using GR.Domain;
using NUnit.Framework;

namespace GR.Unit.Tests
{
    [TestFixture]
    public class AndItemIsALegend : WhenTestingTheFactory
    {
        protected override void Setup()
        {
            ActualName = "Sulfuras, Hand of Ragnaros";
            base.Setup();
        }

        [Test]
        public void Factory_Legend_ItShouldReturnTheCorrectStrategy()
        {
            ArrangeAndAct();
            Assert.IsInstanceOf<LegendaryItemsUpdateStrategy>(Result);
        }
    }
}
