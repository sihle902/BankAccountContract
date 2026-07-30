public class SavingsAccount : BankAccount
{
    public SavingsAccount(decimal initialBalance)
        : base(initialBalance)
    {
          Console.WriteLine("Savings Account created.");
    }
}