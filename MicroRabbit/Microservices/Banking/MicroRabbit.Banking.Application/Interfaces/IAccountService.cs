using MicroRabbit.Banking.Domain.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();

        Task<IEnumerable<Account>> GetAccountsAsync();
    }
}
