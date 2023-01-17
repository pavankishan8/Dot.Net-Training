using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    abstract class Account
        {
        public int AccNo { get; set; }
        public string Name { get; set; }
        public int Balance { get; private set; } = 5000;
        public void Credit(int amount) => Balance += amount;
        public void Debit(int amount) {
            if (amount > Balance)
                throw new Exception("Insufficient Funds");
            Balance -= amount;
        }

        public abstract void CalculateInterest();
    }

    class SBAccount : Account
    {
        public override void CalculateInterest()
        {
            var principal = Balance;
            var time = 0.25;
            var rate = 0.02;
            var interest = principal * time * rate;
            Credit((int)interest);
        }

    }

    class CUAccount : Account
    {
        public override void CalculateInterest()
        {
            var principal = Balance;
            var time = 0.50;
            var rate = 0.05;
            var interest = principal * time * rate;
            Credit((int)interest);
        }

    }

    class FDAccount : Account
    {
        public override void CalculateInterest()
        {
            var principal = Balance;
            var time = 0.300;
            var rate = 0.3;
            var interest = principal * time * rate;
            Credit((int)interest);
        }

    }
    class AbstractClasses
    {
        public static object AccountFactory { get; private set; }

        static void Main(string[] args)
        {

            AccountType type = Convert("SB");
            Account acc = AccountFactory.CreateAccount(type);
            
            acc.AccNo = 8555;
            acc.Name = "Raj";
            acc.Credit(56000);
            acc.CalculateInterest();
            Console.WriteLine("The SB balance is " + acc.Balance);

            //Account CUacc = new CUAccount();
            //acc.AccNo = 8555;
            //acc.Name = "Raj";
            //acc.Credit(56000);
            //acc.CalculateInterest();
            //Console.WriteLine("The CU balance is " + acc.Balance);

            //Account FDacc = new FDAccount();
            //acc.AccNo = 8555;
            //acc.Name = "Raj";
            //acc.Credit(56000);
            //acc.CalculateInterest();
            //Console.WriteLine("The FD balance is " + acc.Balance);

        }
    }

    enum AccountType { SB, CU, FD}
    class AccountFactory
    {
        public static Account CreateAccount(AccountType acc)
        {
            switch (acc)
            {
                

            }
        }
    }
}
