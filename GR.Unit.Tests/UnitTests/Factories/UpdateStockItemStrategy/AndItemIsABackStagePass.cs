using GR.Domain;
using NUnit.Framework;

namespace GR.Unit.Tests
{
    [TestFixture]
    public class AndItemIsABackStagePass : WhenTestingTheFactory
    {
        protected override void Setup()
        {
            ActualName = "Backstage passes to a TAFKAL80ETC concert";
            base.Setup();
        }

        [Test]
        public void Factory_BackStagePass_ItShouldReturnTheCorrectStrategy()
        {
            ArrangeAndAct();
            Assert.IsInstanceOf<BackStagePassesUpdateStrategy>(Result);
        }
    }
}
