namespace lks24
{
	using System.Threading.Tasks;

	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static async Task Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			await Database.TestConnection();
			Application.Run(new Main());
		}
	}
}