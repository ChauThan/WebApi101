using System.Data.Entity;
using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using ContosoUniversity.Data.Repositories;
using ContosoUniversity.Services;
using ContosoUniversity.Services.Interface;

namespace ContosoUniversity.WebApi
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

        public static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<ContosoUniversityContext>()
                   .AsSelf()
                   .InstancePerRequest();

            builder.RegisterType<UnitOfWork>()
                .As<IUnitOfWork>()
                .AsImplementedInterfaces()
                .InstancePerRequest();


            builder.RegisterGeneric(typeof(GenericRepository<>))
                   .As(typeof(IGenericRepository<>))
                   .InstancePerRequest();

            builder.RegisterType<StudentService>()
                .As<IStudentService>()
                .InstancePerRequest();


            Container = builder.Build();

            return Container;
        }
    }
}