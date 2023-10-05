using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace API.Models.Telesign
{
    public class TelesignResponseDto
    {
        private Task<string>? BodyTask;

        public int StatusCode { get; set; }

        public HttpResponseHeaders? Headers { get; set; }

        public string? Body { get; set; }

        public JObject? Json { get; set; }

        public bool OK { get; set; }
    }
}
