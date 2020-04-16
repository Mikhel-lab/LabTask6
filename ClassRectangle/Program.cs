using System;

namespace ClassRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
             Console.WriteLine(rect1.Length); // 1 by default

             Console.WriteLine(rect1.Width); // 1 by default

             Console.WriteLine(rect1.Area); 

             Console.WriteLine(rect1.Perimeter);

              Console.WriteLine();

             Rectangle rect2 = new Rectangle();

            rect2.Length = 2.5;

             rect2.Width = 20.0; // invalid - stays at default of 1

            Console.WriteLine(rect2.Length);

            Console.WriteLine(rect2.Width);

           Console.WriteLine(rect2.Area); 

            Console.WriteLine(rect2.Perimeter);
            
            Console.ReadKey();
        }
    }
}
