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

        [HttpPost("sms/{phoneNumber}")]
        public async Task<ActionResult<SendCodeResponseDto>> SendVerificationCodeViaSms(string phoneNumber)
        {
            return await _telesignService.SendVerificationCode(phoneNumber, VerificationMethod.Sms);
        }

        [HttpPost("call/{phoneNumber}")]
        public async Task<ActionResult<SendCodeResponseDto>> SendVerificationCodeViaCall(string phoneNumber)
        {
            return await _telesignService.SendVerificationCode(phoneNumber, VerificationMethod.Voice);
        }

        [HttpGet("verify/{referenceId}/{code}")]
        public async Task<ActionResult<VerifyCodeResponseDto>> VerifyCode(string referenceId, string code)
        {
            return await _telesignService.VerifyCode(referenceId, code);
        }
    }
}
