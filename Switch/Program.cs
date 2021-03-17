using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your day:");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Today is Saturday");
                    break;
                case 2:
                    Console.WriteLine("Today is Sunday");
                    break;
                case 3:
                    Console.WriteLine("Today is Monday");
                    break;
                case 4:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 5:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case 6:
                    Console.WriteLine("Today is Thursday");
                    break;
                default:
                    Console.WriteLine("End of Week");
                    break;



            }
        }
    }
}

