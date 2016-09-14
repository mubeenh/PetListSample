using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetFinder.Service;
using PetFinder.Models;
using System.Linq;
using PetFinder.Common;

namespace PetFinderTests
{
    /// <summary>
    /// Summary description for PetFinderServiceTests
    /// </summary>
    [TestClass]
    public class PetFinderServiceTests
    {
        private PetFinderService _service;

        [TestMethod]
        public void TestGetPeopleUsingService()
        {
            _service = new PetFinderService(new WebClientFactory());

            List<Person> people = _service.GetPeople();

            Assert.IsNotNull(people);
            Assert.IsTrue(people.Count > 0);
        }

        [TestMethod]
        public void TestGetPeopleUsingMockData()
        {
            _service = new PetFinderService(new MockWebClientFactory());

            List<Person> people = _service.GetPeople();

            Assert.IsNotNull(people);
            Assert.IsTrue(people.Count > 0);
        }

    }
}
