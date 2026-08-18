using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.Tutorial_3
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double Balance { get; set; }

        public BankAccount(int accountNumber, string name, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = name;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Amount deposited successfully.");
            }
            else
            {
                Console.WriteLine("Invalid amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Amount withdrawn successfully.");
            }
        }

        public void BalanceEnquiry()
        {
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("Account Holder : " + AccountHolderName);
            Console.WriteLine("Current Balance: ₹" + Balance);
        }
    }

    internal class t3_11 
    {
        public static void Main()
        {
            Console.Write("Enter number of accounts: ");
            int n = Convert.ToInt32(Console.ReadLine());

            BankAccount[] accounts = new BankAccount[n];

            // Create multiple accounts
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEnter details for Account " + (i + 1));

                Console.Write("Account Number: ");
                int accountNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Account Holder Name: ");
                string name = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double balance = Convert.ToDouble(Console.ReadLine());

                accounts[i] = new BankAccount(accountNumber, name, balance);
            }

            while (true)
            {
                Console.WriteLine("\n========== BANK MENU ==========");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Balance Enquiry");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 4)
                {
                    Console.WriteLine("Thank you for using the bank system.");
                    break;
                }

                Console.Write("Enter Account Number: ");
                int accNo = Convert.ToInt32(Console.ReadLine());

                BankAccount account = null;

                foreach (BankAccount acc in accounts)
                {
                    if (acc.AccountNumber == accNo)
                    {
                        account = acc;
                        break;
                    }
                }

                if (account == null)
                {
                    Console.WriteLine("Account not found.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter deposit amount: ");
                        double deposit = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(deposit);
                        break;

                    case 2:
                        Console.Write("Enter withdrawal amount: ");
                        double withdraw = Convert.ToDouble(Console.ReadLine());
                        account.Withdraw(withdraw);
                        break;

                    case 3:
                        account.BalanceEnquiry();
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}