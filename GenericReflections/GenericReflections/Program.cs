using System.Reflection;


namespace GenericReflections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //แบบที่ 1
            Type type = typeof(ConfigurationManager<>);


            //แบบที่2
            string myName = "Jeffrey";
            if(myName.GetType() == typeof(string))
            {
                // hey it's a string
            }

            

            Console.ReadKey();
        }
    }

}

internal class ConfigurationManager<T>
{
    public T  LoadedConfiguration { get; private set; }
    public ConfigurationManager(T config)
    {
        LoadedConfiguration = config;
    }

    public static void SaveConfig(T configToSave)
    {
        //logic
    }
}