namespace HangFireSampleWebApp
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Lamar.Microsoft.DependencyInjection;
    using Serilog;

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseLamar()
                .UseSerilog();
    }
}
