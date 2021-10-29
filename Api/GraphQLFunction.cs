using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using HotChocolate.AzureFunctionsProxy;
using System.Threading;

namespace Api
{
    public class GraphQLFunction
    {
        private readonly IGraphQLAzureFunctionsExecutorProxy _graphqlExecutorProxy;

        public GraphQLFunction(IGraphQLAzureFunctionsExecutorProxy graphqlExecutorProxy)
        {
            _graphqlExecutorProxy = graphqlExecutorProxy;
        }

        //path to function will be api/graphql
        [FunctionName(nameof(GraphQLFunction))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "graphql")] HttpRequest req,
            ILogger logger, CancellationToken cancellationToken)
        {
            logger.LogInformation("C# GraphQL Request processing via Serverless AzureFunctions...");

            return await _graphqlExecutorProxy.ExecuteFunctionsQueryAsync(
                req.HttpContext,
                logger,
                cancellationToken
            ).ConfigureAwait(false);
        }
    }
}
