using CleanArch_TransactionTask.Application.Services.Interfaces;
using CleanArch_TransactionTask.Domain.DTOs;
using CleanArch_TransactionTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch_TransactionTask.Application.Services.Usage
{
    public class CurrencyService : ICurrencyService
    {
        public Currency CreateNewCurrency(CreateUserDTO currency)
        {
            throw new NotImplementedException();
        }

        public List<Currency> GetAllCurrencies()
        {
            throw new NotImplementedException();
        }
    }
}
