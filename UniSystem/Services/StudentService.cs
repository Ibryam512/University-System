using UniSystem.Common;
using UniSystem.Controls.Students;
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
                Class = studentBindingModel.Class,
                EGN = studentBindingModel.EGN,
                FirstName = studentBindingModel.FirstName,
                LastName = studentBindingModel.LastName,
                Gender = studentBindingModel.IsMale ? Gender.Male : Gender.Female,
                MobileNumber = studentBindingModel.MobileNumber,
                AverageGrade = studentBindingModel.Grades.Average(x => x.Value)
            };

            this.context.Students.Add(student);
            studentBindingModel.Id = student.Id;

            if (studentBindingModel.Grades.Count > 0)
                Program.GradeService.AddGrades(student.Id, studentBindingModel.Grades);

            Program.AuthService.AddStudentAccount(student);

            Router.AddRoute($"edit/{student.FacultyNumber}", new EditStudentControl(studentBindingModel));
        }

        public void EditStudent(StudentBindingModel studentBindingModel)
        {
            var student = new Student
            {
                Id = studentBindingModel.Id,
                FacultyNumber = studentBindingModel.FacultyNumber,
                Class = studentBindingModel.Class,
                EGN = studentBindingModel.EGN,
                FirstName = studentBindingModel.FirstName,
                LastName = studentBindingModel.LastName,
                Gender = studentBindingModel.IsMale ? Gender.Male : Gender.Female,
                MobileNumber = studentBindingModel.MobileNumber,
                AverageGrade = studentBindingModel.AverageGrade
            };

            this.context.Students.Update(student);

            if (studentBindingModel.Grades.Count > 0)
                Program.GradeService.AddGrades(student.Id, studentBindingModel.Grades);
        }

        public void DeleteStudent(string facultyNumber)
        {
            var student = GetStudent(x => x.FacultyNumber == facultyNumber);
            this.context.Students.Remove(student);
            Program.GradeService.DeleteGrades(student.Id);
            Program.AuthService.DeleteStudentAccount(student.Id);
            Router.RemoveRoute($"edit/{facultyNumber}");
            Router.RemoveRoute($"students/{facultyNumber}");
        }
    }
}
