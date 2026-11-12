using System.Reflection;
namespace ActionGenericDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action action = () => 
            { 
                Console.WriteLine("Hello Jeffrey"); 
            }; // lambda คือ return

            action();

            Action<int> numPrint = (x) =>
            {
                Console.WriteLine(x);
            };

            numPrint(10);

            Action<float, float, float> sum = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };

            sum(1, 2, 3);
            Console.ReadKey();
        }
    }
}
