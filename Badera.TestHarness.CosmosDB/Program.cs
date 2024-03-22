using Microsoft.Azure.Cosmos;

try
{
    CosmosClientOptions options = new CosmosClientOptions { ConnectionMode= ConnectionMode.Gateway };
    CosmosClient cosmosClient = new CosmosClient("AccountEndpoint={YOUR_ENDPOINT};AccountKey={YOUR_KEY}", options);
    cosmosClient.CreateDatabaseIfNotExistsAsync("{EXPECTED_DB_NAME}").Wait();
}
catch (CosmosException cex)
{

}
catch (AggregateException aex)
{

}
catch (Exception ex)
{

}
