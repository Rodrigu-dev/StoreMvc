using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Store.Infra.Data.Context
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Data Source = LAPTOP-PH1MG1OV\\SQLRBC;Initial Catalog=StoreDB;Integrated Security=True");
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
