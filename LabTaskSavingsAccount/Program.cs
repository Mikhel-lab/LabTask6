using System;

namespace LabTaskSavingsAccount
{
    class Program
    {
        static void Main(string[] args)
        {
             Account saver1 = new Account();
             Account saver2 = new Account();

             
           

           Console.WriteLine(saver1);
           Console.WriteLine(saver2);

           Account.ModifyInterestRate(5);
           saver1.SavingsBalance = 2000;
           saver2.SavingsBalance = 3000;
       

           Console.WriteLine(saver1);
           Console.WriteLine(saver2);

           Console.ReadLine();
        }
    }
}



