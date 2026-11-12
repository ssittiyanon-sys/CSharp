using System; // 🌟 เติมเวทมนตร์บรรทัดนี้เข้าไป!

namespace DependencyInjectionApp // 🌟 เคาะลงมาบรรทัดใหม่แล้ว
{
    internal partial class Program
    {
        // Basic Dependency
        public class Builder
        {
            private Hammer _basichammer;
            private Saw _basicsaw;
            public Builder()
            {
                _basichammer = new Hammer(); // Builder is responsible for creating its 
                _basicsaw = new Saw();
            }
            public void BuildHouse()
            {
                _basichammer.Use();
                _basicsaw.Use();
                Console.WriteLine("House Built");
            }
        }
        public class Hammer
        {
            public void Use()
            {
                Console.WriteLine("Smash!");
            }
        }
        public class Saw
        {
            public void Use()
            {
                Console.WriteLine("Sawing wood!");
            }
        }

        // Simple Dependency ## Injection ##
        public class SimpleBuilder
        {
            private SimpleHammer _simplehammer;
            private SimpleSaw _simplesaw;

            // Constructor Dependency Injection (DI)
            public SimpleBuilder(SimpleHammer hammer, SimpleSaw saw) // Injection here
            {
                _simplehammer = hammer;
                _simplesaw = saw;
            }
            public void BuildHouse()
            {
                _simplehammer.Use();
                _simplesaw.Use();
                Console.WriteLine("House Built");
            }
        }
        public class SimpleHammer
        {
            public void Use()
            {
                Console.WriteLine("Smash!");
            }
        }
        public class SimpleSaw
        {
            public void Use()
            {
                Console.WriteLine("Sawing wood!");
            }
        }

        // Setter Dependency Injection
        public class SetterBuilder
        {
            public SetterHammer? Hammer { get; set; } // Property
            public SetterSaw? Saw { get; set; } // Property

            // Setter DI
            public void BuildHouse()
            {
                // ใส่เครื่องหมาย ? เผื่อกรณีที่ตัวแปรยังเป็น null จะได้ไม่ Error ครับ
                Hammer?.Use();
                Saw?.Use();
                Console.WriteLine("House Built");
            }
        }
        public class SetterHammer
        {
            public void Use()
            {
                Console.WriteLine("Smash!");
            }
        }
        public class SetterSaw
        {
            public void Use()
            {
                Console.WriteLine("Sawing wood!");
            }
        }

        // Interface Dependency Injection
        public interface IToolUsers
        {
            void SettingHammer(InterfaceHammer interfacehammer);
            void SettingSaw(InterfaceSaw interfacesaw);
        }
        public class InterfaceHammer
        {
            public void Use()
            {
                Console.WriteLine("Smash!");
            }
        }
        public class InterfaceSaw
        {
            public void Use()
            {
                Console.WriteLine("Sawing wood!");
            }
        }

        public class InterfaceBuilder : IToolUsers
        {
            private InterfaceHammer? _interfacehammer;
            private InterfaceSaw? _interfacesaw;

            public void BuildHouse()
            {
                // เช็คกันเหนียว เผื่อลืมส่งเครื่องมือมาให้
                if (_interfacehammer != null && _interfacesaw != null)
                {
                    _interfacehammer.Use();
                    _interfacesaw.Use();
                    Console.WriteLine("House Built");
                }
            }

            public void SettingHammer(InterfaceHammer iHammer)
            {
                _interfacehammer = iHammer;
            }

            public void SettingSaw(InterfaceSaw iSaw)
            {
                _interfacesaw = iSaw;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Simple Dependency Injection");
            // 1. สร้างเครื่องมือ
            SimpleHammer hammer = new SimpleHammer();
            SimpleSaw saw = new SimpleSaw();
            // 2. สร้างช่างก่อสร้าง
            SimpleBuilder simplebuilder = new SimpleBuilder(hammer, saw);
            // 3. สั่งสร้างบ้าน!
            simplebuilder.BuildHouse();

            Console.WriteLine("\nSetter Dependency Injection");
            // 1. สร้างเครื่องมือ
            SetterHammer setterhammer = new SetterHammer();
            SetterSaw settersaw = new SetterSaw();
            // 2. สร้างช่างก่อสร้าง
            SetterBuilder setterbuilder = new SetterBuilder();
            // 3. ฉีด (Inject)
            setterbuilder.Hammer = setterhammer;
            setterbuilder.Saw = settersaw;
            setterbuilder.BuildHouse();

            Console.WriteLine("\nInterface Dependency Injection");
            // 1. สร้างเครื่องมือ
            InterfaceHammer iHammer = new InterfaceHammer();
            InterfaceSaw iSaw = new InterfaceSaw();
            // 2. สร้างช่างก่อสร้าง
            InterfaceBuilder interfaceBuilder = new InterfaceBuilder();
            // 3. ฉีด (Inject) เครื่องมือเข้าไปผ่าน Interface Method
            interfaceBuilder.SettingHammer(iHammer);
            interfaceBuilder.SettingSaw(iSaw);
            // 4. สั่งสร้างบ้าน!
            interfaceBuilder.BuildHouse();

            Console.ReadKey();
        }
    }
}