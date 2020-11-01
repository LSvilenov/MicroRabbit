using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Banking.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public TransferCreatedEvent(int fromAccount, int toAccount, decimal amount)
        {
            this.FromAccount = fromAccount;
            this.ToAccount = toAccount;
            this.Amount = amount;
        }

        public int FromAccount { get; private set; }

        public int ToAccount { get; private set; }

        public decimal Amount { get; private set; }
    }
}
