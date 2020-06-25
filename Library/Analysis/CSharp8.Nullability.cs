using System;
using System.Collections.Generic;
using System.Linq;

#nullable enable

namespace Library.Analysis
{
    public partial class CSharp8
    {
        class Person
        {
            public string FirstName { get; }
            public string MiddleName { get; }
            public string LastName { get; }

            public Person(string firstName, string? middleName, string lastName)
            {
                FirstName = firstName;
                // CS8601: Possible null reference assignment.
                MiddleName = middleName;
                LastName = lastName;
            }
        }

        void M(Person? person)
        {
            if (IsValid(person))
            {
                // CS8602: Dereference of a possibly null reference.
                Console.WriteLine($"Great job {person.FirstName}!");
            }
        }

        private bool IsValid(Person? person)
        {
            return !string.IsNullOrEmpty(person?.FirstName) &&
                   !string.IsNullOrEmpty(person?.LastName);
        }

        interface IPersonRepository
        {
            Person GetPerson(string lastName);
        }

        class PersonRepository : IPersonRepository
        {
            private readonly List<Person> _people;

            public PersonRepository(List<Person> people)
            {
                _people = people;
            }

            public Person GetPerson(string lastName)
            {
                // CS8603: Possible null reference return.
                return _people.SingleOrDefault(x => x.LastName == lastName);
            }
        }
    }
}
