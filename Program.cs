using System.ServiceProcess;
using static System.Console;
namespace PharmacyHome
{
    public class Program
    {
        private static IHost CurrentHost;
        public static void Main(string[] args)
        {
            CurrentHost = ConfigureHostBuilder(args).Build();

            if (OperatingSystem.IsLinux())
            {
                Start(args);
                WriteLine("The program has been started. Press ESC to exit");
                while (true)
                {
                    var key = ReadKey();
                    if (key.Key == ConsoleKey.Escape) break;
                }
                Stop();
            }
            else if (OperatingSystem.IsWindows())
                ServiceBase.Run(new Service());

            CurrentHost.Run();
        }

        public static IHostBuilder ConfigureHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webbuilder =>
                    webbuilder.UseStartup<Startup>()
                        .UseKestrel()
                        .UseSetting(WebHostDefaults.DetailedErrorsKey, "true")
                        .UseStaticWebAssets());

        public static void Start(string[] args) => CurrentHost.RunAsync();
        public static void Stop() => CurrentHost.StopAsync().Wait();
    }
}