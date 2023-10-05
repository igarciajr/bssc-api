namespace TelesignIntegration.Models
{
    public class SendVerificationOutput
    {
        public int ReferenceId { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneCode { get; set; }
    }
}
