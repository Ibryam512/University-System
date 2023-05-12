using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem.Data;
using UniSystem.Data.Entities;

namespace UniSystem.Services
{
    public class GradeService
    {
        private readonly UniSystemDbContext context;

        public GradeService(UniSystemDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<Grade> GetGrades(int studentId) => this.context.Grades.Where(x => x.StudentId == studentId);

        public void AddGrades(int studentId, Dictionary<string, double> grades)
        {
            foreach (var info in grades)
            {
                var grade = new Grade
                {
                    Subject = info.Key,
                    Value = info.Value,
                    StudentId = studentId
                };
                this.context.Grades.Add(grade);
            }
        }
    }
}
