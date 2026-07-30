public class CurrentAccount : BankAccount
{
    public CurrentAccount(decimal initialBalance)
        : base(initialBalance)
    {
          Console.WriteLine("Current Account created.");
    }
}