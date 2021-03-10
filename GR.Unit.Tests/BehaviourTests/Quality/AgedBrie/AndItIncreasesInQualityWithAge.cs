using GR.Common.Testing;
using GR.Domain;
using GR.Unit.Tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Kata.GR.CSharp.Unit.Tests.BehaviourTests.Quality.AgedBrie
{
    [TestFixture]
    public class AndItIncreasesInQualityWithAge : WhenTestingTheQuality
    {
        protected override void Setup()
        {
            ExpectedQualityValue = 11;
            ActualQualityValue = 10;
            ActualSellinValue = 10;
            ActualName = "Aged Brie";

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
        public void ItShouldReturnAnIncreaseInQuality()
        {
            ArrangeAndAct();
            Assert.AreEqual(ExpectedQualityValue, GetFirstItemInInventory().Quality);
        }

        [Test]
        public void ItShouldIncreaseByAFactorOfOne()
        {
            ArrangeAndAct();

            var factor = ActualQualityValue - GetFirstItemInInventory().Quality;

            Assert.AreEqual(1, Math.Abs(factor));
        }
    }
}
