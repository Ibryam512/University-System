using UniSystem.Common;

namespace UniSystem.Models
{
    public class StudentBindingModel
    {
        private double averageGrade;

        public int Id { get; set; }
        public string FacultyNumber { get; set; }
        public string Class { get; set; }
        public string EGN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsMale { get; set; }
        public string MobileNumber { get; set; }
        public Dictionary<string, double> Grades { get; set; }

        public StudentBindingModel()
        {
            this.Grades = new Dictionary<string, double>();
        }
    }
}
