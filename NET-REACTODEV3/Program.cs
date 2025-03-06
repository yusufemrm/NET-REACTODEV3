using System;


public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }

    public Employee(int id, string name, decimal salary, string department)
    {
        Id = id;
        Name = name;
        Salary = salary;
        Department = department;
    }


    public virtual decimal CalculateBonus()
    {
        return 0;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}, Department: {Department}");
    }
}


public class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(int id, string name, decimal salary, string department, int teamSize)
        : base(id, name, salary, department)
    {
        TeamSize = teamSize;
    }

    public override decimal CalculateBonus()
    {
        return Salary * 0.20m; 
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Team Size: {TeamSize}");
    }
}


public class Developer : Employee
{
    public string About { get; set; }

    public Developer(int id, string name, decimal salary, string department, string about)
        : base(id, name, salary, department)
    {
        About = about;
    }

    public override decimal CalculateBonus()
    {
        return Salary * 0.10m; 
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"About: {About}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager(1, "Ahmet", 10000, "İK", 5);
        Developer developer = new Developer(2, "Mehmet", 8000, "Yazılım", "Full-Stack Developer");

        manager.DisplayInfo();
        Console.WriteLine($"Manager Bonus: {manager.CalculateBonus()}");

        Console.WriteLine();

        developer.DisplayInfo();
        Console.WriteLine($"Developer Bonus: {developer.CalculateBonus()}");
    }
}
