using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)

            {
                bool checkThree = DivThree(i);
                bool checkFive = DivFive(i);
                bool checkBoth = DivBoth(i);

                if (checkBoth == true)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (checkThree == true)
                   {
                    Console.WriteLine("Fizz");
                }
                else if (checkFive == true)
                   {
                    Console.WriteLine("Buzz");
                }
               else
               {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

        public static bool DivThree(int i)
        {
            if (i % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DivFive(int i)
        {
            if (i % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool DivBoth(int i)
        {
            if (i % 5 == 0 & i % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
