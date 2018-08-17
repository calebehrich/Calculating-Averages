using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2ACalebEhrichPart4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> studentGrades = new List<int>();


            Console.WriteLine("Enter the test scores. Enter -1 to calculate average.");
            var testScore = int.Parse(Console.ReadLine());

            do
            {
                testScore = int.Parse(Console.ReadLine());
                if (testScore < -1 || testScore > 100)
                {
                    Console.WriteLine("Number must be between 0 and 100 or -1 to quit.");
                }
                else if(testScore == -1)
                    {
                    break;
                    }
                else 
                {
                    studentGrades.Add(testScore);
                }
            }
            while (testScore != -1);

            int sum = 0;


            Console.Write("The average is: ");

            for (int i = 0; i < studentGrades.Count(); i++)
            {
                sum += studentGrades[i];
            }

            var avg = (sum / studentGrades.Count());
            Console.Write(avg);


            switch (avg)
            {
                case int grade when (avg >= 90):
                    Console.WriteLine(" - A");
                    break;
                case int grade when (avg >= 80) && (avg <= 90):
                    Console.WriteLine(" - B");
                    break;
                case int grade when (avg >= 70) && (avg <= 80):
                    Console.WriteLine(" - C");
                    break;
                case int grade when (avg >= 60) && (avg <= 70):
                    Console.WriteLine(" - D");
                    break;
                case int grade when (avg <= 60):
                    Console.WriteLine(" - F");
                    break;






            }
        }
    }
}
