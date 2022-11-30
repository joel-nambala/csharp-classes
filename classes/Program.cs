using System;
using System.IO;

namespace classes
{
    // Create a class
    /*
    class Car
    {
        /*
        string color = "red"; // field
        int maxSpeed = 300; // field
        public void fullThrottle() // method
        {
            Console.WriteLine("This car is going as fast as it can");
        }
        */
    /*
    public string model;
    public string color;
    public int year;*/

    /// /////////////////////////////////////////////////////////////////
    /// constructors 
    /*public Car(string modelName, string modelColor, int modelYear) {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }*/
    /*
    //////////////////////////////////////////////////////
    // properties
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    static void Main(string[] args)
    {
        /*
        // create a car object
        Car toyota = new Car();
        Console.WriteLine(toyota.color);
        Console.WriteLine(toyota.maxSpeed);
        toyota.fullThrottle();*/
    /*Car ford = new Car("Mustang", "red", 1990);
    Console.WriteLine($"{ford.model} {ford.color} {ford.year}");
    Car ford = new Car();
    ford.Name = "Ford";
    Console.WriteLine(ford.Name);
}
}*/

    ///////////////////////////////////////////////////////////////////////
    /// Inheritance
    /*
    class Person
    {
        // Public fields
        public string firstName = "Joel";
        public string lastName = "Nambala";

        // Public methods
        public void greet() {
            string greet = $"Hello {firstName} {lastName} :)";
            Console.WriteLine(greet);
        }
    }

    // person instance
    class Student : Person {
        public string course = "Computer programming";

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student joel = new Student();
            joel.greet();
            Console.WriteLine(joel.course);
        }
    }
    */

    //////////////////////////////////////////////////////////////////////
    /// Polymorphism
    /*
    class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The dog says: bow bow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Pig myPig = new Pig();
            Dog myDog = new Dog();

            myAnimal.AnimalSound();
            myPig.AnimalSound();
            myDog.AnimalSound();
        }
    }
    */

    ///////////////////////////////////////////////////////
    /// abstraction
    /*
    abstract class Animal
    {
        // abstracted method
        public abstract void animalSound();

        // regular method
        public void sleep() {
            Console.WriteLine("Zzzz");
        }
    }

    class Pig : Animal {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();
            myPig.sleep();
        }
    }
    */

    ////////////////////////////////////////////////////
    /// interface
    /*
    interface Animal
    {
        void animalSound();
    }

    class Pig : Animal { 
    public void animalSound() {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();
        }
    }
    */
    /*
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World";
            File.WriteAllText("text.txt", writeText);

            string readText = File.ReadAllText("text.txt");
            Console.WriteLine(readText);
        }
    }
    */
}