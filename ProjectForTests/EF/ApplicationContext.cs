using Microsoft.EntityFrameworkCore;
using ProjectForTests.Repository;

namespace ProjectForTests.EF
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Category> Categories;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        {
            throw new System.NotImplementedException();
        }
    }
}