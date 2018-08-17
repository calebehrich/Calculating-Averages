using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2ACalebEhrichPart2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[10];
            int sum = 0;

            for (int y = 0; y < 10; y++)
            {
                do
                {


                    Console.WriteLine("Enter the numbers: ");
                    nums[y] = int.Parse(Console.ReadLine());
                    if (nums[y] < 0 || nums[y] > 100)
                    {
                        Console.WriteLine("Number must be between 0 and 100.");
                    }

                } while (nums[y] < 0 || nums[y] > 100);
            }

            Console.Write("The average is: ");

            for (int i = 0; i < 10; i++)
            {
                sum += nums[i];
            }

            var avg = (sum / 10);
            Console.WriteLine(avg);


            switch (avg)
            {
                case int grade when (avg >= 90):
                    Console.WriteLine(" A");
                    break;
                case int grade when (avg >= 80) && (avg <= 90):
                    Console.WriteLine(" B");
                    break;
                case int grade when (avg >= 70) && (avg <= 80):
                    Console.WriteLine(" C");
                    break;
                case int grade when (avg >= 60) && (avg <= 70):
                    Console.WriteLine(" D");
                    break;
                case int grade when (avg <= 60):
                    Console.WriteLine(" F");
                    break;

            }
        }
    }
}

