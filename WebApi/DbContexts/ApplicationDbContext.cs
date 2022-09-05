using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<Addresses>? Addresses { get; set; }
    }
}
