using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch_TransactionTask.Domain.DTOs
{
    public class CreateUserDTO
    {
        public string FullName { get; set; } = string.Empty;
        public string BankAccount { get; set; } = string.Empty;
    }
}
