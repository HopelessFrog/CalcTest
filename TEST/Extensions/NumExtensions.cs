using System.Collections.Generic;


namespace TEST.Extensions
{
    public static class NumExtensions
    {
        public static List<int> GetDigits(this int num)
        {
            var digits = new List<int>();

            while(num > 0)
            {
                digits.Add(num % 10);
                num /= 10;
            }

            digits.Reverse();

            return digits;
        }
    }
}
