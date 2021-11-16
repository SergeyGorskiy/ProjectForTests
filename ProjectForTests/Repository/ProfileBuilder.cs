using System.Collections.Generic;
using System.Linq;
using ProjectForTests.Models;

namespace ProjectForTests.Repository
{
    public class ProfileBuilder : IProfileBuilder
    {
        private readonly Person _person;
        private readonly List<Person> _people;

        public ProfileBuilder(Person person)
        {
            _person = person;
            _people = People.GetPeople();
        }

        public Person GetPerson()
        {
            return _person;
        }

        public Person GetPersonById(int id)
        {
            return _people.SingleOrDefault(x => x.Id == id);
        }
    }

    public interface IProfileBuilder
    {
        Person GetPerson();

        Person GetPersonById(int id);
    }
}