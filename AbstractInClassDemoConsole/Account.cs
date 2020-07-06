using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInClassDemoConsole
{
    public abstract class Account
    {
        public Customer Client { get; set; }
        public string AccountNumber { get; set; }

        //Abstract method cannot have implentations
        public abstract void Withdraw();

        public virtual void Deposit()
        {
            Console.WriteLine("Depositing");
        }
        
    }
}
