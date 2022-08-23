using Autofac;
using Demo.Common;

namespace Demo.Service1
{
    public class Service1Module : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Service1>().As<IService>();
            builder.RegisterType<Service1abc>().As<IService1abc>();
        }
    }
}
