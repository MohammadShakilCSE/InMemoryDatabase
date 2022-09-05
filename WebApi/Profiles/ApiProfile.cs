using AutoMapper;
using WebApi.BusinessObjects;
using EntityContact = WebApi.Entities.Contact;
namespace WebApi.Profiles
{
    public class ApiProfile:Profile
    {
        public ApiProfile()
        {
            CreateMap<Contact, EntityContact>().ReverseMap();
        }
    }
}
