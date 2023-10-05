using API.Models.Telesign;

namespace API.Interfaces
{
    public interface ITelesign
    {
        public Task<SendCodeResponseDto> SendVerificationCode(string phoneNumber, VerificationMethod method);
        public Task<VerifyCodeResponseDto> VerifyCode(string referenceId, string code);
    }
}
