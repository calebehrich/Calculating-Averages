using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2ACalebEhrichPart1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[10];


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

            Console.Write("The sum is: ");

            foreach (int k in nums)
            {
                Console.WriteLine(nums.Sum());

                Console.ReadLine();
            }
        }
    }
}
