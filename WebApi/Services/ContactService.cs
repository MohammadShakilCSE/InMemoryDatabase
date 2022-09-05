using AutoMapper;
using WebApi.BusinessObjects;
using WebApi.UnitOfWorks;

using ContactEntity = WebApi.Entities.Contact;

namespace WebApi.Services
{
    public class ContactService : IContactService
    {
        private IContactUnitOfWork _contactUnitOfWork;
        private IMapper _mapper;

        public ContactService(IContactUnitOfWork contactUnitOfWork, IMapper mapper)
        {         
            _contactUnitOfWork = contactUnitOfWork;
            _mapper = mapper;
        }
        public void Create(Contact contact)
        {
            if (contact == null)
                throw new InvalidDataException();
            var entity = _mapper.Map<ContactEntity>(contact);
            _contactUnitOfWork!._contactRepository.Add(entity);
            _contactUnitOfWork.Save();
        }
    }
}
