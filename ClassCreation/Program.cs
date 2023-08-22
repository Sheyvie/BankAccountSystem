
//Design a class representing a basic Bank Account. It should have methods to deposit, withdraw, and check the balance.
using System;
using System.Threading.Channels;
class BankAccount
{
    private string accountHolder;
    private double balance;

    public BankAccount(string accountHolder, double initialBalance)
    {
        this.accountHolder = accountHolder;
        this.balance = initialBalance;
    }

    public string AccountHolder
    {
        get { return accountHolder; }
    }

    public double Balance
    {
        get { return balance; }
       

    }

    public void Deposit(double amount)

    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"{amount:C} deposited successfully");
        }
        else
        {
            Console.WriteLine("Invalid amount");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"{amount:C} withdrwan successfully, Your balance is {balance}");

        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount of insufficient balance");
        }


    }
   
}
class Program {
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("Senji", 30000.00);


        Console.WriteLine($"Welcome to Your Account: {account.AccountHolder}");
        Console.WriteLine($"Initial balance: {account.Balance:C}");
        while (true)
        {
            Console.WriteLine("select an option");
            Console.WriteLine("1. Deposit Money: ");
            Console.WriteLine("2.Withdraw Cash");
            Console.WriteLine("3.Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the amount you want to deposit");
                    double depositAmount = double.Parse(Console.ReadLine());
                    account.Deposit(depositAmount);
                    Console.WriteLine($"Current balance: {account.Balance:C}");
                    break;
                case 2:
                    Console.WriteLine("Enter the amount you want to withdraw");
                    int withdrawAmount = int.Parse(Console.ReadLine());
                    account.Withdraw(withdrawAmount);
                    Console.WriteLine($"Current balance: {account.Balance:C}");
                    break;
                case 3:
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }

        }
    }


    
}
