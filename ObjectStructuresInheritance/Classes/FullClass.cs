using System;

namespace ObjectStructuresInheritance.Classes
{

   public class Species
   {
       private const int DefaultEyes = 2; // Unchangeable Constant
       public static readonly int DefaultYears = 60; // No class instance required
       public int       LifeExpectancy  { get; set; } // Auto Property
       public string    Name            { get; set; } // Auto Property
       public int       Eyes            { get; set; } // Auto Property

       private bool _isMammel; // Private Field/Member
       public bool IsMammel // Public Property
       {
           get { return _isMammel;  }
           set
           {
               _isMammel = value;
               if (_isMammel) { Eyes = DefaultEyes; }
           }
       }

       public static int GetDefaultLifeExpectancy(ref int genericAge, bool isDogYears)
       { 
           genericAge = (isDogYears) ? genericAge * 7 : genericAge;
           return genericAge;
       }

       // Constructor with a optional nullable numberOfEyes parameter
       public Species(string name, bool isMammel, int lifeExpectancy, int? numberOfEyes = null)
       {
           LifeExpectancy = lifeExpectancy;
           Name = name;
           Eyes = numberOfEyes ?? 0; // Set a default if none specified else use passed value;
           IsMammel = isMammel; // Invoke set from property
       }

       ~Species () // Destructor logic
       { Console.Write("Object is now being cleaned up by garbage collection."); }

       public override string ToString()
       { return String.Format("Species: {0} have {1} number of eyes.", Name, Eyes); }
   }
    
    
    class FullClass
    {
        private static void Main(string[] args) // Start method
        {
            var averageDogAge = 13;
            var backupOriginal = averageDogAge; // This copies the original value (To show result of using ref)
            
            // Using named arguments so that parameters don't have to be in correct sequence
            var expectancy = Species.GetDefaultLifeExpectancy(isDogYears: true, genericAge: ref averageDogAge);

            var husky = new Species("dog", true, expectancy);
             
            Console.WriteLine(husky.ToString());
            Console.Write(String.Format("Actual Age: {0}/{1}, Dog Age: {2} vs norm of {3}",
                backupOriginal, averageDogAge, husky.LifeExpectancy, Species.DefaultYears));
            Console.ReadKey();
        }
    }
}
