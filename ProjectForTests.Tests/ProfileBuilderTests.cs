using ProjectForTests.Models;
using ProjectForTests.Repository;
using Xunit;

namespace ProjectForTests.Tests
{
    public class ProfileBuilderTests
    {
        [Fact]
        public void ItShouldBeUnderTesting()
        {
            // Arrange
            var person = new Person();
            var sut = new ProfileBuilder(person);
            
            // Act

            //Assert
            Assert.NotNull(sut);
        }

        [Fact]
        public void ItShouldReturnPersonObject()
        {
            // Arrange
            var expected = new Person();
            var sut = new ProfileBuilder(expected);

            // Act
            var actual = sut.GetPerson();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}