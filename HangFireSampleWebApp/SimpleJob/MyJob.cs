namespace HangFireSampleWebApp.SimpleJob
{
    using System.Threading;
    using Microsoft.Extensions.Configuration;
    using Serilog;

    public class MyJob
    {
        private IConfiguration _configuration;
        public MyJob(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void start()
        {
            Thread.Sleep(5000);
            Log.Information("My Job started...");
            Log.Information(_configuration.GetConnectionString("HangfireConnection"));
        }
    }
}
