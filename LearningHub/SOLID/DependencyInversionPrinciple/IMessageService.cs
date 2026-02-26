using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.SOLID.DependencyInversionPrinciple
{
    public interface IMessageService
    {
        void SendMessage(string message);
    }
}
