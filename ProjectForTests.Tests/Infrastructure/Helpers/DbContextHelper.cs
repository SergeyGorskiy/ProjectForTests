using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ProjectForTests.EF;

namespace ProjectForTests.Tests.Infrastructure.Helpers
{
    public class DbContextHelper
    {
        public ApplicationContext Context { get; set; }

        public DbContextHelper()
        {
            var builder = new DbContextOptionsBuilder<ApplicationContext>();
            builder.UseInMemoryDatabase("UNIT_TESTING")
                .ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning));

            var options = builder.Options;
            Context = new ApplicationContext(options);

            Context.AddRange(CategoryHelper.GetMany());

            Context.SaveChanges();
        }
    }
}