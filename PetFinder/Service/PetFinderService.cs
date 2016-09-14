using Newtonsoft.Json;
using PetFinder.Common;
using PetFinder.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace PetFinder.Service
{
    public class PetFinderService
    {
        private readonly static string PEOPLE_SERVICE = ConfigurationManager.AppSettings["PEOPLE_SERVICE"];
        private IWebClientFactory _wcFactory;

        public PetFinderService(IWebClientFactory wcFactory)
        {
            _wcFactory = wcFactory;
        }

        public List<Person> GetPeople()
        {
            var response = "";

            using (IWebClient wc = _wcFactory.CreatInstance())
            {
                // fetch json from service
                response = wc.DownloadString(PEOPLE_SERVICE);
            }

            // deserialize json data to object
            List<Person> people = JsonParser.ParsePeopleData(response);

            return people;
        }
    }
}