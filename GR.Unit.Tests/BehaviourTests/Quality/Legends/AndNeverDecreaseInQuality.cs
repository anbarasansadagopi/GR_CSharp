using GR.Common.Testing;
using GR.Domain;
using NUnit.Framework;
using System.Collections.Generic;

namespace GR.Unit.Tests
{
    [TestFixture]
    public class AndNeverDecreaseInQuality : WhenTestingTheQuality
    {
        protected override void Setup()
        {
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

        [TestCase(50, 0, 50)]
        [TestCase(40, 10, 40)]
        [TestCase(30, 20, 30)]
        public void ItShouldNeverDecreaseInQuality(int actualQuality, int actualSellin, int expectedQuality)
        {
            ActualQualityValue = actualQuality;
            ActualSellinValue = actualSellin;

            ArrangeAndAct();

            Assert.AreEqual(expectedQuality, GetFirstItemInInventory().Quality);
        }
    }
}
