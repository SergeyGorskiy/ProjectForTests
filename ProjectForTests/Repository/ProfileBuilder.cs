using ProjectForTests.Models;

namespace ProjectForTests.Repository
{
    public class ProfileBuilder
    {
        private readonly Person _person;

        public ProfileBuilder(Person person)
        {
            _person = person;
        }

        public Person GetPerson()
        {
            return _person;
        }
    }
}