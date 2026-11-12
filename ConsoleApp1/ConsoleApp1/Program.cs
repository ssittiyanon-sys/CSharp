using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int number;
        public static int DoubleValue(int number)
        {
            // TODO: Implement the method to double the value
            while (true)
            {
                if (number == 0)
                {
                    Console.WriteLine("Error the 0 cannot double but yes answer is 0");
                }
                else
                {
                    int result = number * 2;
                    string resultFinal = $"{result}";
                    Console.WriteLine($"The result of execution for the default integer should be: {resultFinal}");
                    Console.ReadKey();
                }

            }
            Console.WriteLine("Error the number should not be empty");
        }

        public static void Main(string[] args)
        {
            // TODO: Call DoubleValue and print the result
            int x = 10;
            DoubleValue(x);
        }
    }
}
