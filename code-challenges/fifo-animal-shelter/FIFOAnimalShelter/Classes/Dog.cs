using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Dog : Animal
    {
        public bool HasSpots { get; set; }

        public Dog()
        {
            Name = "Dog";
        }
    }
}
