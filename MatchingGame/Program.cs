namespace MatchingGame
{
    internal static class Program
    {
        /// Povzetek
        ///  Glavna vstopna točka za aplikacijo.
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
