using PetFinder.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinderTests
{
    /// <summary>
    /// Mock implementation of WebClient which reads data from file instead of a web service
    /// </summary>
    public class MockWebClient : IWebClient
    {
        public string DownloadString(string address)
        {
            return File.ReadAllText("TestData.json");
        }

        public void Dispose()
        {
            
        }
    }
}
