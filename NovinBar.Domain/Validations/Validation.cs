using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Validations
{
    public class Validation
    {
        public static bool CheckPhoneNumberFormat(string Str)
        {
            if (Str.Length != 11 || !Str.StartsWith("09") || !CheckNumberFormat(Str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckNumberFormat(string Str)
        {
            bool result = long.TryParse(Str, out long a);
            return result;
        }
    }
}
