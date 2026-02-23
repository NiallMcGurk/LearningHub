using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.SOLID.GoodExample
{
    public class EmailService
    {
        public void SendEmail(Student student, string body)
        {
            Console.WriteLine("Email sent to " + student.Email + " with body: \n" + body);
        }
    }
}
