using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Common.Testing
{
    public abstract class WhenTestingTheBehaviourOfSomething
    {
        //Arrange (Given That)
        protected abstract void Setup();

        //Act (When)
        protected abstract void ArrangeAndAct();
    }
}
