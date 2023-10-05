using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace TelesignIntegration.Models
{
    public class TelesignResponse
    {
        private Task<string> BodyTask;

        public int StatusCode { get; set; }

        public HttpResponseHeaders Headers { get; set; }

        public TelesignResponseBody Body { get; set; }

        public JObject Json { get; set; }

        public bool OK { get; set; }
    }
}
