using System;
namespace Dog
{
    public class Dog
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
            string tag = "If lost, call " + owner + ". ";
            if (gender == Gender.Male)
            {
                tag += "His";
            }
            else
            {
                tag += "Her";
            }
            tag += " name is " + name + " and ";
            if (gender == Gender.Male)
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
}
