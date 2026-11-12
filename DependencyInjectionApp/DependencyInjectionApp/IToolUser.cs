namespace DependencyInjectionApp
{
    internal partial class Program
    {
        // Interface Dependency Injection

        public interface IToolUsers
        {
            void SetHammer(Hammer hammer);
            void SetSaw(Saw saw);
        }
    }
}
