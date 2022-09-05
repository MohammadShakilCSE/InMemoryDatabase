using DevSkill.Data;
using WebApi.Entities;
using WebApi.DbContexts;

namespace WebApi.Repositories
{
    public class ContactRepository : Repository<Contact, int, ApplicationDbContext>,IContactRepository
    {
        public ContactRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
