using Api.GraphQLTypes;
using Api.Repository;
using HotChocolate.AzureFunctionsProxy;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: FunctionsStartup(typeof(Api.Startup))]
namespace Api
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<BookRepository>();

            builder.Services.AddGraphQLServer().AddQueryType<QueryType>();

            builder.Services.AddAzureFunctionsGraphQL((options) => {
                options.EnableBananaCakePop = true;
                options.EnableGETRequests = true;
            });
        }
    }
}
