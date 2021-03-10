using NUnit.Framework;
using GR.Domain;
using System.Collections.Generic;
using GR.Common.Testing;

namespace Kata.GR.CSharp.Unit.Tests.BehaviourTests.Access
{
    [TestFixture]
    public class AndWeSetTheStockItems : WhenTestingTheGRProgram
    {
        //Override for more local setup
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

            //Create stock items to test
            StockItemsUnderTest = new List<Item> { StockItemUnderTest };
            GRConsole.Items = StockItemsUnderTest;
        }

        [Test]
        public void ItShouldAllowUsToSetAndRetrieveTheItemsCorrectly()
        {
            ArrangeAndAct();
            Assert.AreEqual(StockItemUnderTest, GRConsole.Items[0]);
        }

        [Test]
        public void ItShouldAllowUsAllowUsToUpdateItemsCorrectly()
        {
            ArrangeAndAct();
            Assert.AreEqual(StockItemUnderTest, GRConsole.Items[0]);
        }
    }
}
