using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_class
{
    public class BankAccount
    {
        public int accountNumber { get; set; }
        public double Balance { get; set; }
        public void Deposit(int amount)
        {
            Balance += amount;
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            BankAccount myaccount = new BankAccount();

            myaccount.accountNumber = 1001;
            myaccount.Balance = 1000;

            Console.WriteLine("Enter deposit amount");
            int amount = int.Parse(Console.ReadLine());

            myaccount.Deposit(amount);

            Console.WriteLine($"Account Number:{myaccount.accountNumber}");
            Console.WriteLine($"Balance: {myaccount.Balance}");

            Console.ReadLine();






        }
    }
}
