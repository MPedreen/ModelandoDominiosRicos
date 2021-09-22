using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            //Validações:
            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve conter pelomenos 3 caracteres")
            .HasMinLen(LastName, 3, "Name.FirstName", "Nome deve conter pelomenos 3 caracteres")
            .HasMaxLen(FirstName, 40, "Name.FirstName", "Nome deve conter até 40 caracteres")
            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}