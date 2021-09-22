using System;
using Flunt.Notifications;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity : Notifiable
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        //uma entidade vai ter um ID e um Value Object não
        public Guid Id { get; private set; }
    }
}