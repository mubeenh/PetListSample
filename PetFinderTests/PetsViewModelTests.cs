using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetFinder.Models;
using PetFinder.Service;
using System.Collections.Generic;

namespace PetFinderTests
{
    [TestClass]
    public class PetsViewModelTests
    {
        private PetFinderService _service;

        public PetsViewModelTests()
        {
            _service = new PetFinderService();
        }

        [TestMethod]
        public void TestWithNonNullData()
        {
            PetsViewModel vm = new PetsViewModel();
            vm.People = _service.GetPeople();

            var grouped = vm.GetPetsGroupedByOwnerGender("cat");

            Assert.IsNotNull(grouped);
            Assert.IsInstanceOfType(grouped, typeof(Dictionary<string, List<Pet>>));
            Assert.IsTrue(grouped.Count > 0);
        }

        [TestMethod]
        public void TestWithNullData()
        {
            PetsViewModel vm = new PetsViewModel();
            vm.People = null;

            var grouped = vm.GetPetsGroupedByOwnerGender("Cat");

            Assert.IsNull(grouped);
        }

        [TestMethod]
        public void TestInvalidPetType()
        {
            PetsViewModel vm = new PetsViewModel();
            vm.People = _service.GetPeople();
            
            // test for empty string
            var grouped = vm.GetPetsGroupedByOwnerGender("");
            Assert.IsTrue(grouped.Count == 0);

            // test for non existent pet type
            grouped = vm.GetPetsGroupedByOwnerGender("Rabbit");
            Assert.IsTrue(grouped.Count == 0);

            // finally, test for null
            grouped = vm.GetPetsGroupedByOwnerGender(null);
            Assert.IsTrue(grouped.Count == 0);
        }
    }
}
