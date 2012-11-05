using System;

namespace ObjectStructuresInheritance.Classes
{

    public class SubjectMark
    {
        public int Mark = 0;
        public SubjectMark(int mark) { Mark = mark; }
    }

    public class StudentRegistry
    {
        public int StudentAge = 0;
        public SubjectMark SubMark;

        public StudentRegistry() { }

        public void Update(int studentAge, SubjectMark subjectMark)
        {
            StudentAge = studentAge + 1;
            subjectMark.Mark++;
            SubMark = subjectMark;
        }

        public void UpdateRef(ref int studentAge,ref SubjectMark subjectMark)
        {
            StudentAge = studentAge;
            subjectMark.Mark++;
            SubMark = subjectMark;
        }
    }

   class ParmByRef
    {
        private static void Main(string[] args) // Start method
        {
            var mathsA = new SubjectMark(10);
            var ageA = 10;

            var mathsB = new SubjectMark(10);
            var ageB = 10;

            var studentA = new StudentRegistry();
            studentA.Update(ageA, mathsA);

            var studentB = new StudentRegistry();
            studentB.UpdateRef(ref ageB,ref mathsB);

            Console.WriteLine("Student A >> " + studentA.StudentAge + "vs. " + ageA + ", " + studentA.SubMark.Mark + "vs." + mathsA.Mark);
            Console.WriteLine("Student B >> " + studentB.StudentAge + "vs. " + ageB + ", " + studentB.SubMark.Mark + "vs." + mathsB.Mark);
            
            Console.ReadKey();
        }
    }
}
