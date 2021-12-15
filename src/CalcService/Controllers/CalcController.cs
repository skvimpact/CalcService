using Microsoft.AspNetCore.Mvc;

namespace CalcService.Controllers
{
    [Route( template: "[controller]")]
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