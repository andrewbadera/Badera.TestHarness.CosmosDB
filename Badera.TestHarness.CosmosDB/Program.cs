using Microsoft.Azure.Cosmos;

CosmosClient cosmosClient = new CosmosClient("AccountEndpoint={YOUR_ENDPOINT};AccountKey={YOUR_KEY}");

try
{
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
