using System;

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);
            puppy.bark(3);
            Console.WriteLine(puppy.getTag());

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);
            myDog.bark(1);
            Console.WriteLine(myDog.getTag());
        }
    }
}
