using LearningHub.SOLID.GoodExample;

namespace LearningHub.SOLID.SingleResponsibilityPrinciple.GoodExample
{
    public class RegisterStudent
    {
        public RegisterStudent()
        {
            // SRP = Register student
            // (Note that multiple things are happening - but its ONE RESPONSIBILITY);
            Student student = new Student
            {
                StudentId = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "helloWorld@gmail.com"
            };

            StudentApplicationService studentApplicationService = new StudentApplicationService(
                new StudentRepository(),
                new EnrollmentService(),
                new EmailStudentService()
                );

            // Look inside Register Student for best example of SRP.
            studentApplicationService.RegisterStudent(student);
        }
    }
}
