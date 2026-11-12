namespace InheritanceBaseClassVSDerivedClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance App Running!");
            
            Dog myDog = new Dog();
            Console.WriteLine("\nDog Created");
            myDog.MakeSound();
            myDog.Eat();

            Cat myCat = new Cat();
            Console.WriteLine("\nCat Created");
            myCat.MakeSound();
            myCat.Eat();

            Console.WriteLine("\nBase Class");
            BaseClass baseClass = new BaseClass();
            baseClass.ShowField();

            Console.WriteLine("\nDerived Class");
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.ShowField();

            Console.WriteLine("\nDerived Class After Calling AccessField() method");
            derivedClass.AccessField();
            derivedClass.ShowField();

            Console.ReadKey();
        }
    }


    // Single Inheritance
    // Base Class (Parent Class or Superclass)
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
        public virtual void MakeSound() // virtual keyword allow us to override Subclass //
                                        // Method Overriding with override and virtual
        {
            Console.WriteLine("Animal makes a generic sound");
        }

    }


    // Derived Class(Child Class or Subclass)
    // The class that inherits the members of the base class.

    // Inherits Class //
    class Dog: Animal // use : follow by Parent Class
    {
        public override void MakeSound()
        {
            base.MakeSound(); // use keyword "base" as Parent Class but cannot use "Animal"
            Console.WriteLine("Barking...");
        }
    }
    // Inherits Class //
    class Cat : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Meaow");
        }
    }

    // Multi Level of Inheritance
    // A breed if Dog
    class Collie: Dog
    {
        public void GoingNuts()
        {
            Console.WriteLine("Collie going Nuts");
        }
    }

    class BaseClass
    {
        // Access Modifiers and the Protected Keyword
        public int publicField; // Public available for every class
        protected int protectedField; // Protected available to Class or Deriving Class
        private int privateField; // Private is for within the same class

        public void ShowField()
        {
            Console.WriteLine($"Public: {publicField}, " +
                $"Protected: {protectedField}, Private: {privateField}");
        }
    }
    class DerivedClass : BaseClass
    {
        public void AccessField()
        {
            publicField = 1;
            protectedField = 2;
            // privateField = 3; // Private is for within the same class (Class BaseClass)
        }
    }
}
