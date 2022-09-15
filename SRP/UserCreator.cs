using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class UserCreator
    {
        public static Person Create()
        {
            Person user = new Person();

            StandardMessage.Guide("First Name");
            user.FirstName = Console.ReadLine();

            StandardMessage.Guide("Last Name");
            user.LastName = Console.ReadLine();

            return user;
        }
    }
}
