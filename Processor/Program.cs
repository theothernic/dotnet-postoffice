using System;

namespace Postoffice.Processor
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            
            Startup startup = new Startup();
            startup.ConfigureServices(services);
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetService<ILoggerFactory>()
                .AddConsole(LogLevel.Debug);
            
            // Get message files.
            
            // Parse the contacts (recipients and senders)
            
            // Parse the body.
            
            // Save message data to the database.
            
            // Parse attachments (?)
            
            // Save 


        }
    }
}
