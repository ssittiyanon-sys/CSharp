namespace LinQApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "berta", "claus", "adam" };
            var query = from name in names
                        orderby name ascending
                        select name;
            foreach (var i in query)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            ////
            ////
            
            int[] numbers = new int[] { 75, 13, 125, 4 };
            var query2 = from number in numbers
                          where number > 5
                          orderby number descending
                          select number;
            foreach (var i in query2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
