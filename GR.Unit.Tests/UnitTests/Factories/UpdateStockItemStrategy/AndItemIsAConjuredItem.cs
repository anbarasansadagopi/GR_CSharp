using GR.Domain;
using NUnit.Framework;

namespace GR.Unit.Tests
{
    [TestFixture]
    public class AndItemIsAConjuredItem : WhenTestingTheFactory
    {
        protected override void Setup()
        {
            ActualName = "Conjured Mana Cake";
            base.Setup();
        }

        [Test]
        public void Factory_ConjuredItem_ItShouldReturnTheCorrectStrategy()
        {
            ArrangeAndAct();
            Assert.IsNotInstanceOf<StandardItemsUpdateStrategy>(Result);
        }
    }
}
