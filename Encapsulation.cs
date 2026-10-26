using System;

class Encapsulation
{
    public static void Main()
    {
        Bank bank = new Bank();
         bank.Deposit = 450;
        Console.WriteLine(bank.Deposit);
        bank.Withdrawan = 56000;
        Console.WriteLine(bank.Withdrawan);
        
        

    }
}

class Bank
{
    private double balance = 25000.56;

    public double Deposit
    {
        get
        {
            return balance;
        }

        set
        {
            if(value <0 )
            {
                Console.WriteLine("Enter valid Amount for deposit");
            }
            else
            {
                balance += value;
            }
        }
    }

    public double Withdrawan
    {
        get
        {
            return balance;
        }

        set
        {
            if(value <0)
            {
                Console.WriteLine("Invalid amount for withdrawan");
            }
            else if(value>=balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                balance -= value;
            }
        }
    }
}