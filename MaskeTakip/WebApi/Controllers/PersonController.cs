using Business.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet("getPersons")]
        public IActionResult GetPersons()
        {
            PersonManager personManager = new PersonManager();
            s
            return Ok(persons);
        }
    }
}
