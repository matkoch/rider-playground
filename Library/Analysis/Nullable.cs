#nullable enable
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Library.Analysis
{
    public class Person
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

    public interface IPersonRepository
    {
        Person? GetPerson(string lastName);
    }
    public class PersonRepository : IPersonRepository
    {
        private readonly List<Person> _people = new List<Person>();
        public Person? GetPerson(string lastName)
        {
            // CS8603: Possible null reference return.
            //return _people.SingleOrDefault(x => x.LastName == lastName);
            return null;
        }
    }

    public class App
    {
        private readonly IPersonRepository _repository;

        public void M()
        {
            var person = _repository.GetPerson("Mads");
            if (IsValid(person))
            {
                // CS8602: Dereference of a possibly null reference.
                Console.WriteLine($"Great job {person!.FirstName}!");
            }
        }

        private bool IsValid(Person? person)
        {
            return !string.IsNullOrEmpty(person?.FirstName) &&
                   !string.IsNullOrEmpty(person?.LastName);
        }
    }
}
