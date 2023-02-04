/*
 * Author: Ron Jeremy Reyes
 * Course: COMP-003A
 * Purpose: Assignment for week 3
 */
namespace COMP003A.Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* If-Else Section (Numeric to Letter Grade) */
            Console.WriteLine("Numeric to letter grade using an if-else statement");
            Console.Write("Enter a numeric grade (0-100): ");
            double numericGrade = Convert.ToDouble(Console.ReadLine());

            if (numericGrade >= 0 && numericGrade <= 100)
            {
                if (numericGrade >= 90) // console output Letter Grade: A
                {
                    Console.WriteLine("Letter Grade: A");
                }
                else if (numericGrade >= 80) // console output Letter Grade: B
                {
                    Console.WriteLine("Letter Grade: B");
                }
                else if (numericGrade >= 70) // console output Letter Grade: C
                {
                    Console.WriteLine("Letter Grade: C");
                }
                else if (numericGrade >= 60) // console output Letter Grade: D
                {
                    Console.WriteLine("Letter Grade: D");
                }
                else // console output Letter Grade: F
                {
                    Console.WriteLine("Letter Grade: F");
                }
            }
            else // // console output Invalid input!
            {
                Console.WriteLine("Invalid Input!");
            }
            Console.WriteLine("**************************************************");

            /* Switch Section (integer to String Day) */
            Console.WriteLine("Integer to string day using a swtich statement");
            Console.Write("Enter an integer day of the week (1-7): ");
            int numericDay = Convert.ToInt32(Console.ReadLine());

            switch (numericDay)
            {
                case 1:
                    Console.WriteLine("String Day: Monday");
                    break;
                case 2:
                    Console.WriteLine("String Day: Tuesday");
                    break;
                case 3:
                    Console.WriteLine("String Day: Wednesday");
                    break;
                case 4:
                    Console.WriteLine("String Day: Thursday");
                    break;
                case 5:
                    Console.WriteLine("String Day: Friday");
                    break;
                case 6:
                    Console.WriteLine("String Day: Saturday");
                    break;
                case 7:
                    Console.WriteLine("String Day: Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Day!");
                    return;
            }
        }
    }
}