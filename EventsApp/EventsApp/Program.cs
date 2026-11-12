namespace EventsExample
{
    // Using the Generic Delegate EventHandler<TEventArgs>
    //public delegate void TemperatureChangeHandler(string message);
    public class TemperatureChangedEventArgs : EventArgs
    {
        // property holding the temperature
        public int Temperature { get; }
        // contructor
        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }
    public class TemperatureMonitor
    {
        public EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        //public event TemperatureChangeHandler OnTemperatureChanged;
        private int _temperature;
        public int Temperature
        {
            get { return _temperature; }
            set
            {
                
                if (_temperature != value)
                {
                    _temperature = value;
                    //Raised Event
                    OntTemperatureChanged(new TemperatureChangedEventArgs(_temperature));
                }
            }
        }
        protected virtual void OntTemperatureChanged(TemperatureChangedEventArgs e)
        {
            // Letting every subcriber know!
            TemperatureChanged?.Invoke(this, e);
        }
    }

    // Subscriber
    public class TempCoolingAlert
    {
        public void OntemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Alert: temperature is { e.Temperature} sender is: {sender}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TempCoolingAlert alert = new TempCoolingAlert();
            TempCoolingAlert alert2 = new TempCoolingAlert();
            monitor.TemperatureChanged += alert.OntemperatureChanged;
            monitor.TemperatureChanged += alert2.OntemperatureChanged;

            monitor.Temperature = 20;
            Console.WriteLine("Please enter the temperature: ");
            monitor.Temperature = int.Parse(Console.ReadLine());
            Console.ReadKey();
        }
    }
}