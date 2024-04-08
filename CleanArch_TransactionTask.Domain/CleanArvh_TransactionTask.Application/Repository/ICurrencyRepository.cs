using CleanArch_TransactionTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch_TransactionTask.Application.Repository
{
    public interface ICurrencyRepository
    {
        List<Currency> GetAllCurrencies();
        public Currency CreateNewCurrency();
    }
}
