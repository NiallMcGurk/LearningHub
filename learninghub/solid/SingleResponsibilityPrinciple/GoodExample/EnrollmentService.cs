using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.SOLID.GoodExample
{
    public class EnrollmentService
    {
        // SRP = Enrolling Student in Course
        public void Enroll(Student student)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName + " Math 101.");
        }
    }
}
