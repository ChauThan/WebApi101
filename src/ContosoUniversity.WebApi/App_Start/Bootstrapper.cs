using System.Data.Entity;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using ContosoUniversity.Data.Repositories;
using ContosoUniversity.Services;
using ContosoUniversity.Services.Interface;

namespace ContosoUniversity.WebApi
{
    public static class Bootstrapper
    {
        public static void Run()
        {
            // Configure Autofac
            AutofacWebapiConfig.Initialize(GlobalConfiguration.Configuration);
        }

    }
}