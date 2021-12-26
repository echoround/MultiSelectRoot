using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SelectBoxAPI.Data;
using static SelectBoxAPI.Data.DbInitializer;


namespace SelectBoxAPI
{

    public class Program
    {

        public static void Main(string[] args)
        {

            var host = CreateHostBuilder(args).Build();
            var services = host.Services.CreateScope();
            var context = services.ServiceProvider.GetRequiredService<SelectBoxAPIContext>();


            Initialize(context);

            host.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();

                });


    }
}
