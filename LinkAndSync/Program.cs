namespace LinkAndSync.Gui
{
    internal static class Program
    {
        public static bool IsRunTime { get; private set; }

        [STAThread]
        static void Main()
        {
            IsRunTime = true;

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}