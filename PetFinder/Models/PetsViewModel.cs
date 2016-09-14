using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetFinder.Models
{
    public class PetsViewModel
    {
        public List<Person> People { get; set; }

        /// <summary>
        /// Gets all the pets grouped by owner's gender.
        /// </summary>
        /// <param name="petType">Type of the pet, e.g. Cat.</param>
        /// <returns></returns>
        public Dictionary<string, List<Pet>> GetPetsGroupedByOwnerGender(string petType)
        {
            if (this.People == null)
            {
                return null;
            }
            // Group by owner's gender and filter by pet type. Ignore case.
            return this.People.Where(e => e.Pets != null && e.Pets.Any(p => p.Type.Equals(petType, StringComparison.OrdinalIgnoreCase)))
                    .GroupBy(e => e.Gender)
                    .ToDictionary(e => e.Key, e => e.SelectMany(p => p.Pets).Where(p => p.Type == petType).ToList());
        }

    }
}