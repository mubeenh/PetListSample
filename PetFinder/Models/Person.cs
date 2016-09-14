﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetFinder.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }

    public class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}