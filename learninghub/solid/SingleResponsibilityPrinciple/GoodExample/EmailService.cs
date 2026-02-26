using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.SOLID.GoodExample
{
    public class EmailService
    {
        // SRP = Sending Email to Student
        public void SendEmail(Student student)
        {
            Console.WriteLine("Email sent to " + student.Email + " with body: \n" + student.FirstName + ", " + "You have been enrolled in Math 101");
        }
    }
}
