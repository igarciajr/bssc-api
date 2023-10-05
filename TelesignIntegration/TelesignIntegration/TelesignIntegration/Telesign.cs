using System;

namespace TelesignIntegration
{
    public class Telesign
    {
        public static string _customerId = "xxxxxxxxxxxxx";
        public static string _apiKey = "xxxxxxxxxxxxxxxxxxxxxx";

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
