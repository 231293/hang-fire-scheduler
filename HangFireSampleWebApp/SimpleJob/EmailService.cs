namespace HangFireSampleWebApp.SimpleJob
{
    using Serilog;

    public class EmailService : IEmailService
    {
        public void Send()
        {
            Log.Information("Email Sent Successful");
        }
    }
}
