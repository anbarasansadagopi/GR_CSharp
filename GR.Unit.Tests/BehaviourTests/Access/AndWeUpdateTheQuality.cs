using NUnit.Framework;
using GR.Domain;
using System.Collections.Generic;
using GR.Common.Testing;

namespace GR.Unit.Tests
{
    [TestFixture]
    public class AndWeUpdateTheQuality : WhenTestingTheGRProgram
    {
        //Override for more local setup
        protected override void Setup()
        {
            ActualSellinValue = 10;
            ActualQualityValue = 10;
            base.Setup();

            //Create stock items to test
            StockItemsUnderTest = new List<Item> { StockItemUnderTest };
            GRConsole.Items = StockItemsUnderTest;
        }

        [Test]
        public void ItShouldReduceQualityOnUpdate()
        {
            ArrangeAndAct();
            Assert.AreEqual(9, GRConsole.Items[0].Quality);
        }
    }
}
