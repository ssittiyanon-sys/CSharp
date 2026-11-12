namespace Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3 ,4, 5, 6, 7, 8,9};

            OddNumbers(numbers);

            EvenNumbers(numbers);
            Console.ReadLine();


        }
        static void OddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd numbers: ");

            IEnumerable<int> oddNumbers = from number in numbers
                                          where number %2 != 0
                                          select number;
            Console.WriteLine(oddNumbers);
            foreach(int i in oddNumbers)
            {
                Console.WriteLine(i);
            }
        }
        static void EvenNumbers(int[] numbers)
        {
            Console.WriteLine("Even numbers: ");
            IEnumerable<int> evenNumbers = from number in numbers
                                           where number % 2 == 0
                                           select number;
            Console.WriteLine(evenNumbers);
            foreach(int i in evenNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
