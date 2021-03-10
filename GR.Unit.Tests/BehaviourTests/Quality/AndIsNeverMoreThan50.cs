using GR.Common.Testing;
using GR.Domain;
using GR.Unit.Tests;
using NUnit.Framework;
using System.Collections.Generic;

namespace Kata.GR.CSharp.Unit.Tests.BehaviourTests.Quality
{
    [TestFixture]
    public class AndIsNeverMoreThan50 : WhenTestingTheQuality
    {
        protected override void Setup()
        {
            StockItemUnderTest = ItemBuilder
                .Build
                .WithName(ActualName)
                .WithQuality(ActualQualityValue)
                .WithSellin(ActualSellinValue)
                .AnInstance();

            StockItemsUnderTest = new List<Item> { StockItemUnderTest };
            GRConsole.Items = StockItemsUnderTest;
        }

        [TestCase("+5 Dexterity Vest", 50, 0, 50)]
        [TestCase("Aged Brie", 50, 0, 50)]
        [TestCase("Sulfuras, Hand of Ragnaros", 50, 10, 50)]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 50, 0, 50)]
        public void ItShouldNeverBeGreaterThanTheExpectedValue(string actualName, int actualQuality, int actualSellin, int expectedQuality)
        {
            ActualName = actualName;
            ActualQualityValue = actualQuality;
            ActualSellinValue = actualSellin;

            ArrangeAndAct();

            Assert.LessOrEqual(GetFirstItemInInventory().Quality, expectedQuality);
        }
}
}
