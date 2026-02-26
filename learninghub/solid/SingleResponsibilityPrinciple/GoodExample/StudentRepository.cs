using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.SOLID.GoodExample
{
    public class StudentRepository
    {
        // SRP = Saving Student to DB 
        public void Save(Student student)
        {
           Console.WriteLine(student.FirstName + " " + student.LastName + " has been saved to the database.");
        }
    }
}
