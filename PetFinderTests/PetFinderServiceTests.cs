using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetFinder.Service;
using PetFinder.Models;
using System.Linq;

namespace PetFinderTests
{
    /// <summary>
    /// Summary description for PetFinderServiceTests
    /// </summary>
    [TestClass]
    public class PetFinderServiceTests
    {
        private PetFinderService _service;

        public PetFinderServiceTests()
        {
            _service = new PetFinderService();
        }

        [TestMethod]
        public void TestGetPeople()
        {
            List<Person> people = _service.GetPeople();

            Assert.IsNotNull(people);
            Assert.IsTrue(people.Count > 0);
        }
    }
}
