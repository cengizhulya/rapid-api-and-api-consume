using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("action")]
        public IActionResult GetToken()
        {
            return Ok(new Token().CreateToken());
        }

        [HttpGet("action")]
        public IActionResult GetClaimToken()
        {
            return Ok(new Token().CreateClaimToken());
        }

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Test1()
        {
            return Ok("you're welcome");
        } 

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Test2()
        {
            return Ok("succeeded to enter with token");
        }
    }
}
