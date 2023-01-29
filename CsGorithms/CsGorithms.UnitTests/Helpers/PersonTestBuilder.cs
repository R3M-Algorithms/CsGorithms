using Bogus;
using System.Collections.Generic;

namespace CsGorithms.UnitTests.Helpers
{
    public class PersonTestBuilder
    {
        private readonly int count;
        private readonly Faker<PersonTest> faker;

        public PersonTestBuilder(int count)
        {
            this.count = count;
            faker = new Faker<PersonTest>();
        }

        public PersonTestBuilder WithRandomNames()
        {
            faker.RuleFor(c => c.Name, f => f.Person.FullName);
            return this;
        }

        public PersonTestBuilder WithRandomAges()
        {
            faker.RuleFor(c => c.Age, f => f.Random.Int(1, 120));
            return this;
        }

        public PersonTestBuilder WithSameAges(int age)
        {
            faker.RuleFor(c => c.Age, f => age);
            return this;
        }

        public IEnumerable<PersonTest> Build()
        {
            return faker.GenerateLazy(count);
        }

    }
}
