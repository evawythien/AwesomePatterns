using Autofac;
using Autofac.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIExample
{
    public class SingleInstanceFactory : Service
    {
        public override string Description => throw new NotImplementedException();


        private static IContainer Container { get; set; }

        //static void Main(string[] args)
        //{
        //    var builder = new ContainerBuilder();
        //    builder.RegisterType<ConsoleOutput>().As<IOutput>();
        //    builder.RegisterType<TodayWriter>().As<IDateWriter>();
        //    Container = builder.Build();

        //    // The WriteDate method is where we'll make use
        //    // of our dependency injection. We'll define that
        //    // in a bit.
        //    WriteDate();
        //}

    }
}
