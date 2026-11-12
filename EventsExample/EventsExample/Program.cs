namespace EventsExample
{
    public delegate void TemperatureChangeHandler(string message);
    public class TemperatureMonitor
    {
        public event TemperatureChangeHandler OnTemperatureChanged;
        private int _temperature;
        public int Temperature 
        { 
            get { return _temperature; }
            set
            {
                _temperature = value;
                if(_temperature > 30)
                {
                    //Raised Event
                    RaiseTemperatureChangedEvent("Temperature is above threshold");
                }
            }  
        }
        protected virtual void RaiseTemperatureChangedEvent(string message)
        {
            OnTemperatureChanged?.Invoke(message);
        }
    }
    public class TemparatureAlert
    {
        public void OntemperatureChanged(string message)
        {
            Console.WriteLine("Alert: " + message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemparatureAlert alert = new TemparatureAlert();
            monitor.OnTemperatureChanged += alert.OntemperatureChanged;

            Console.WriteLine("Please enter the temperature: ");
            monitor.Temperature = int.Parse(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
