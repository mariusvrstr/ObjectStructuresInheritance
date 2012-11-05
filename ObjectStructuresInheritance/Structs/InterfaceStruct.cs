using System;

namespace ObjectStructuresInheritance.Structs
{
    interface IGrow
    {
        void FeedCircle(int food);
    }

    public struct Circle: IGrow
    {
        public float Radius;

        public Circle(float radius)
        {
            Radius = radius;
        }

        public void FeedCircle(int food)
        {
            Radius += food;
        }

        public override string ToString() // override base object
        {
            return String.Format("Circle: Radius {0}, Diameter {1}", Radius, Radius*2);
        }
    }

    class InterfaceStruct
    {
        private static void Main(string[] args) // Start method
        {
            var apple = new Circle(5);

            IGrow upsizeApple = apple;
            upsizeApple.FeedCircle(2);

            Console.WriteLine(apple + " " + upsizeApple);
            Console.ReadLine();
        }

    }
}
