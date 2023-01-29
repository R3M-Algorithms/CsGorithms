using System;

namespace CsGorithms.UnitTests.Helpers
{
    public class PersonTestComparable : IComparable<PersonTestComparable>
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public int CompareTo(PersonTestComparable? other)
        {
            return Age.CompareTo(other?.Age);
        }
    }
}
