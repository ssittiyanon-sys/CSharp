namespace MultipleGenericTypesInAClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int, string> box = new Box<int, string>(199, "Jeffrey");
            box.Display();

            Console.ReadKey();
        }
    }
}
