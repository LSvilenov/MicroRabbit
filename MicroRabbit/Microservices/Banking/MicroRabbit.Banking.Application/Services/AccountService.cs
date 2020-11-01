using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;

        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            this._accountRepository = accountRepository;
            this._bus = bus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public async Task<IEnumerable<Account>> GetAccountsAsync()
        {
            return await _accountRepository.GetAccountsAsync();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand =
                new CreateTransferCommand(accountTransfer.FromAccount, accountTransfer.ToAccount, accountTransfer.Amount);

            _bus.SendCommand(createTransferCommand);
        }

        public async Task TransferAsync(AccountTransfer accountTransfer)
        {
            var createTransferCommand =
                new CreateTransferCommand(accountTransfer.FromAccount, accountTransfer.ToAccount, accountTransfer.Amount);

            await _bus.SendCommand(createTransferCommand);
        }
    }
}
