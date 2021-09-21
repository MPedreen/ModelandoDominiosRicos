using System;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        //uma entidade vai ter um ID e um Value Object não
        public Guid Id { get; private set; }
    }
}