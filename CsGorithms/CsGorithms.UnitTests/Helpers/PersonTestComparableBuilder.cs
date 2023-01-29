using Bogus;
using System.Collections.Generic;

namespace CsGorithms.UnitTests.Helpers
{
    public class PersonTestComparableBuilder
    {
        private readonly int count;
        private readonly Faker<PersonTestComparable> faker;

        public PersonTestComparableBuilder(int count)
        {
            this.count = count;
            faker = new Faker<PersonTestComparable>();
        }

        public PersonTestComparableBuilder WithRandomNames()
        {
            faker.RuleFor(c => c.Name, f => f.Person.FullName);
            return this;
        }

        public PersonTestComparableBuilder WithRandomAges()
        {
            faker.RuleFor(c => c.Age, f => f.Random.Int(1, 120));
            return this;
        }

        public PersonTestComparableBuilder WithSameAges(int age)
        {
            faker.RuleFor(c => c.Age, f => age);
            return this;
        }

        public IEnumerable<PersonTestComparable> Build()
        {
            return faker.GenerateLazy(count);
        }

    }
}
