namespace WebApplication1.Interfaces
{
    public interface ITelesign
    {
        Task<TelesignVerificationOutput> SendSms(string phonenumber);
        Task SendVoice(string phonenumber);
        Task VerifySmsCode(string phonenumber);
        Task SendSMS(string phonenumber);
        Task verifyPhoneNumber(long phonenumber);
    }
}
