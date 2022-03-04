using System;

namespace Multiply_smaller_number
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a integer:");
            string input = Console.ReadLine();

            int result = 0;

            if (input.Length > 0)
            {
                int number = Convert.ToInt32(input);

                for (int i = 1; i < number; i++)
                {
                    if (result == 0)
                    {
                        result = number * i;
                    }
                    else
                    {
                        result = result * i;
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
