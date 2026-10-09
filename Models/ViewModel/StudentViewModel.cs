namespace ContosoUniversity.Models.ViewModel
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        public string LastName { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public DateTime EnrollmentDate { get; set; }
    }
}
