using System;
using System.Collections.Generic;
using System.Text;
using BillShare.Contracts.Persistence;
using CommonBase.Extensions;

namespace BillShare.Logic.Entities.Persistence
{
    class Bill : IdentityObject, Contracts.Persistence.IBill
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public string Friends { get; set; }

        public void copyProperties(IBill other)
        {
            other.CheckArgument(nameof(other));

            Id = other.Id;
            Date = other.Date;
            Title = other.Title;
            Description = other.Description;
            Currency = other.Currency;
            Friends = other.Friends;
        }
        public IEnumerable<Expense> Expenses { get; set; }
    }
}
