using NUnit.Framework;

namespace GR.Unit.Tests
{
    [TestFixture]
    public class QualityIsNeverNegative : AndUpdateItemIsCalled
    {
        [Test]
        public void Strategy_Quality_ItShouldNeverBeNegative()
        {
            ActualQualityValue = 0;
            ActualSellinValue = 0;

            ArrangeAndAct();
            Assert.AreNotEqual(-1, StockItem.Quality);
        }
    }
}
