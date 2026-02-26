using LearningHub.SOLID.GoodExample;

namespace LearningHub.SOLID.SingleResponsibilityPrinciple.GoodExample
{
    // Seperation of Concerns
    public class StudentApplicationService
    {
        private readonly StudentRepository _studentRepository;
        private readonly EnrollmentService _enrollmentService;
        private readonly EmailStudentService _emailService;
        public StudentApplicationService(
            StudentRepository studentRepository,
            EnrollmentService enrollmentService,
            EmailStudentService emailService)
        {
            _studentRepository = studentRepository;
            _enrollmentService = enrollmentService;
            _emailService = emailService;
        }

        // SRP = Coordinating the workflow. (Three things happening, 1 responsibility)
        public void RegisterStudent(Student student)
        {
            _studentRepository.Save(student);
            _enrollmentService.Enroll(student);
            _emailService.SendEmail(student);
        }
    }
}
