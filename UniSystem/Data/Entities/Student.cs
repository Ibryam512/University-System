using UniSystem.Common;

namespace UniSystem.Data.Entities
{
    public class Student : BaseEntity
    {
        public string FacultyNumber { get; set; }
        public string EGN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Class { get; set; }
        public Gender Gender { get; set; }
        public string MobileNumber { get; set; }
        public double AverageGrade { get; set; }

        public string FullName() => $"{FirstName} {LastName}"; 
    }
}
