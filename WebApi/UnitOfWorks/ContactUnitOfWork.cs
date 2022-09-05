using DevSkill.Data;
using Microsoft.EntityFrameworkCore;
using WebApi.DbContexts;
using WebApi.Repositories;

namespace WebApi.UnitOfWorks
{
    public class ContactUnitOfWork : UnitOfWork, IContactUnitOfWork
    {
        public IContactRepository _contactRepository { get; set; }
        public ContactUnitOfWork(ApplicationDbContext dbContext,IContactRepository contactRepository) 
            : base(dbContext)
        {
            _contactRepository = contactRepository;
        }
    }
}
