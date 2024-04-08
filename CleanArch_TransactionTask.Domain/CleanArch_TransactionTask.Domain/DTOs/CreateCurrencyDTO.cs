using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch_TransactionTask.Domain.DTOs
{
    public class CreateCurrencyDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Symbol { get; set; } = string.Empty;
        public string Abbrivation { get; set; } = string.Empty;
    }
}
