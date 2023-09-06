using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCheack
{
    public class Cheack
    {
        int dot = 0;
        public string capital(string pas)
        {
            bool hasUpperCase = pas.Any(char.IsUpper);
            if (hasUpperCase)
            {
                Convert.ToInt16(dot++);
            }
            return Convert.ToString(dot);
        }
        public string uppercase(string pas)
        {
            bool hasUpperCase = pas.Any(char.IsLower);
            if (hasUpperCase)
            {
                Convert.ToInt16(dot++);
            }
            return Convert.ToString(dot);
        }
        public string number(string pas)
        {
            bool hasUpperCase = pas.Any(char.IsDigit);
            if (hasUpperCase)
            {
                Convert.ToInt16(dot++);
            }
            return Convert.ToString(dot);
        }
        public string token(string pas)
        {
            bool hasUpperCase = pas.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c));
            if (hasUpperCase)
            {
                Convert.ToInt16(dot++);

            }
            return Convert.ToString(dot);
        }
        public string lingth(string pas)
        {
            int leng = pas.Length;
            if (leng > 7)
            {
                Convert.ToInt16(dot++);

            }
            return Convert.ToString(dot);
        }
    }
}
