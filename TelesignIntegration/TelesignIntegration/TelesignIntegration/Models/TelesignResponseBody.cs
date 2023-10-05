using Newtonsoft.Json;

namespace TelesignIntegration.Models
{
    public class TelesignResponseBody
    {
        [JsonProperty(PropertyName = "reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty(PropertyName = "sub_resource")]
        public string SubResource { get; set; }
    }
}
