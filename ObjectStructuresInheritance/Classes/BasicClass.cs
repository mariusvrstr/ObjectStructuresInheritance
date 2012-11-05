using System;

namespace ObjectStructuresInheritance.Classes
{
    /* [attributes] [modifiers] class identifier [:base-list] { class-body }[;] */
    public class Student
    {
        // Fields and Properties
        public string Name, Surname;
        public DateTime BirthDay { get; set; }

        // Constructor
        public Student(string name,string surname, DateTime birthDay)
        {
            Name = name;
            Surname = surname;
            BirthDay = birthDay;
        }

        // Class Method
        public int GetStudentAge()
        {
            return (DateTime.Now.Year) - BirthDay.Year;
        }
    }
    
    class BasicClass
    {
        private static void Main(string[] args) // Start method
        {
            var enrollStudent = new Student("Sandra", "Jensen", new DateTime(1982, 06, 12));
            
            Console.WriteLine("Student Details: {0} {1} {2}", enrollStudent.Name,
                enrollStudent.Surname, enrollStudent.GetStudentAge());

            Console.ReadKey();
        }
    }
}
