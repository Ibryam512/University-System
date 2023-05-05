using UniSystem.Data;
using UniSystem.Services;

namespace UniSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static StudentService StudentService { get; private set; }
        public static GradeService GradeService { get; set; }
        public static AuthService AuthService { get; set; }
        public static NewsService NewsService { get; set; }

        [STAThread]
        static void Main()
        {
            var context = new UniSystemDbContext();
            Seeder.Seed(context);
            StudentService = new StudentService(context);
            GradeService = new GradeService(context);
            AuthService = new AuthService(context);
            NewsService = new NewsService(context);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthForm());
        }
    }
}