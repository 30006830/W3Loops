using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int finish = 5;
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine(" N\t\tN*10\t\tN*100\t\tN*1000 Task 1");
            Console.WriteLine("\n");
            Console.WriteLine("Beginning of For Loop...\n");
            for (int i = start; i <= finish; i++)
            {
                Console.WriteLine($" {i}\t\t{i * 10}\t\t{i * 100}\t\t{i * 1000}");

            }
            Console.WriteLine("\n");
            Console.WriteLine("End of the For Loop...\n");
            Console.WriteLine("\n");

            int counter = 1;
            Console.WriteLine("Beginning of While Loop...\n");
            while (counter <= finish)
            {
                Console.WriteLine($"{counter}\t\t{counter * 10}\t\t{counter * 100}\t\t{counter * 1000}");

                counter++;
            }
            Console.WriteLine("\n");
            Console.WriteLine("End of the While Loop...");
            Console.WriteLine("\n");

            counter = 1;
            Console.WriteLine("Beginning of Do While Loop...\n");
            do
            {
                Console.WriteLine($"{counter}\t\t{counter * 10}\t\t{counter * 100}\t\t{counter * 1000}");
                counter++;
            }
            while (counter <= finish);
            Console.WriteLine("\n");
            Console.WriteLine("End of the Do While Loop...\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Beginning of the 7 times table: Task 2");
            int num7 = 1;
            int result = 12;
           
            Console.WriteLine("7 Times Table:");
            Console.WriteLine("---------------\n");

            Console.WriteLine("==== for loop ====");
            for (int e = num7; e <= result; e++)
            {
                Console.WriteLine($" {e} x 7 = {e * 7}");
            }
            Console.WriteLine("\n");

            Console.WriteLine("==== while loop ====");
            while(num7 <= result)
            {
                Console.WriteLine($" {num7} x 7 = {num7 * 7}");
                num7++;
            }
            Console.WriteLine("\n");

            Console.WriteLine("==== do while loop ====");
            num7 = 1;
            do
            {
                Console.WriteLine($" {num7} x 7 = {num7 * 7}");
                num7++;
            }
            while (num7 <= result);
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Task 3: Squares & Cubes.");
            int BaseNum = 0;
            int multiplier = 10;

            Console.WriteLine("For Loop..\n");
            for(int eee = BaseNum; eee <= multiplier; eee++)
            {
                Console.WriteLine($" {eee}\t\t{eee*eee}\t\t{eee*eee*eee}");
            }
            Console.WriteLine("\n");

            Console.WriteLine("While Loop..\n");
            BaseNum = 1;
            while(BaseNum <= multiplier)
            {
                Console.WriteLine($"{BaseNum}\t\t{BaseNum * BaseNum}\t\t{BaseNum * BaseNum * BaseNum}");
                BaseNum++;
            }
            Console.WriteLine("\n");

            Console.WriteLine("Do While Loop..\n");
            BaseNum = 1;
            do
            {
                Console.WriteLine($"{BaseNum}\t\t{BaseNum * BaseNum}\t\t{BaseNum * BaseNum * BaseNum}");
                BaseNum++;
            }
            while (BaseNum <= multiplier);

            Console.ReadLine();
        }
    }
}
