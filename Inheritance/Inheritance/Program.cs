using System;

class BankAccount
{
    public string AccountHolder;
    public decimal Balance;

    public BankAccount(string holder, decimal initialBalance)
    {
        AccountHolder = holder;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"{AccountHolder} deposited {amount}. Balance = {Balance}");
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"{AccountHolder} withdrew {amount}. Balance = {Balance}");
        }
        else
        {
            Console.WriteLine("Not enough balance!");
        }
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(string holder, decimal initialBalance)
        : base(holder, initialBalance)
    {
    }
}

class CurrentAccount : BankAccount
{
    private decimal OverdraftLimit = 500;

    public CurrentAccount(string holder, decimal initialBalance)
        : base(holder, initialBalance)
    {
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= Balance + OverdraftLimit)
        {
            Balance -= amount;
            Console.WriteLine($"{AccountHolder} withdrew {amount}. Balance = {Balance}");
        }
        else
        {
            Console.WriteLine("Withdrawal denied! Overdraft limit exceeded.");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter account holder name: ");
        string name = Console.ReadLine();

        Console.Write("Enter initial deposit: ");
        decimal initial = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Choose account type: 1 = Savings, 2 = Current");
        int choice = Convert.ToInt32(Console.ReadLine());

        BankAccount acc;

        if (choice == 1)
            acc = new SavingsAccount(name, initial);
        else
            acc = new CurrentAccount(name, initial);

        Console.Write("Enter deposit amount: ");
        decimal dep = Convert.ToDecimal(Console.ReadLine());
        acc.Deposit(dep);

        Console.Write("Enter withdraw amount: ");
        decimal with = Convert.ToDecimal(Console.ReadLine());
        acc.Withdraw(with);
    }
}
