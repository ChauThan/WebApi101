using System.Web.Http;
using ContosoUniversity.WebApi.AutoMappers;

namespace ContosoUniversity.WebApi
{
    public static class Bootstrapper
    {
        public static void Run()
        {
            // Configure Autofac
            AutofacWebapiConfig.Initialize(GlobalConfiguration.Configuration);

            AutoMapperConfiguration.Configure();
        }

    }
}