﻿using GR.Common.Testing;
using GR.Domain;
using NUnit.Framework;
using System.Collections.Generic;

namespace GR.Unit.Tests
{
    [TestFixture]
    public class AndSellInReducesEachDay : WhenTestingTheSellin
    {
        protected override void Setup()
        {
            ActualSellinValue = 10;
            ActualQualityValue = 10;

            StockItemUnderTest = ItemBuilder
                .Build
                .WithName("+5 Dexterity Vest")
                .WithSellin(ActualSellinValue)
                .WithQuality(ActualQualityValue)
                .AnInstance();

            StockItemsUnderTest = new List<Item> { StockItemUnderTest };

            GRConsole.Items = StockItemsUnderTest;
        }

        [Test]
        public void ItShouldReturnALowerValue()
        {
            ArrangeAndAct();
            Assert.Less(GetFirstItemInInventory().SellIn, ActualSellinValue);
        }

        [Test]
        public void ItShouldDecreaseByAFactorOfOne()
        {
            ArrangeAndAct();

            var factor = ActualSellinValue - GetFirstItemInInventory().SellIn;

            Assert.AreEqual(1, factor);
        }
    }
}
