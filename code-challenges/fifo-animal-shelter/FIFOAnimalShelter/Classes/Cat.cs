﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Cat : Animal
    {
        public string MeowSound { get; set; }

        public Cat()
        {
            Name = "Cat";
        }
    }
}
