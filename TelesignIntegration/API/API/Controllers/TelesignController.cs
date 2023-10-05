using System.Data;
using API.Interfaces;
using API.Models.Telesign;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace API.Controllers
{
    [Route("api/telesign")]
    public class TelesignController : Controller
    {
        private readonly ITelesign _telesignService;
        private readonly IConfiguration _configuration;

        public TelesignController(ITelesign telesignService, IConfiguration configuration)
        {
            _telesignService = telesignService;
            _configuration = configuration;
        }

        [HttpPost("sendSmsVerificationCode/{phoneNumber}")]
        public ActionResult<TelesignResponseDto> SendVerificationcode(string phoneNumber)
        {
            return _telesignService.SendVerificationCode(phoneNumber, VerificationMethod.Sms);
        }
    }
}
