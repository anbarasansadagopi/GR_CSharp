using GR.Common.Testing;
using GR.Domain;
using NUnit.Framework;
using GR.Common.Testing;
using GR.Domain;
using Rhino.Mocks;

namespace GR.Unit.Tests
{
    [TestFixture]
    public abstract class WhenTestingTheFactory : WhenTestingTheBehaviourOfSomething
    {
        protected IUpdateItemFactory Factory { get; set; }
        protected IStockItemUpdateStrategy Result { get; set; }
        protected Item StockItem { get; set; }
        protected string ActualName;

        protected IUpdateItemFactory MockStrategyFactory { get; set; }

        protected override void Setup()
        {
            MockStrategyFactory = MockRepository.GenerateStub<IUpdateItemFactory>();

            StockItem = ItemBuilder
                .Build
                .WithName(ActualName)
                .AnInstance();

            Factory = new UpdateItemFactory();
        }

        protected override void ArrangeAndAct()
        {
            Setup();
            Result = Factory.Create(StockItem);
        }
    }   
}
