namespace API.Models.Telesign
{
    public class SendCodeResponseDto
    {
        public string? ReferenceId { get; set; }
        public int StatusCode { get; set; }
        public bool OK { get; set; }
    }
}
