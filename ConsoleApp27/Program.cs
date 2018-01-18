using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {

            //task 1

            int j, x, rows;

            Console.WriteLine("Give a number of rows: ");
            rows = Convert.ToInt16(Console.ReadLine());

            for (x = 1; x <= rows; x++)
            {
                for (j = 1; j <= x; j++)
                    Console.Write(" * ");
                Console.Write("\n");
            }


            // //task 2


            int i, n;
            int[] a = new int[100];


            Console.Write("Input the number of elements to store in the array :");
            n = Convert.ToInt16(Console.ReadLine());



            Console.Write("Input {0} number of elements in the array :", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Number - {0} : ", i);
                a[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("The values store into the array in reverse are: ");
            for (i = n - 1; i >= 0; i--)
            {
                Console.WriteLine("{0} ", a[i]);
            }
            Console.Write("\n\n");



            //task 3
            //task 4  
            //task 6

            int total = 1;
            int ranNum1,
                guess;

            string guessStr;

            Random ranNumGen = new Random();
            ranNum1 = ranNumGen.Next(1, 100);

            Console.Write("Enter your guess  ");
            guessStr = Console.ReadLine();
            guess = Convert.ToInt16(guessStr);

            while (guess != ranNum1)
            {
                while (guess < ranNum1)
                {
                    Console.WriteLine("Your guess is to low, try again.");
                    Console.Write(" Enter your guess  ");
                    guessStr = Console.ReadLine();
                    guess = Convert.ToInt16(guessStr);
                    ++total;
                }
                while (guess > ranNum1)
                {
                    Console.WriteLine("Your guess is to high, try again.");
                    Console.Write("Enter your guess ");
                    guessStr = Console.ReadLine();
                    guess = Convert.ToInt16(guessStr);
                    ++total;
                }
            }

            Console.WriteLine("Good job, your guess is right! " + "You took" + total + " guesses");





        }
    }
}
