using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging
{
    // Lists items for sale and their prices
class DebugSix01
{
   static void Main()
   {
      /*string[] items = {"Belt", "Tie", "Scarf", "Cufflinks"};
      double[] prices = {29.00, 35.95, 18.50, 112.99};
      Console.WriteLine("Items for sale:");
      for (int x = 0; x < items.Length; ++x)
      {
          Console.WriteLine("{0,12} for {1,10}", items[x], prices[x].ToString("C"));
      }*/
       
       const int QUIT = 999;
       int[] numbers = new int[8];
       int x = 0;
       int num;
       double average;
       double total = 0;
       string inString;
       Console.Write("Please enter a number or " +
          QUIT + " to quit...");
       inString = Console.ReadLine();
       num = Convert.ToInt32(inString);
       while ((x < numbers.Length) && num != QUIT)
       {
           numbers[x] = num;
           total += numbers[x];
           ++x;
           Console.Write("Please enter a number or " +
              QUIT + " to quit...");
           inString = Console.ReadLine();
           num = Convert.ToInt32(inString);
       }
       Console.WriteLine("The numbers are:");
       for (int y = 0; y < x; ++y)
       {
           Console.Write("{0,6}", numbers[y]);
          
       }
       average = total / x;
       Console.WriteLine();
       Console.WriteLine("The average is {0}", average);
      
       /*String[] books = {"Catch-22", "Harry Potter",
         "Programming Using C#", "Rich Dad, Poor Dad",
         "The Deep", "Wizard of Oz"};
       int x;
       string entryString;
       Console.Write("What book are you looking for? ");
       entryString = Console.ReadLine();
       x = Array.BinarySearch(books, entryString);
       if (x < 0)
           Console.WriteLine("{0} not found", entryString);
       else
           Console.WriteLine("Yes, we carry {0}", entryString);

       /*int[] numbers = { 12, 15, 22, 88 };
       int x;
       double average;
       double total = 0;
       Console.Write("\nThe numbers are...");
       for (x = 0; x < numbers.Length; ++x)
           Console.Write("{0, 6}", numbers[x]);
       Console.WriteLine();
       for (x = 0; x < numbers.Length; ++x)
       {
           total = numbers.Sum();
       }
       average = total / numbers.Length;
       Console.Write("The average is" + average );*/
   }
    
}
}
