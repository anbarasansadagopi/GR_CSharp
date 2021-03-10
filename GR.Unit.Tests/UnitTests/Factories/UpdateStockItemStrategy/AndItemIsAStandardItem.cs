using GR.Domain;
using NUnit.Framework;

namespace GR.Unit.Tests
{
    [TestFixture]
    public class AndItemIsAStandardItem : WhenTestingTheFactory
    {
        protected override void Setup()
        {
            base.Setup();
        }

        [TestCase("A normal item")]
        [TestCase("+5 Dexterity Vest")]
        [TestCase("")]
        public void Factory_StandardItems_ItShouldReturnTheCorrectStrategy(string itemName)
        {
            ActualName = itemName;
            ArrangeAndAct();
            Assert.IsInstanceOf<StandardItemsUpdateStrategy>(Result);
        }
    }
}
