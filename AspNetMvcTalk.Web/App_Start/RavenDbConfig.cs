using Raven.Client;
using Raven.Client.Embedded;
using Raven.Client.Indexes;

namespace AspNetMvcTalk.Web.App_Start
{
    public static class RavenDbConfig
    {
        public static readonly IDocumentStore DocumentStore
            = new EmbeddableDocumentStore
            {
                ConnectionStringName = "development",
                Conventions =
                {
                    IdentityPartsSeparator = "-"
                }
            }.Initialize();

        public static void Setup()
        {
            IndexCreation.CreateIndexes(typeof(RavenDbConfig).Assembly, DocumentStore);
            Raven.Client.MvcIntegration.RavenProfiler.InitializeFor(DocumentStore);
        }
    }
}