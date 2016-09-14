using PetFinder.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinderTests
{
    /// <summary>
    /// Mock factory implementation to create instances of MockWebClient type
    /// </summary>
    public class MockWebClientFactory : IWebClientFactory
    {
        public IWebClient CreatInstance()
        {
            return new MockWebClient();
        }
    }
}
