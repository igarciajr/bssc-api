using API.Models.Telesign;
using CSSB.Common;

namespace API.Interfaces
{
    public interface ITelesign
    {
        public TelesignResponseDto SendVerificationCode(string phoneNumber, VerificationMethod method);
    }
}
