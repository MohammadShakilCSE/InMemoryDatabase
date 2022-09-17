using DevSkill.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.DbContexts
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
          
        {
            modelBuilder.Entity<UserLogin>().HasNoKey();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<Addresses>? Addresses { get; set; }
     

    }
}
