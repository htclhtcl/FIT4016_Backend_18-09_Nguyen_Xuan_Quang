using System;

namespace Encapsulation
{
    class BankAccount
    {
        private double _balance; // private field

        // Property chỉ đọc
        public double Balance
        {
            get { return _balance; }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)

            {
                _balance += amount;
                Console.WriteLine($"Gửi {amount} thành công. Số dư: {_balance}");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"Rút {amount} thành công. Số dư: {_balance}");
            }
            else
            {
                Console.WriteLine("Không đủ tiền!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();

            acc.Deposit(1000);
            acc.Withdraw(300);
            acc.Withdraw(1000); // test không đủ tiền
        }
    }
}
