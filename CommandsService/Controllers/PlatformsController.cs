using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers 
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase 
    {
        public PlatformsController()
        {
            
        }   

        [HttpPost]        
        public ActionResult TestInboubdConnection() 
        {
            Console.WriteLine("--> Inboud POST # Command Service");
            return Ok("Inbound Test of Platforms Conrollers");
        }
    }
}