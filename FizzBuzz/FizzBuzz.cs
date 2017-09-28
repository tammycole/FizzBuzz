using System;

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
                bool checkBoth = DivThreeFive(i);

                string WhichString = PrintString(checkThree, checkFive, checkBoth);
                if(WhichString!="Ignore")
                {
                    Console.WriteLine(WhichString);
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
            {
                return false;
            }
        }

        public static bool DivThreeFive(int i)
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


        public static string PrintString(bool Three, bool Five, bool ThreeFive)
        {
            if (ThreeFive == true)
            {
                return "FizzBuzz";
            }
            else if (Three == true)
            {
                return "Fizz";
            }
            else if (Five == true)
            {
                return "Buzz";
            }
            else
            {
                return "Ignore";
            }

        }
    }
}
