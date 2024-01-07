
using Core.Entities;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.DependencyInjection;


namespace Infrastructure.Data
{
    public class StoreContext: DbContext
    {
    public  StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }
    }
}