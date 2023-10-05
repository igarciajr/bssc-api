using API.Interfaces;
using API.Models.Telesign;

namespace API.Services
{
    public class Telesign: ITelesign
    {
        public TelesignResponseDto SendVerificationCode(string phoneNumber, VerificationMethod method) {
            TelesignIntegration.Verify verify = new TelesignIntegration.Verify();
            var x = verify.SendVerificationCode(phoneNumber, 0);
            return new TelesignResponseDto()
            {
                OK = x.OK,
                Body = x.Body,
                Headers = x.Headers,
                Json = x.Json,
                StatusCode = x.StatusCode
            };
        }
    }
}
