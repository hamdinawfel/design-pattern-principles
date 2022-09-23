using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Texter : IMessageSender
    {
        public void SendEmail(IPerson person, string message)
        {
            Console.WriteLine($"Simulating other way to send message to {person.EmailAddress}");
        }
    }
}
