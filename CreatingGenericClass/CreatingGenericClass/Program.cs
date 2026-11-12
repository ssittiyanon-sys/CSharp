using System.Runtime.CompilerServices;

namespace CreatingGenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Box<int> box = new Box<int>();
            box.Content = 1;
            Console.WriteLine(box.Log());

            Box<string> boxStr = new Box<string>();
            boxStr.Content = "Jeffrey";
            Console.WriteLine(boxStr.Log());
            Console.ReadKey();
        }
    }
}
