using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetFinder.Common
{
    /// <summary>
    /// Provides factory method to create SystemWebClient instance, which in effect
    /// is a System.Net.WebClient type instance.
    /// </summary>
    public class WebClientFactory : IWebClientFactory
    {

        public IWebClient CreatInstance()
        {
            return new SystemWebClient();
        }
    }
}