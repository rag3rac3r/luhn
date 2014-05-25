using System;
using System.Text.RegularExpressions;

namespace Luhn
{
    public class Luhn
    {
        public static bool LuhnVal(string verify)
        {
            string val = Clean(Reverse(verify.Substring(0, verify.Length-1)));
            int sum = 0;

            for (int i = 0; i < val.Length; i++)
            {
                int tmp = Convert.ToInt32(val.Substring(i, 1)) * (2 - (i & 1));
                if (tmp > 9) tmp -= 9;
                sum += tmp;
            }

            sum = (10 - (sum % 10) % 10);
            if (sum == 10)
                sum = 0;

            return (verify.Substring(verify.Length - 1, 1) == sum.ToString());

        }

        public static string LuhnGen(string generate)
        {
            string val = Clean(Reverse(generate));
            int sum = 0;

            for (int i = 0; i < val.Length; i++)
            {
                int tmp = Convert.ToInt32(val.Substring(i,1)) * (2 - (i & 1));
                if (tmp > 9)
                {
                    tmp -= 9;
                }
                sum += tmp;
            }

            sum = (10 - (sum % 10) % 10);
            if (sum == 10)
            {
                sum = 0;
            }
            return sum.ToString();
        }

        #region Utils
        public static string Clean(string dirty)
        {
            if (dirty == null)
                return null;

            Regex vaccine = new Regex("\\D");
            string clean = vaccine.Replace(dirty, "");
            return clean;
        }

        public static string Reverse(string text)
        {
            if (text == null)
                return null;

            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
        #endregion
    }
}
