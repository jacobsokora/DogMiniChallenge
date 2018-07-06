using System;

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.male);
            puppy.bark(3);
            Console.WriteLine(puppy.getTag());

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.female);
            myDog.bark(1);
            Console.WriteLine(myDog.getTag());
        }
    }

    class Dog
    {
        string name;
        string owner;
        int age;
        Gender gender;

        public Dog(string name, string owner, int age, Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }

        public void bark(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Woof!");
            }
        }

        public string getTag()
        {
            string tag =  "If lost, call " + owner + ". ";
            if (gender == Gender.male)
            {
                tag += "His";
            }
            else 
            {
                tag += "Her";
            }
            tag += " name is " + name + " and ";
            if (gender == Gender.male)
            {
                tag += "he";
            }
            else
            {
                tag += "she";
            }
            tag += " is " + age + " year";
            if (age != 1) 
            {
                tag += "s";
            }
            tag += " old.";
            return tag;
        }
    }

    enum Gender
    {
        male, female
    }
}
