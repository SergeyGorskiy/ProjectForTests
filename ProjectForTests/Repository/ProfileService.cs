using ProjectForTests.Models;

namespace ProjectForTests.Repository
{
    public class ProfileService
    {
        private readonly ProfileBuilder _profileBuilder;

        public ProfileService(ProfileBuilder profileBuilder)
        {
            _profileBuilder = profileBuilder;
        }

        public Person GetPersonFromBuilder()
        {
            return _profileBuilder.GetPerson();
        }
    }
}