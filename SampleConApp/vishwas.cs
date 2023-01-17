using SampleConApp;
using System;


namespace ConsoleAppBook
{

    class Business
    {
        public virtual void Makepayment(string PayMode, double amount)
        {
            if (PayMode == "CreditCard")
            {
                Console.WriteLine("payment not accepted");
            }
            else
                Console.WriteLine("payment accepted {1} for Rs.{0}", amount, PayMode);
        }
    }
    class TechBusiness : Business
    {
        public override void Makepayment(string PayMode, double amount)
        {
            if (PayMode == "cheque")
            {
                Console.WriteLine("payment is no longer accepted");

            }
            else
                Console.WriteLine("payment accepted by {1} for Rs. {0} ", amount, PayMode);
        }
    }


    class BusinessFactory
    {
        public static Business GetObject(string arg)
        {
            if (arg.ToUpper() == "BUSINESS")
                return new Business();
            else if (arg.ToUpper() == "TECHBUSINESS")
                return new TechBusiness();
            else
                throw new Exception("this type business not available");
        }
    }

    class MethodOverRiding123
    {
        static void Main(string[] args)
        {
            string bussType = Utilities.Prompt("Enter the Type of the Business U want to run?");
            Business component = BusinessFactory.GetObject(bussType);
            component.Makepayment("CreditCard", 400);

        }
    }
}

