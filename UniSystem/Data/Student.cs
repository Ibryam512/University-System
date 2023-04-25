using UniSystem.Common;

namespace UniSystem.Data
{
    public class Student : BaseEntity
    {
        public string FacultyNumber { get; set; }
        public string EGN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string MobileNumber { get; set; }
        public double AverageGrade { get; set; }
    }
}
