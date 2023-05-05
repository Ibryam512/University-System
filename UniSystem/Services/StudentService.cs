using UniSystem.Common;
using UniSystem.Data;
using UniSystem.Data.Entities;
using UniSystem.Models;

namespace UniSystem.Services
{
    class StudentService
    {
        private readonly UniSystemDbContext _context;

        public StudentService(UniSystemDbContext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<Student> GetStudents() => this._context.Students.ToList();

        public List<Student> GetStudents(Func<Student, bool> predicate) => this._context.Students.Where(predicate);

        public Student GetStudent(Func<Student, bool> predicate) => this._context.Students.SingleOrDefault(predicate);

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

            this._context.Students.Add(student);

            Program.GradeService.AddGrades(student.Id, studentBindingModel.Grades);
        }
    }
}
