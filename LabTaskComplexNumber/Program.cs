using System;

namespace LabTaskComplexNumber
{
    class Program
    {
   
    static void Main()
    {
      
        ComplexNumber number = new ComplexNumber(2, 3);
        Console.WriteLine("Number is: " + number.ToString());

        number.SetImaginary(-1);
        Console.WriteLine("Number is: " + number.ToString());

        // Console.Write("Magnitude is: ");
        // Console.WriteLine(number.GetMagnitude());

        ComplexNumber number2 = new ComplexNumber(-1, 1);
        number.Add(number2);
        Console.Write("After adding: ");
        Console.WriteLine(number.ToString());

        number.Subtract(number2);
        Console.Write("After subtracting: ");
        Console.WriteLine(number.ToString());
    }
}

}

