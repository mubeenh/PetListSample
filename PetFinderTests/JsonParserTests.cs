using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetFinder.Service;
using PetFinder.Models;
using System.Collections.Generic;
using System.Linq;

namespace PetFinderTests
{
    [TestClass]
    public class JsonParserTests
    {
        [TestMethod]
        public void ParseValid()
        {
            string json = @"[
                              {
                                ""name"": ""Bob"",
                                ""gender"": ""Male"",
                                ""age"": 23,
                                ""pets"": [
                                  {
                                    ""name"": ""Garfield"",
                                    ""type"": ""Cat""
                                  },
                                  {
                                    ""name"": ""Fido"",
                                    ""type"": ""Dog""
                                  }
                                ]
                              },
                              {
                                ""name"": ""Jennifer"",
                                ""gender"": ""Female"",
                                ""age"": 18,
                                ""pets"": [
                                  {
                                    ""name"": ""Garfield"",
                                    ""type"": ""Cat""
                                  }
                                ]
                              }
                            ]";

            List<Person> people = JsonParser.ParsePeopleData(json);

            Assert.IsNotNull(people);
            Assert.IsTrue(people.Count > 0);
            Assert.IsTrue(people.Any(p => p.Name == "Bob"));
            Assert.IsTrue(people.Any(p => p.Pets.Any(e => e.Name == "Garfield")));

        }

        [TestMethod]
        [ExpectedException(typeof(Newtonsoft.Json.JsonReaderException))]
        public void ParseInvalid()
        {
            string json = "<XML><Random>this is not json</Random></XML>";
            List<Person> people = JsonParser.ParsePeopleData(json);

            Assert.Fail("Should throw exception.");
        }
    }
}
