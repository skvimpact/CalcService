using Microsoft.AspNetCore.Mvc;

namespace CalcService.Controllers
{
    [Route("/calc")]
    public class CalcController : Controller
    {
        [HttpGet]
        public IActionResult Magnify()
        {
            int a = 8;
            return Ok(a * 5);
        }        
    }
}