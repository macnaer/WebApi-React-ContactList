using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactListController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetContactList()
        {

            return Ok();
        }
    }
}
