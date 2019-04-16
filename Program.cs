using System;

namespace Zoological
{
    class Program
    {
        static void Main(string[] args)
        {


            Zoological newZoo = new Zoological();

           newZoo.WalkingAnimals().ForEach(animal => Console.WriteLine($" the {animal} is walking"));


 newZoo.SwimmingAnimals().ForEach(animal => Console.WriteLine($" the {animal} is swimming"));

        }
    }
}
