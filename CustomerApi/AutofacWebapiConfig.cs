using Autofac;
using Autofac.Integration.WebApi;
using Data;
using Service;
using System.Reflection;
using System.Web.Http;

namespace CustomerApi
{
    public class AutofacWebapiConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }
        
        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<CustomerEntities>()
                   .AsSelf()
                   .InstancePerRequest();

            builder.RegisterType<DbFactory>()
                   .As<IDbFactory>()
                   .InstancePerRequest();

            builder.RegisterType<CustomerRepository>()
                   .As(typeof(ICustomerRepository))
                   .InstancePerRequest();

            builder.RegisterType<CustomerService>()
                .As<ICustomerService>()
                .InstancePerRequest();

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }
    }
}