using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public static class PeoplePrinter
    {
        public static void Print ()
        {
            IEnumerable<string> GetPeople()
                => new[] {"Tim", "Josh", "Chris"};

            IEnumerable<string> FilterPeople(IEnumerable<string> people)
                => people.Where(x => x.Length <= 4);

            void PrintPeople(IEnumerable<string> people)
            {
                people.ToList().ForEach(PrintPerson);
            }

            void PrintPerson(string s1) => Console.WriteLine(s1);

            PrintPeople(FilterPeople(GetPeople()));
            PrintPeople(new[] {"Khalid", "Maarten", "Matt"});
        }
    }
}
