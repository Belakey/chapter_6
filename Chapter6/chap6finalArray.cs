using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6FinalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringChoice;
            int numChoice;
            int[] numbers = { 1, 3, 4, 5, 2, 7 };
            Console.Write("Choose 1,2, or 3 1 will reverse the array:  ");
            stringChoice = Console.ReadLine();
            numChoice = Convert.ToInt32(stringChoice);

            if (numChoice == 1)
            {
                for (int x = 0; x < 6; ++x)
                {

                    Console.WriteLine(numbers[x]);
                }
            }
            if (numChoice == 2)
            {
                Array.Sort(numbers);
                Array.Reverse(numbers);
                for (int x = 0; x < numbers.Length; ++x)
                {
                    
                    Console.WriteLine(numbers[x]);

                }
            }
            if (numChoice == 3)
            {
                double average = 0;
                for (int x = 0; x < 6; ++x)
                {

                    average = numbers.Sum() / numbers.Length;


                }
                Console.WriteLine(average);

            }

        }
    }
}