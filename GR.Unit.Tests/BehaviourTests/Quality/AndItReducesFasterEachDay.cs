using GR.Common.Testing;
using GR.Domain;
using NUnit.Framework;
using System.Collections.Generic;

namespace GR.Unit.Tests
{
    [TestFixture]
    public class AndItReducesFasterEachDay : WhenTestingTheQuality
    {
        protected override void Setup()
        {
            ActualSellinValue = 0;
            ActualQualityValue = 10;
            ExpectedQualityValue = 8;

            StockItemUnderTest = ItemBuilder
                .Build
                .WithName("Test Item")
                .WithQuality(ActualQualityValue)
                .WithSellin(ActualSellinValue)
                .AnInstance();

            //Create stock items to test
            StockItemsUnderTest = new List<Item> { StockItemUnderTest };
            GRConsole.Items = StockItemsUnderTest;

            //Create stock items to test
            StockItemsUnderTest = new List<Item> { StockItemUnderTest };

            //Set items on ItemUnderTest
            GRConsole.Items = StockItemsUnderTest;
        }

        [Test]
        public void AfterTheSellbyDateHasPassed_ItShouldDegradeTwiceAsFast()
        {
            ArrangeAndAct();
            Assert.AreEqual(ExpectedQualityValue, GetFirstItemInInventory().Quality);
        }

        [Test]
        public void AfterTheSellbyDateHasPassed_ItShouldDegradeByFactorOfTwo()
        {
            ArrangeAndAct();
            var currentQuality = GetFirstItemInInventory().Quality;
            var factor = ActualQualityValue - currentQuality;
            Assert.AreEqual(2, factor);
        }

    }
}
