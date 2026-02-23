using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.SOLID.GoodExample
{
    public class EnrollmentService
    {
        public void Enroll(Student student, string course)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName + " has been enrolled in " + course);
        }
    }
}
