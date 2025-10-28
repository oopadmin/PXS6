namespace PXS6
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            FormManager.Initialize();
            Application.Run(FormManager.encryptForm!);
        }
    }
}