using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Prak
{
    internal static class Logic
    {
        public static bool CheckIfString(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            foreach (char c in str)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool CheckIfNumeric(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            foreach (char c in str)
            {
                if (!char.IsNumber(c))
                    return false;
            }

            return true;
        }
    }
}
