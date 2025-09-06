// Encapsulation means wrapping data (fields/properties) and the methods (functions) 
// that operate on that data into a single unit — usually a class. 
// It also restricts direct access to some components of an object 
// to protect the internal state.


using System;

public class BankAccount
{
    private decimal balance;


    public BankAccount(decimal balance)
    {
        this.balance = balance;
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive");
        }


        this.balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdraw amount must be positive");
        }
 
        if(amount > balance)
        {
            throw new InvalidOperationException("Insufficient funds");
        }

        balance -= amount;
    }
}
