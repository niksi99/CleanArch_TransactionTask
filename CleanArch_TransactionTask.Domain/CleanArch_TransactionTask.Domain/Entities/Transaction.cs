using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch_TransactionTask.Domain.Entities
{
    public class Transaction
    {
        public string Id { get; set; } = string.Empty;
        public decimal Amount { get; set; }
    }
}
