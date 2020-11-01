using MicroRabbit.Banking.Domain.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();

        Task<IEnumerable<Account>> GetAccountsAsync();
    }
}
