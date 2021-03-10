using GR.Domain;
using NUnit.Framework;

namespace GR.Unit.Tests
{
    [TestFixture]
    public class AndItemIsAgedBrie : WhenTestingTheFactory
    {
        protected override void Setup()
        {
            ActualName = "Aged Brie";
            base.Setup();
        }

        [Test]
        public void Factory_AgedBrie_ItShouldReturnTheCorrectStrategy()
        {
            ArrangeAndAct();
            Assert.IsInstanceOf<AgedBrieUpdateStrategy>(Result);
        }
    }
}
