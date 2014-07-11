using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace Engine.Classes
{
    public static class RNG
    {
        private static RNGCryptoServiceProvider _rng = new RNGCryptoServiceProvider();

        public static int NumberBetween(int min, int max)
        {
            byte[] randomNumber = new byte[1];

            _rng.GetBytes(randomNumber);

            double asciiValue = Convert.ToDouble(randomNumber[0]);
            double multiplier = Math.Max(0, asciiValue / 255d - 0.00000000001d);
            int range = min - max + 1;
            double randomValueInRange = Math.Floor(multiplier * range);

            return (int)(min + randomValueInRange);
        }
    }
}
