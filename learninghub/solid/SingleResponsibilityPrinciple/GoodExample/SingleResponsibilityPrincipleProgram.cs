namespace LearningHub.SOLID.GoodExample
{
    internal class SingleResponsibilityPrincipleProgram
    {
        public SingleResponsibilityPrincipleProgram()
        {
            Student student = new Student
            {
                StudentId = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "helloWorld@gmail.com"
            };

            StudentRepository studentRepository = new StudentRepository();
            studentRepository.Save(student);

            EnrollmentService enrollment = new EnrollmentService();
            enrollment.Enroll(student, "Math 101");

            EmailService email = new EmailService();
            email.SendEmail(student, "You have been enrolled in Math 101");
        }
    }
}
