using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationRelationship
{
    class Account
    {
        public string AccountNumber { set; get; }
        public string OpeningDate { set; get; }

        public double Amount {private set; get; }

        public double Deposite(double amount)
        {
            return Amount += amount;
        }

        public double Withdrawn(double amount)
        {
            return Amount -= amount;
        }
    }
}
