using System;

namespace Program
{
    class Program
    {

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }


        static void Main(string[] args)
        {

            int n;
            string In;
            do
            {
                Console.WriteLine("Please, enter a number: ");
                In = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(In) || !int.TryParse(In, out n) || n < 1);

            n = Convert.ToInt32(In);


            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write(i + " ");
                }

            }



            Console.WriteLine("\n" + "Bonus part: ");

            // Bonus:


            int number;
            string input;
            int k = 1;
            bool valid = false;


            do
            {
                k++;
                Console.WriteLine("Enter a number between 10 and 200: ");
                input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out number) && number <= 200 && number >= 10)
                {
                    valid = true;
                    break;
                }
            } while (k <= 3);



            int CountPrimes = 0;
            int SumEven = 0;
            int MaxOdd = 0;
            int SumDivBy7 = 0;


            if (!valid)
            {
                Console.WriteLine("Too many invalid attempts. Exiting");
            }


            number = Convert.ToInt32(input);
            for (int j = 1; j <= number; j++)
            {
                if (j % 3 == 0 && j % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (j % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (j % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else if (IsPrime(j))
                {
                    CountPrimes++;
                    Console.Write($"[{j}] ");
                }
                else
                {
                    Console.Write(j + " ");
                }


                if (j % 2 == 0)
                {
                    SumEven += j;
                }
                if (j % 2 == 1)
                {
                    MaxOdd = j;
                }
                if (j % 7 == 0)
                {
                    SumDivBy7 += j;
                }

            }


            Console.WriteLine("\n" + $"CountPrimes: {CountPrimes}");
            Console.WriteLine($"SumEven: {SumEven}");
            Console.WriteLine($"MaxOdd: {MaxOdd}");
            Console.WriteLine($"SumDivBy7: {SumDivBy7}");
            Console.WriteLine("Well done, Keti! You combined loops and conditionals successfully.");


        }
    }
}
