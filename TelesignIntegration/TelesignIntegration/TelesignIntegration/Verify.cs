using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Telesign;
using TelesignEnterprise;
using TelesignIntegration.Models;

namespace TelesignIntegration
{
    public class Verify : Telesign
    {
        public async Task<TelesignResponse> SendVerificationCode(string phoneNumber, int method)
        {
            RestClient.TelesignResponse response = null;
            string template = "Your verification code is $$CODE$$.";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("template", template);

            VerifyClient verifyClient = new VerifyClient(_customerId, _apiKey);

            switch (method) {
                case 0: {
                    parameters.Add("phone_number", phoneNumber);
                    response = await verifyClient.PostAsync("/v1/verify/sms", parameters);
                    break;
                }
                case 1: {
                    parameters.Add("phone_number", phoneNumber);
                    response = await verifyClient.PostAsync("/v1/verify/call", parameters);
                    break;
                }
                default: {
                    response = verifyClient.Sms(phoneNumber, parameters);
                    break;
                }
            }

            return new TelesignResponse()
            {
                OK = response.OK,
                Body = JsonConvert.DeserializeObject<TelesignResponseBody>(response.Body),
                StatusCode = response.StatusCode,
                Headers = response.Headers,
                Json = response.Json
            };
        }

        public async Task<TelesignResponse> VerifyCode(string referenceId, string code)
        {
            RestClient.TelesignResponse response = null;
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("verify_code", code);

            VerifyClient verifyClient = new VerifyClient(_customerId, _apiKey);
            response = await verifyClient.GetAsync($"/v1/verify/{referenceId}", parameters);
             
            return new TelesignResponse()
            {
                OK = response.OK,
                Body = JsonConvert.DeserializeObject<TelesignResponseBody>(response.Body),
                StatusCode = response.StatusCode,
                Headers = response.Headers,
                Json = response.Json
            };
        }
    }
}
