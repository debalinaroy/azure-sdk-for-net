// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Samples
{
    public partial class Sample_CosmosDBForPostgreSqlNodeConfigurationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetConfigurationDetailsForNode()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ConfigurationGetNode.json
            // this example is just showing the usage of "Configurations_GetNode" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlNodeConfigurationResource created on azure
            // for more information of creating CosmosDBForPostgreSqlNodeConfigurationResource, please refer to the document of CosmosDBForPostgreSqlNodeConfigurationResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestResourceGroup";
            string clusterName = "testcluster";
            string configurationName = "array_nulls";
            ResourceIdentifier cosmosDBForPostgreSqlNodeConfigurationResourceId = CosmosDBForPostgreSqlNodeConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, configurationName);
            CosmosDBForPostgreSqlNodeConfigurationResource cosmosDBForPostgreSqlNodeConfiguration = client.GetCosmosDBForPostgreSqlNodeConfigurationResource(cosmosDBForPostgreSqlNodeConfigurationResourceId);

            // invoke the operation
            CosmosDBForPostgreSqlNodeConfigurationResource result = await cosmosDBForPostgreSqlNodeConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlServerConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateSingleConfigurationOfNodes()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ConfigurationUpdateNode.json
            // this example is just showing the usage of "Configurations_UpdateOnNode" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlNodeConfigurationResource created on azure
            // for more information of creating CosmosDBForPostgreSqlNodeConfigurationResource, please refer to the document of CosmosDBForPostgreSqlNodeConfigurationResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestResourceGroup";
            string clusterName = "testcluster";
            string configurationName = "array_nulls";
            ResourceIdentifier cosmosDBForPostgreSqlNodeConfigurationResourceId = CosmosDBForPostgreSqlNodeConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, configurationName);
            CosmosDBForPostgreSqlNodeConfigurationResource cosmosDBForPostgreSqlNodeConfiguration = client.GetCosmosDBForPostgreSqlNodeConfigurationResource(cosmosDBForPostgreSqlNodeConfigurationResourceId);

            // invoke the operation
            CosmosDBForPostgreSqlServerConfigurationData data = new CosmosDBForPostgreSqlServerConfigurationData
            {
                Value = "off",
            };
            ArmOperation<CosmosDBForPostgreSqlNodeConfigurationResource> lro = await cosmosDBForPostgreSqlNodeConfiguration.UpdateAsync(WaitUntil.Completed, data);
            CosmosDBForPostgreSqlNodeConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlServerConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
