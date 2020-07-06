using System;

namespace AbstractInClassDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checking = new CheckingAccount();
            checking.Withdraw();
            checking.Deposit();
        }
    }
}
