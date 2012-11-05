using System;

namespace ObjectStructuresInheritance.Structs
{

    /* [attributes] [modifiers] struct identifier [:interfaces] body [;] */
    public struct Rectangle
    {
        public int Length, Width;

        // *Optional - Constructor must initialize ALL fields in struct
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
    }

    class BasicStruct
    {
        private static void Main(string[] args) // Start method
        {

            Rectangle lunchbox; 
            lunchbox.Length = 12; // Each field MUST be initialized
            lunchbox.Width = 6;

            var suitcase = new Rectangle(60,40);

            Console.WriteLine("LunchBox dimensions: {0}x{1}", 
                lunchbox.Length, lunchbox.Width);
            Console.WriteLine("SuiteCase dimensions: {0}x{1}", 
                suitcase.Length, suitcase.Width);
            Console.ReadLine();

        }

    }
}
