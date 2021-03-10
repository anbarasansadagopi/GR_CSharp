using GR.Common.Testing;
using GR.Domain;
using NUnit.Framework;
using System.Collections.Generic;

namespace GR.Unit.Tests
{
    [TestFixture]
    public class AndItemsNeverNeedToBeSold : WhenTestingTheQuality
    {
        protected override void Setup()
        {
            ExpectedQualityValue = 10;
            ActualQualityValue = 10;
            ActualSellinValue = 10;
            ActualName = "Sulfuras, Hand of Ragnaros";

            StockItemUnderTest = ItemBuilder
                .Build
                .WithName(ActualName)
                .WithQuality(ActualQualityValue)
                .WithSellin(ActualSellinValue)
                .AnInstance();

            StockItemsUnderTest = new List<Item> { StockItemUnderTest };

            GRConsole.Items = StockItemsUnderTest;
        }

        [Test]
        public void ItShouldAlwaysHaveTheSameValue()
        {
            ArrangeAndAct();
            Assert.AreEqual(ExpectedQualityValue, GetFirstItemInInventory().Quality);
        }
    }
}
