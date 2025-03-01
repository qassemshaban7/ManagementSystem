namespace Management_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());

            //Application.Run(new TasksForm(2));
            //Application.Run(new Form1());
            //Application.Run(new ReportsForm(2));
            //Application.Run(new AllTasksForm(1));
        }
    }
}