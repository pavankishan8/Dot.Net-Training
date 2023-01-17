﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworksApp.Practical
{
    /// <summary>
    /// Represents the entity of our application.
    /// </summary>
    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int BillAmount { get; set; }

        public void Copy(Customer cst)
        {
            CustomerId = cst.CustomerId;
            CustomerName = cst.CustomerName;
            CustomerAddress = cst.CustomerAddress;
            BillAmount = cst.BillAmount;
        }

        public override int GetHashCode()
        {
            return CustomerId.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Customer)
            {
                var unBoxed = obj as Customer;
                if (CustomerId == unBoxed.CustomerId && CustomerName == unBoxed.CustomerName && CustomerAddress == unBoxed.CustomerAddress)
                    return true;
            }
            return false;
        }
        public override string ToString()
        {
            //return $"Name: {CustomerName} from {CustomerAddress} with Bill Amount: {BillAmount}";
            return ($"{CustomerId}, {CustomerName}, {CustomerAddress}, {BillAmount}\n");
        }

    }
}
