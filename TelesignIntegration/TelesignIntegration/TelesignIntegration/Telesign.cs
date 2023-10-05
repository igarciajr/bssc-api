using System;

namespace TelesignIntegration
{
    public class Telesign
    {
        public static string _customerId = "E6457A41-9A57-4340-8C27-AB5428F29068";
        public static string _apiKey = "bI8t/Q36QJmI1QMPnGwD01CX+6tinPR3hQOR0V/zpusk/bCVdbJUhxWFr5mhQbB2WLV9L7Ht8EPa35Sw9M6lhw==";

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
