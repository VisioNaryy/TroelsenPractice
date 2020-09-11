using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class SportsCar : Car
    {
        public string GetPetName()
        {
            PetName = "Fred";
            return PetName;
        }
    }
}