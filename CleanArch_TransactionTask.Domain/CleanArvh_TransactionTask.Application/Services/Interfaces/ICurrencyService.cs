using CleanArch_TransactionTask.Domain.DTOs;
using CleanArch_TransactionTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch_TransactionTask.Application.Services.Interfaces
{
    public interface ICurrencyService
    {
        List<Currency> GetAllCurrencies();
        public Currency CreateNewCurrency(CreateUserDTO currency);
    }
}
