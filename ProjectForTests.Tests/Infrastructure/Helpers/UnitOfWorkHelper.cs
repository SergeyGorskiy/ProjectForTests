using Arch.EntityFrameworkCore.UnitOfWork;
using Moq;
using ProjectForTests.EF;

namespace ProjectForTests.Tests.Infrastructure.Helpers
{
    public static class UnitOfWorkHelper
    {
        public static void
            //Mock<IUnitOfWork<ApplicationContext>> 
            GetMock()
        {
            var context = new DbContextHelper().Context;
            var unitOfWork = new Mock<ApplicationContext>();
        }
    }
}