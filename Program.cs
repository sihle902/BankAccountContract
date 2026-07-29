using System;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(1000m);

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n===== BANK ACCOUNT MENU =====");
            Console.WriteLine($"Current Balance: R{account.GetBalance()}");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.WriteLine("5. Restart Account");
            Console.Write("Choose an option: ");

            string? choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter amount to deposit: R");
                        decimal depositAmount = decimal.Parse(Console.ReadLine()!);

                        account.Deposit(depositAmount);

                        Console.WriteLine("Deposit successful!");
                        break;

                    case "2":
                        Console.Write("Enter amount to withdraw: R");
                        decimal withdrawAmount = decimal.Parse(Console.ReadLine()!);

                        account.Withdraw(withdrawAmount);

                        Console.WriteLine("Withdrawal successful!");
                        break;

                    case "3":
                        Console.WriteLine($"Current Balance: R{account.GetBalance()}");
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("Thank you for using the SG Bank Account App!");
                        break;

                   case "5":
                        account = new BankAccount(1000m);
                        Console.WriteLine("Account has been restarted.");
                        Console.WriteLine($"New Balance: R{account.GetBalance()}");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose between 1 and 5.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid numeric amount.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}