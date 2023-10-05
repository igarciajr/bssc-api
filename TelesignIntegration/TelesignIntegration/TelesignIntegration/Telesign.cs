using System;
using System.Collections.Generic;
using Telesign;
using TelesignEnterprise;

namespace TelesignIntegration
{
    public class Telesign
    {
        public static string _customerId = "-";
        public static string _apiKey = "-";

        public int generateCode(int min, int max)
        {
            if (min > max)
            {
                throw new Exception("Start cannot exceed End.");
            }
            
            Random random = new Random();
            int randomNumber = random.Next((max - min) + 1) + min;
            return randomNumber;
        }
    }
}
