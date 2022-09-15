using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class UserValidator
    {
        public static bool Validate(Person user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                StandardMessage.ShowErrorMessage("First Name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                StandardMessage.ShowErrorMessage("Last Name");
                return false;
            }

            return true;
        }
    }
}
