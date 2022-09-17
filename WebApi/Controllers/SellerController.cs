using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.DbContexts;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController, Authorize]
    [Route("Api/contact")]
    public class SellerController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public SellerController(ApplicationDbContext applicationDbContext)
        { 
                _applicationDbContext = applicationDbContext;
        }
        [HttpGet]
        public IActionResult GetAllContacts()
        {
            var list =_applicationDbContext.Contacts!.Include(x => x.Addresses).ToArray();
            var response = list.Select(x => new
            {
                Neme = x.Name,
                Adress = x.Addresses!.Select(a => a.Address).ToArray()
            }); 
            return Ok(response);
        }
        [HttpPost]
        public IActionResult AddContact(AddContactModel addContact)
        {
            var contect = new Contact()
            {
                Id=addContact.Id,
                Name=addContact.Name,
                Email=addContact.Email,
                phone=addContact.Phone,
            };
            contect.Addresses = new List<Addresses>();
            for (int i = 0; i < addContact.AddressId.Count(); i++)
            {
                contect.Addresses.Add(new Addresses { 
                    Id = addContact.AddressId[i], Address = addContact.Address[i] ,
                    ContactId=addContact.Id
                });
            }
            _applicationDbContext.Contacts!.Add(contect);
            _applicationDbContext.SaveChanges();
            return Ok(contect);
        }

        [HttpGet]
        [Route("{Id:int}")]
        public IActionResult GetById([FromRoute] int Id)
        {
            var findContext = _applicationDbContext.Contacts!
                .Where(x => x.Id==Id).Include(y=>y.Addresses).ToArray();
            
            if (findContext == null)
            {
                return NotFound();
            }
            return Ok(findContext);
        }
        
    }
}
