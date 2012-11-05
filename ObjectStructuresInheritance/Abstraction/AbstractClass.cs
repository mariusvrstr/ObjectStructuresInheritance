using System;

namespace ObjectStructuresInheritance.Abstraction
{
    
    public abstract class Animal // Abstract base class
    {
        // Abstract property
        public abstract int NumberOfEyes { get; set; }
        // Abstract method
        public abstract void CalculateAge(int animalYears);
    }

    public class Dog : Animal
    {
        public const string Type = "Dog";
        private int _age;

        // Note that all the depicted abstract elements MUST be declared
        public override int NumberOfEyes { get; set; } // Actual Implementation
        public override void CalculateAge(int animalYears)
        {
            _age = animalYears * 7;
        }

        public override string ToString()
        {
            return String.Format("Animal: {0} has {1} eyes and is {2} years old.", 
                Type, NumberOfEyes, _age);
        }
    }
    
    
    class Abstraction
    {
        private static void Main(string[] args) // Start method
        {
            var husky = new Dog() { NumberOfEyes = 2 };
            husky.CalculateAge(11);

            Console.WriteLine(husky.ToString());
            Console.ReadKey();
        }
    }
}
