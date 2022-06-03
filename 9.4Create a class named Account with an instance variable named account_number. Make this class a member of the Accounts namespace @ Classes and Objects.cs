using System;

namespace Account
{
    class Account
    {
        int account_number = 1234567890;


        static void Main(string[] args)
        {
            Account account = new Account();
            Console.WriteLine("Account Number: " + account.account_number);
        }
    }
}
