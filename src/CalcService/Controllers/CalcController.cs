using Microsoft.AspNetCore.Mvc;

namespace CalcService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalcController : Controller
    {
        [HttpGet]
        [Route("{a}/{b}")]
        public IActionResult Add(int a, int b)
        {
            return Ok( a + b );
        }        
    }
}