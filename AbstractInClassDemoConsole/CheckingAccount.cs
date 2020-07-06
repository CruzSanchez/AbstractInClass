using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInClassDemoConsole
{
    public class CheckingAccount : Account
    {
        public override void Withdraw()
        {
            Console.WriteLine("This is the checking account's implementation of the withdraw method!");
        }

        public override void Deposit()
        {
            Console.WriteLine("Deposit in checking");
            //base.Deposit();
        }
    }
}
