using Flunt.Notifications;

namespace PaymentContext.Shared.Etities
{
    public abstract class Entity : Notifiable
    {
        public Guid Id { get; private set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}