using UniSystem.Services;

namespace UniSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static StudentService StudentService { get; private set; }
        [STAThread]
        static void Main()
        {
            StudentService = new StudentService(new Data.UniSystemDbContext());
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}