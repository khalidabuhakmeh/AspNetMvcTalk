using System.Web;
using AspNetMvcTalk.Web.App_Start;
using FluentValidation;
using Raven.Client;
using StructureMap.Configuration.DSL;

namespace AspNetMvcTalk.Web.DependencyResolution.Registries
{
    public class AppRegistry : Registry
    {
        public AppRegistry()
        {
            // let any service access the http context
            For<HttpContextBase>()
                .HybridHttpOrThreadLocalScoped()
                .Use(ctx => new HttpContextWrapper(HttpContext.Current));

            For<IDocumentStore>()
                .Singleton()
                .Use(RavenDbConfig.DocumentStore);

            // Register all Validators As They Are Written, IoC for the Win!
            AssemblyScanner.FindValidatorsInAssemblyContaining<AppRegistry>()
            .ForEach(result => For(result.InterfaceType)
                                   .HybridHttpOrThreadLocalScoped()
                                   .Use(result.ValidatorType));
        }

    }
}