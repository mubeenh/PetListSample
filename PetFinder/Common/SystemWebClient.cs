using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace PetFinder.Common
{
    /// <summary>
    /// This is just a System.Net.WebClient class with 
    /// a marker interface IWebClient.
    /// </summary>
    public class SystemWebClient : WebClient, IWebClient
    {

    }
}