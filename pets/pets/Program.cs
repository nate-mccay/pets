using System;
using System.Collections.Generic;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet ralphDog = new Pet();
            ralphDog.Age = 3;
            ralphDog.Name = "Ralph";
            ralphDog.Legs = 3;
            ralphDog.Breed = "Husky";
            var cat = new Pet(6, "Whiskers", 4, "Short Hair");
            var myPets = new List<Pet>();
            myPets.Add(ralphDog);
            myPets.Add(cat);
            foreach(var animal in myPets)
            {
                Console.WriteLine($"Pet Name: {animal.Name}, Age of Pet: {animal.Age}");
            }

        }
    }
}
