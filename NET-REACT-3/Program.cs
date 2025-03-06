using System;

// Abstract sınıf örneği
public abstract class Animal
{
    public string Name { get; set; }

    public Animal(string name) 
    {
        Name = name;
    }


    public abstract void MakeSound();


    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping...");
    }
}


public class Dog : Animal
{
    public Dog(string name) : base(name) 
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Woof Woof!");
    }
}


public class Cat : Animal
{
    public Cat(string name) : base(name) 
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow Meow!");
    }
}

class Program
{
    static void Main()
    {
        Animal dog = new Dog("Buddy");
        dog.MakeSound();  
        dog.Sleep();      

        Animal cat = new Cat("Kitty");
        cat.MakeSound();  
        cat.Sleep();      
    }
}
