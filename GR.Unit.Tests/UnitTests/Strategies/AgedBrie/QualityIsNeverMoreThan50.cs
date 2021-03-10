using NUnit.Framework;

namespace GR.Unit.Tests
{
    [TestFixture]
    public class QualityIsNeverMoreThan50 : AndUpdateItemIsCalled
    {
        [Test]
        public void Strategy_Quality_ItShouldNeverBeMoreThan50()
        {
            ActualQualityValue = 50;

            ArrangeAndAct();
            Assert.LessOrEqual(StockItem.Quality, 50);
        }
    }
}
