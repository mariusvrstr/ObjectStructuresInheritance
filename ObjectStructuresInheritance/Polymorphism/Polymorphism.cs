using System;

namespace ObjectStructuresInheritance.Polymorphism
{
    public class BaseClass
    {
        public void NormalMethod()          { Console.WriteLine("Execute BaseClass_NormalMethod()"); }
        public virtual void VirtualMethod() { Console.WriteLine("Execute BaseClass_VirtualMethod()"); }
    }

    public class ClassA : BaseClass
    {
        public new void NormalMethod()      { Console.WriteLine("Execute ClassA_NormalMethod()"); }
        public override sealed void VirtualMethod() { Console.WriteLine("Execute ClassA_VirtualMethod()"); }       
    }

    public class ClassB : ClassA
    {
        public new void NormalMethod()          { Console.WriteLine("Execute ClassB_NormalMethod()"); }
        public void VirtualMethod(string input) { Console.WriteLine("Execute ClassB_NormalMethod() " + input); }
    }
    
    class BasicPolymorphism
    {
        private static void Main(string[] args) // Start method
        {

            var classA = new ClassA();
            classA.NormalMethod(); // Hides the base method
            classA.VirtualMethod(); // Overrides the base method

            Console.WriteLine();

            ((BaseClass)classA).NormalMethod(); // Executes hidden method
            ((BaseClass)classA).VirtualMethod(); // Override so there is no base method

            Console.WriteLine();

            var classB = new ClassB();
            classB.NormalMethod(); // Hides the base method
            classB.VirtualMethod("Overload"); // Overloading method based on parameter 
            classB.VirtualMethod(); // Snaps to ClassA cannot implement in ClassB - Sealed

            Console.ReadKey();
        }
    }
}
