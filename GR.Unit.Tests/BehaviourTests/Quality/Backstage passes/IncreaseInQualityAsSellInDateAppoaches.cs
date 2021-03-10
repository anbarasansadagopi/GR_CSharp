using GR.Common.Testing;
using GR.Domain;
using NUnit.Framework;
using System.Collections.Generic;

namespace GR.Unit.Tests
{
    [TestFixture]
    public class IncreaseInQualityAsSellInDateAppoaches : WhenTestingTheQuality
    {
        protected override void Setup()
        {
            StockItemUnderTest = ItemBuilder
                .Build
                .WithName("Backstage passes to a TAFKAL80ETC concert")
                .WithQuality(ActualQualityValue)
                .WithSellin(ActualSellinValue)
                .AnInstance();

            StockItemsUnderTest = new List<Item> { StockItemUnderTest };
            GRConsole.Items = StockItemsUnderTest;
        }

        [TestCase(10, 20, 11)]
        [TestCase(10, 10, 12)]
        [TestCase(10, 5, 13)]
        public void ItShouldReturnAHigherQualityAsSellinDateLowers(int actualQuality, int actualSellin, int expectedQuality)
        {
            ActualQualityValue = actualQuality;
            ActualSellinValue = actualSellin;

            ArrangeAndAct();
            Assert.AreEqual(expectedQuality, GetFirstItemInInventory().Quality);
        }
    }
}
