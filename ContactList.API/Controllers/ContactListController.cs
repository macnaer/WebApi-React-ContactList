using ContactList.Data.Data.Classes;
using ContactList.Data.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactListController : ControllerBase
    {
        private readonly IContactListRepository _contactListRepository;

        public ContactListController(IContactListRepository contactListRepository)
        {
            _contactListRepository = contactListRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetContactList()
        {
            List<UserContactList> contactList = await _contactListRepository.GetContactListAsync();
            return Ok(contactList);
        }
    }
}
