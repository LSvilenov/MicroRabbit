using System.Collections.Generic;
using System.Threading.Tasks;

using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Models;

using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("api/accounts")]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountsController(IAccountService accountService)
        {
            this._accountService = accountService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetAsync()
        {
            var result = await _accountService.GetAccountsAsync();

            return Ok(result);
        }
    }
}
