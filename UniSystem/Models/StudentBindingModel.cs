using UniSystem.Common;

namespace UniSystem.Models
{
    public class StudentBindingModel
    {
        public string FacultyNumber { get; set; }
        public string EGN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string MobileNumber { get; set; }
        public Dictionary<string, int> Grades { get; set; }
    }
}
