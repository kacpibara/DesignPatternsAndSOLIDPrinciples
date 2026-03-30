using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCssharp.OopPrinciples.Encapsulation;

public class BankAccount
{
    // Auto-Implemented Properties
    //public decimal Balance { get; private set; }

     // C# Properties
    private decimal _balance;
    public decimal Balance
    {
        get
        {
            return this._balance;
        }
    }

    public BankAccount(decimal balance)
    {
        Deposit(balance);
    }

    // GetBalance - Java Style
    public decimal GetBalance()
    {
        return this._balance;
    }

    public void Deposit(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive");
        }

        this._balance += amount;
        //Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentException("Withdraw amount must be positive");
        }

        if(amount > this._balance)
        //if(amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds");
        }

        this._balance -= amount;
        //Balance -= amount;
    }

}