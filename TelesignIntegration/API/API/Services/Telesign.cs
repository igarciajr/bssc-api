using API.Interfaces;
using API.Models.Telesign;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TelesignIntegration.Models;

namespace API.Services
{
    public class Telesign: ITelesign
    {
        public async Task<SendCodeResponseDto> SendVerificationCode(string phoneNumber, VerificationMethod method) {
            TelesignIntegration.Verify verify = new TelesignIntegration.Verify();
            var res = await verify.SendVerificationCode(phoneNumber, (int)method);

            return new SendCodeResponseDto()
            {
                ReferenceId = res.Body.ReferenceId,
                OK = res.OK,
                StatusCode = res.StatusCode            
            };
        }

        public async Task<VerifyCodeResponseDto> VerifyCode(string referenceId, string code)
        {
            TelesignIntegration.Verify verify = new TelesignIntegration.Verify();
            var res = await verify.VerifyCode(referenceId, code);
            return new VerifyCodeResponseDto()
            {
                VerifyCodeState = (string?)res.Json.SelectToken("$.verify.code_state")
            };
        }
    }
}
