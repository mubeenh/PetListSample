using Newtonsoft.Json;
using PetFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetFinder.Service
{
    public class JsonParser
    {
        public static List<Person> ParsePeopleData(string json)
        {
            return JsonConvert.DeserializeObject<List<Person>>(json);
        }
    }
}