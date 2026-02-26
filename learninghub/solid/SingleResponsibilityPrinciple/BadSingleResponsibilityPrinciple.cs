// Single Responsibility Principle (SRP).

// Bad example
public class BadSingleResponsibilityPrinciple
{
    public int StrudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public void Save()
    {
        // Code to save student to database
    }
    public void EmailService()
    {
        // Code to send email to student
    }
    public void Enroll()
    {
        // Code to enroll student in course
    }
}