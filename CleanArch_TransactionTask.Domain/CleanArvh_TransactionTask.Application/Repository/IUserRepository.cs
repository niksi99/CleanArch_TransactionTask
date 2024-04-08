using CleanArch_TransactionTask.Domain.DTOs;
using CleanArch_TransactionTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch_TransactionTask.Application.Repository
{
    public interface IUserRepository
    {
        public User CreateNewUser(CreateUserDTO user);
        public List<User> GetAllUsers();
    }
}
