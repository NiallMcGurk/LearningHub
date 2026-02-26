using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.SOLID.DependencyInversionPrinciple
{
    public class SMSService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Message: " + message + " - send via SMS.");
        }
    }
}
