using System;

namespace ObjectStructuresInheritance.Polymorphism
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        // Overloading Update() parameters identify which
        public void Update(string name) { Name = name; }
        public void Update(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return String.Format("Student: {0} {1}", Name, Surname);
        }
    }

    
    class OverloadingPolymorphism
    {
        private static void Main(string[] args) // Start method
        {
            var studentOne = new Student();
            var studentTwo = new Student();

            studentOne.Update("Johan");
            studentTwo.Update("Pieter", "Jones");

            Console.WriteLine(studentOne.ToString());
            Console.WriteLine(studentTwo.ToString());

            Console.ReadKey();
        }
    }
}
