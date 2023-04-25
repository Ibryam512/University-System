namespace UniSystem.Data
{
    public class UniSystemDbContext
    {
        public DbSet<Student> Students { get; set; }

        public UniSystemDbContext()
        {
            Students = new DbSet<Student>();
        }
    }
}
