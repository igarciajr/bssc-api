using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telesign;
using TelesignEnterprise;
using TelesignIntegration.Models;

namespace TelesignIntegration
{
    public class Verify : Telesign
    {
        public TelesignResponse SendVerificationCode(string phoneNumber, int method)
        {
            RestClient.TelesignResponse telesignResponse = null;
            int min = 100000;
            int max = 999999;
            int verifyCode = generateCode(min, max);

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("verify_code", verifyCode.ToString());

            VerifyClient verifyClient = new VerifyClient(_customerId, _apiKey);

            switch (method) {
                case 0: {
                    telesignResponse = verifyClient.Sms(phoneNumber, parameters);
                    break;
                }
                case 1: {
                    telesignResponse = verifyClient.Voice(phoneNumber, parameters);
                    break;
                }
                default: {
                    telesignResponse = verifyClient.Sms(phoneNumber, parameters);
                    break;
                }
            }

            return new TelesignResponse()
            {
                OK = telesignResponse.OK,
                Body = telesignResponse.Body,
                StatusCode = telesignResponse.StatusCode,
                Headers = telesignResponse.Headers,
                Json = telesignResponse.Json
            };
        }
    }
}
