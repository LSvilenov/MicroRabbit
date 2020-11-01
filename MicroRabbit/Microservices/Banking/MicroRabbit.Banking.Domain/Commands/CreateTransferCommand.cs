namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(int fromAccount, int toAccount, decimal amount)
        {
            base.FromAccount = fromAccount;
            base.ToAccount = toAccount;
            base.Amount = amount;
        }
    }
}
