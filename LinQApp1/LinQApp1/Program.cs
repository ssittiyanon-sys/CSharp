namespace LinQApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 1, 2, 3, 26, 15, 7, 4};
            
            Console.WriteLine(string.Join(" ", numbers));

            foreach (int num in numbers)
            {
                // ใช้ Write เฉยๆ พิมพ์ตัวเลข แล้วบวกช่องว่างตามหลัง
                Console.Write(num + " ");
            }
            Console.WriteLine("\n\nMore than 5 and arrange in Decensing");

            var query = from number in numbers
                        where number > 5
                        orderby number descending //ascending
                        select number;

            foreach (var i in query)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nMore than 5 and arrange in Ascending");

            var query2 = from number in numbers
                        where number > 5
                        orderby number ascending
                        select number;
            foreach (var i in query2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            int[] numbers2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            Console.WriteLine();
            Console.WriteLine("\nUse the static void OddNumbers");
            Console.WriteLine(string.Join(" ",numbers2));

            OddNumbers(numbers2);

            Console.ReadKey();

            Console.WriteLine("\n\nUse the static void EvenNumbers");
            Console.WriteLine(string.Join(" ", numbers2));
            EvenNumbers(numbers2);

            Console.ReadKey();
        }
        static void OddNumbers(int[] numbers2)
        {
            Console.WriteLine("Odd Numbers: ");
            IEnumerable<int> oddNumbers = from number in numbers2
                                          where number % 2 != 0
                                          select number;
            Console.WriteLine();
            foreach (int i in oddNumbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach (int i in oddNumbers)
            {
                Console.Write(i + " ");
            }
        }
        static void EvenNumbers(int[] numbers2)
        {
            Console.WriteLine("Even Numbers: ");
            IEnumerable<int> evenNumbers = from number in numbers2
                                           where number % 2 == 0
                                           select number;
            Console.WriteLine();
            foreach(int i in evenNumbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach (int i in evenNumbers)
            {
                Console.Write(i+" ");
            }
        }
    }   
}
