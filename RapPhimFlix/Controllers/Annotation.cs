using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapPhimFlix.Controllers
{
    public class Annotation
    {
        // Annotation
        public static bool TelephoneNumber (string phoneNumber)
        {
            if (phoneNumber == null) return false;
            if (phoneNumber.Length == 0) return false;
            if (phoneNumber.Length != 10) return false;
            if (phoneNumber[0] != '0') return false;
            if (phoneNumber.Length >= 2)
            {
                switch (phoneNumber[1])
                {
                    case '0': return false;
                    case '1': return false;
                    case '4': return false;
                    case '6': return false;
                    case '7': return false;
                }
            }
            for (int i = 0; i < phoneNumber.Length; i++)
                if (!char.IsDigit(phoneNumber[i])) return false;
            return true;
        }
    }
}  
