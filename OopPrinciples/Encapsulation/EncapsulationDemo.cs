

using DesignPatternsInCssharp.OopPrinciples.Encapsulation;

public class EncapsulationDemo
{
    public static void Run()
    {

        // Encapsulation

        // Bad Bank Account
        System.Console.WriteLine("Bad Bank Account Example");

        BadBankAccount badAccount = new BadBankAccount();

        badAccount.Balance = 100;
        System.Console.WriteLine(badAccount.Balance);

        badAccount.Balance = -150;
        System.Console.WriteLine(badAccount.Balance);


        // Good Bank Account

        System.Console.WriteLine("Good Bank Account Example");

        BankAccount bankAccount = new BankAccount(100);

        // System.Console.WriteLine(bankAccount.GetBalance());
        System.Console.WriteLine(bankAccount.Balance.ToString());

        bankAccount.Deposit(50);
        // System.Console.WriteLine(bankAccount.GetBalance());
        System.Console.WriteLine(bankAccount.Balance.ToString());

        bankAccount.Withdraw(100);
        // System.Console.WriteLine(bankAccount.GetBalance());
        System.Console.WriteLine(bankAccount.Balance.ToString());
        try
        {
            bankAccount.Withdraw(150);
            // System.Console.WriteLine(bankAccount.GetBalance());
            System.Console.WriteLine(bankAccount.Balance.ToString());
        }
        catch(Exception ex)
        {
            System.Console.WriteLine(ex.Message);

        }

        try
        {
            bankAccount.Withdraw(-100);
            // System.Console.WriteLine(bankAccount.GetBalance());
            System.Console.WriteLine(bankAccount.Balance.ToString());
        }
        catch(Exception ex)
        {
            System.Console.WriteLine(ex.Message);

        }
    }
}




