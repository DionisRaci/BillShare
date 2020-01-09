using System;
using System.Collections.Generic;
using System.Text;
using BillShare.Contracts.Persistence;
using CommonBase.Extensions;

namespace BillShare.Logic.Entities.Persistence
{
    internal class Expense : IdentityObject, Contracts.Persistence.IExpense
    {
        public int BillID { get; set; }
        public string Designation { get; set; }
        public double Amount { get; set; }
        public string Friend { get; set; }
        public Bill Bill { get; set; }

        public void copyProperties(IExpense other)
        {
            other.CheckArgument(nameof(other));
            BillID = other.BillID;
            Designation = other.Designation;
            Amount = other.Amount;
            Friend = other.Friend;
        }
    }
}
