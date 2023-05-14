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
        public double AverageGrade 
        { 
            get 
            {
                if (Grades.Count > 0 && this.averageGrade == 0)
                {
                    return Grades.Average(x => x.Value);
                }
                else if (Grades.Count > 0 && this.averageGrade > 0)
                {
                    return (this.averageGrade + Grades.Average(x => x.Value)) / 2;
                }
                else
                {
                    return this.averageGrade;
                }
            }
            set
            {
                this.averageGrade = value;
            }
        }
        public Dictionary<string, double> Grades { get; set; }

        public StudentBindingModel()
        {
            this.Grades = new Dictionary<string, double>();
        }
    }
}
