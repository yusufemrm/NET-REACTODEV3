using System;


public class BankAccount
{
    public string AccountHolder { get; set; }
    public decimal Balance { get; set; }

    public BankAccount(string accountHolder, decimal balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

   
    public virtual void CalculateInterest()
    {
        Console.WriteLine("Interest calculation is not defined.");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance:C}");
    }
}


public class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountHolder, decimal balance)
        : base(accountHolder, balance)
    {
    }

    public override void CalculateInterest()
    {
        decimal interest = Balance * 0.05m; 
        Console.WriteLine($"Savings Account Interest: {interest:C}");
    }
}


public class CheckingAccount : BankAccount
{
    public CheckingAccount(string accountHolder, decimal balance)
        : base(accountHolder, balance)
    {
    }

    public override void CalculateInterest()
    {
        Console.WriteLine("Checking accounts do not earn interest.");
    }
}


class Program
{
    static void Main(string[] args)
    {
  
        SavingsAccount savings = new SavingsAccount("Ahmet Yılmaz", 10000);
        savings.DisplayInfo();
        savings.CalculateInterest();

        Console.WriteLine();

       
        CheckingAccount checking = new CheckingAccount("Mehmet Kaya", 5000);
        checking.DisplayInfo();
        checking.CalculateInterest();
    }
}
