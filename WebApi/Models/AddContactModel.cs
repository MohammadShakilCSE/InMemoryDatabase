using Autofac;
using AutoMapper;
using WebApi.Services;
using ContactBusness = WebApi.BusinessObjects.Contact;

namespace WebApi.Models
{
    public class AddContactModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public long Phone { get; set; }
        public List<string>? Address { get; set; }
        public List<int> AddressId { get; set; }
     

        private IContactService _contactService;
        private ILifetimeScope _scope;
        private IMapper _mapper;
        public AddContactModel()
        {
        
        }
        public AddContactModel(IMapper mapper, IContactService contactService)
        {
            _contactService=contactService;
            _mapper=mapper;
        }

        public void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _contactService = _scope.Resolve<IContactService>();
            _mapper = _scope.Resolve<IMapper>();
        }

        public void Create()
        {
           var contact= _mapper.Map<ContactBusness>(this);
            _contactService!.Create(contact);
        }

    }
}
