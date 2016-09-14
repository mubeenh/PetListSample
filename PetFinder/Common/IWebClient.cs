using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Common
{
    public interface IWebClient : IDisposable
    {
        string DownloadString(string address);
    }
}
