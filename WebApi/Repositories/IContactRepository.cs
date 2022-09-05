using DevSkill.Data;
using WebApi.DbContexts;
using WebApi.Entities;

namespace WebApi.Repositories
{
    public interface IContactRepository : IRepository<Contact, int, ApplicationDbContext>
    {

    }
}
