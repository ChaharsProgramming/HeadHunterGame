using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.IO;
using System.Windows.Forms;

namespace HeadHunterGame.RockScissorsPaper
{
    class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new HostBuilder()
               .ConfigureServices((hostContext, services) =>
               {
                   services.AddScoped<Form1>();

                   //Add Serilog
                   var serilogLogger = new LoggerConfiguration()
                           .WriteTo.File(Path.Combine(Environment.CurrentDirectory, @"AppLogs\", "AppLogs.txt"))
                   .CreateLogger();
                   services.AddLogging(x =>
                   {
                       x.SetMinimumLevel(LogLevel.Information);
                       x.AddSerilog(logger: serilogLogger, dispose: true);
                   });

               });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
               // ILogger<Form1> logger = services.GetRequiredService<ILogger<Form1>>();
                try
                {
                    var form1 = services.GetRequiredService<Form1>();
                    Application.Run(form1);
                }
                catch (Exception ex)
                {
                    throw new CustomGameException(ex.StackTrace);
                }
            }
        }
    }
}
