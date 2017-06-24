using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeStatusDetection
{
    class Status
    {
    
        public bool GetStatus()
        {
            int number = GenerateNumber();
            return PrimeNumber(number);
        }
        private int GenerateNumber()
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] randomNumber = new byte[4];
                rng.GetBytes(randomNumber);
                int value = BitConverter.ToInt32(randomNumber, 0);

                return value;
            }
        }

        private bool PrimeNumber(int number)
        {
            int k = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    k++;
                }
            }
            if (k == 2)
            {
                return true;
            }
            return false;
        }
    }
}
