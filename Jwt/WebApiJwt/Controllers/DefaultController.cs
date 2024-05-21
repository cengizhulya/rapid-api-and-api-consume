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
        [HttpGet("[action]")]
        public IActionResult GetToken()
        {
            return Ok(new Token().CreateToken());
        }

        [HttpGet("[action]")]
        public IActionResult GetClaimToken()
        {
            return Ok(new Token().CreateClaimToken());
        }

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult test1()
        {
            return Ok("test");
        }

        [Authorize(Roles = "Admin,Visitor")]
        [HttpGet("[action]")]
        public IActionResult test2()
        {
            return Ok("Succeded to enter with the CLAIM TOKEN.");
        }
    }
}
