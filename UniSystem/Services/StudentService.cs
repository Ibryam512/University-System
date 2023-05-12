using UniSystem.Common;
using UniSystem.Data;
using UniSystem.Data.Entities;
using UniSystem.Models;

namespace UniSystem.Services
{
    class StudentService
    {
        private readonly UniSystemDbContext context;

        public StudentService(UniSystemDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<Student> GetStudents() => this.context.Students.ToList();

        public List<Student> GetStudents(Func<Student, bool> predicate) => this.context.Students.Where(predicate);

        public Student GetStudent(Func<Student, bool> predicate) => this.context.Students.SingleOrDefault(predicate);

        public void AddStudent(StudentBindingModel studentBindingModel)
        {
            var student = new Student
            {
                FacultyNumber = studentBindingModel.FacultyNumber,
                EGN = studentBindingModel.EGN,
                FirstName = studentBindingModel.FirstName,
                LastName = studentBindingModel.LastName,
                Gender = studentBindingModel.IsMale ? Gender.Male : Gender.Female,
                MobileNumber = studentBindingModel.MobileNumber,
                AverageGrade = studentBindingModel.Grades.Average(x => x.Value)
            };

            this.context.Students.Add(student);

            Program.GradeService.AddGrades(student.Id, studentBindingModel.Grades);
            Program.AuthService.AddStudentAccount(student);
        }
    }
}
