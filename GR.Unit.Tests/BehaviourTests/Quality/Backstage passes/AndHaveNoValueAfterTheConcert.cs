using GR.Common.Testing;
using GR.Domain;
using NUnit.Framework;
using System.Collections.Generic;

namespace GR.Unit.Tests
{
    [TestFixture]
    public class AndHaveNoValueAfterTheConcert : WhenTestingTheQuality
    {
        protected override void Setup()
        {
            //Sell by date 0 = sellby date passed

            ActualQualityValue = 10;
            ActualSellinValue = 0;
            ExpectedQualityValue = 0;

            StockItemUnderTest = ItemBuilder
                .Build
                .WithName("Backstage passes to a TAFKAL80ETC concert")
                .WithQuality(ActualQualityValue)
                .WithSellin(ActualSellinValue)
                .AnInstance();

            StockItemsUnderTest = new List<Item> { StockItemUnderTest };
            GRConsole.Items = StockItemsUnderTest;
        }

        [Test]
        public void ItShouldReturnNoValue()
        {
            ArrangeAndAct();

            Assert.AreEqual(ExpectedQualityValue, GetFirstItemInInventory().Quality);
        }

    }
}
