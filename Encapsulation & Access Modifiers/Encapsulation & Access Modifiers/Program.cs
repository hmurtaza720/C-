////Encapsulation & Access Modifiers

//// Simple BankAccount without Encapsulation


//using System;

//class BankAccount
//{
//    public string accountHolder;
//    public double balance;

//    public void ShowBalance()
//    {
//        Console.WriteLine(accountHolder + "'s Balance: " + balance);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount acc = new BankAccount();
//        acc.accountHolder = "Ali";
//        acc.balance = 1000;

//        acc.ShowBalance();
//    }
//}



using System;

class BankAccount
{
    private string accountHolder;
    private double balance;

    public string AccountHolder
    {
        get { return accountHolder; }
        set { accountHolder = value; }
    }

    public double Balance
    {
        get { return balance; }
        private set 
        {
            if (value >= 0)
                balance = value;
            else
                balance = 0;
        }
    }

    
    public BankAccount(string holder, double initialDeposit)
    {
        AccountHolder = holder;
        Balance = initialDeposit;
    }

    // Methods
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient funds or invalid amount!");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine(AccountHolder + "'s Balance: " + Balance);
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter Account Holder Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Initial Deposit:");
        double initialDeposit = Convert.ToDouble(Console.ReadLine());

        
        BankAccount acc1 = new BankAccount(name, initialDeposit);

        
        Console.WriteLine("Enter amount to deposit:");
        double depositAmount = Convert.ToDouble(Console.ReadLine());
        acc1.Deposit(depositAmount);

        
        Console.WriteLine("Enter amount to withdraw:");
        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
        acc1.Withdraw(withdrawAmount);

        
        Console.WriteLine("\n--- Final Account Summary ---");
        acc1.ShowBalance();
    }
}


