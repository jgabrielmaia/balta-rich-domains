using Flunt.Validations;
using Payment.Shared.ValueObjects;

namespace Payment.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string street, string number, string neighborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;

            AddNotifications(new Contract()
                            .Requires()
                            .HasMinLen(Street,3, "Address.Street", "Street must have at least 3 characters."));
        }

        public string Street { get; set; }

        public string Number { get; set; }

        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public string ZipCode { get; set; }
    }
}