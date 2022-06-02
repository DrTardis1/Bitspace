using Moq;
using Moq.AutoMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitspace.Tests.Base
{
    public class UnitTestBase<T> where T : class
    {
        public UnitTestBase()
        {
            Mocker = new AutoMocker();
            Sut = Mocker.CreateInstance<T>();
        }

        protected T Sut { get; set; }
        protected AutoMocker Mocker { get; set; }
    }
}
