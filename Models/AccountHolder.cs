using System;
using System.Collections.Generic;

#nullable disable

namespace BankingWithDatabase.Models
{
    public partial class AccountHolder
    {
        public AccountHolder()
        {
            Accounts = new HashSet<Account>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
