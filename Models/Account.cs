using System;
using System.Collections.Generic;

#nullable disable

namespace BankingWithDatabase.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; }

        public virtual AccountHolder User { get; set; }
    }
}
