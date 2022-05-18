using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]

        public IEnumerable<string> Get()
        {
            return new string[] { "car", "bus", "Aeroplane", "bike" };
        }

        [HttpGet("{id}")]

        public string Get(int id)
        {
            return "The value is" + id;
        }
    }
}
