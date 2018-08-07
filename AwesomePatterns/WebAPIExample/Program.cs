using Autofac;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using static WebAPIExample.Infrastructure.Class1;

namespace WebAPIExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            BuildWebHost(args).Run();

            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayWriter>().As<IDateWriter>();
            builder.Build();

            // The WriteDate method is where we'll make use
            // of our dependency injection. We'll define that
            // in a bit.
            WriteDate();
        }

        public static void WriteDate()
        {
            // Create the scope, resolve your IDateWriter,
            // use it, then dispose of the scope.
            //using (var scope = Container.BeginLifetimeScope())
            //{
            //    IDateWriter writer = scope.Resolve<IDateWriter>();
            //    writer.WriteDate();
            //}
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
