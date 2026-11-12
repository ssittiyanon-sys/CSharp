using System;

namespace Coding.Exercise
{
    public interface ILoggingService
    {
        void Log(string message);
    }

    public class LoggingService : ILoggingService
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    // ==========================================
    // 1. Constructor Injection
    // ==========================================
    public class MyClassConstructorInjection
    {
        private readonly ILoggingService _loggingService;
        public MyClassConstructorInjection(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public void PerformAction()
        {
            // ✅ สั่งลั่นไก
            _loggingService.Log("Constructor Injection: Logging message.");
        }
    }

    // ==========================================
    // 2. Setter Injection
    // ==========================================
    public class MyClassSetterInjection
    {
        public ILoggingService LoggingService { private get; set; }

        public void PerformAction()
        {
            // ✅ สั่งลั่นไก (ใช้ชื่อ Property ตัวใหญ่)
            LoggingService.Log("Setter Injection: Logging message.");
        }
    }

    // ==========================================
    // 3. Interface Injection
    // ==========================================
    public interface IDependencyInjector
    {
        void SetDependency(ILoggingService loggingService);
    }

    public class MyClassInterfaceInjection : IDependencyInjector
    {
        private ILoggingService _loggingService;
        public void SetDependency(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public void PerformAction()
        {
            // ✅ สั่งลั่นไก
            _loggingService.Log("Interface Injection: Logging message.");
        }
    }

    // ==========================================
    // 🎯 จุดรันโปรแกรม (Main Exercise)
    // ==========================================
    public class Exercise
    {
        static void Main(string[] args)
        {
            // สร้าง Service (สร้างกระสุน)
            var loggingService = new LoggingService();
            // ท่าที่ 1
            var constructorInjection = new MyClassConstructorInjection(loggingService);
            constructorInjection.PerformAction(); // ✅ สั่งทำงาน
            // ท่าที่ 2
            var setterInjection = new MyClassSetterInjection { LoggingService = loggingService };
            setterInjection.PerformAction(); // ✅ สั่งทำงาน
            // ท่าที่ 3
            var interfaceInjection = new MyClassInterfaceInjection();
            interfaceInjection.SetDependency(loggingService);
            interfaceInjection.PerformAction(); // ✅ สั่งทำงาน
            Console.ReadKey();
        }
    }
}