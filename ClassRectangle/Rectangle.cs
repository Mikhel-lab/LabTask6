using System;
namespace ClassRectangle
{
    public class Rectangle
    {
       double length = 1;
       double width = 1;

       public double Length
     {
        get { return length; }
        set 
       { 
         if (value > 0.0 && value < 20.0)
         {
           length = value;
         }
           else
         {
             Console.WriteLine("Invalid length");
         }
     }
  }

      public double Width
     {
       get { return width; }
       set 
       {
          if (value > 0.0 && value < 20.0)
          {
           width = value; 
          }
           else
          {
               Console.WriteLine("Invalid width");
          }
     }
  }
   
        public double Perimeter
      {
          get { return (length + width) * 2.0; }
      }

      public double Area
      {  
          get { return length * width; }
      }


   }


}