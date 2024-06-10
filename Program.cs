using System;

namespace Adddays_Vilgera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input day number: ");
            int dayOne = int.Parse(Console.ReadLine());

            string num1 = Add(dayOne);
            Console.WriteLine(num1);

            Console.Write("Input number to add to the day: ");
            int day2 = Convert.ToInt16(Console.ReadLine());

            int addi = Addition(dayOne, day2);
            string last = FinalDay(addi);
            Console.WriteLine(last);
            
        }
        public static string Add(int dayOne)
        {
            string num1 = "";
            switch (dayOne)
            {
                case 1:
                    Console.WriteLine("The day is Monday.");
                    break;

                case 2:
                    Console.WriteLine("The day is Tuesday.");
                    break;

                case 3:
                    Console.WriteLine("The day is Wednesday.");
                    break;

                case 4:
                    Console.WriteLine("The day is Thursday.");
                    break;

                case 5:
                    Console.WriteLine("The day is Friday.");
                    break;

                case 6:
                    Console.WriteLine("The day is Saturday.");
                    break;

                case 7:
                    Console.WriteLine("The day is Sunday.");
                    break;
            }
            return num1;
        }
        public static int Addition(int dayOne, int day2)
        {
            int addi = (dayOne + day2);
            return addi;
        }
        public static string FinalDay(int finalDay)
        {
            string last = "";
            switch (finalDay)
            {
                case 1:
                    Console.WriteLine("The day is MONDAY");
                    break;
                case 2:
                    Console.WriteLine("The day is TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("The day is WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("The day is THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("The day is FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("The day is SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("The day is SUNDAY");
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
            return last;
        }
    }
}