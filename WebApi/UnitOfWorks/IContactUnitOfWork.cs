using DevSkill.Data;
using WebApi.Repositories;

namespace WebApi.UnitOfWorks
{
    public interface IContactUnitOfWork:IUnitOfWork
    {
       public IContactRepository _contactRepository { get; set; }
    }
}
