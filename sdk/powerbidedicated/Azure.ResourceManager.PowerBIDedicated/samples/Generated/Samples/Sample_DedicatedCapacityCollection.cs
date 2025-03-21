// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.PowerBIDedicated.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.PowerBIDedicated.Samples
{
    public partial class Sample_DedicatedCapacityCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateCapacity()
        {
            // Generated from example definition: specification/powerbidedicated/resource-manager/Microsoft.PowerBIdedicated/stable/2021-01-01/examples/createCapacity.json
            // this example is just showing the usage of "Capacities_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "613192d7-503f-477a-9cfe-4efc3ee2bd60";
            string resourceGroupName = "TestRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DedicatedCapacityResource
            DedicatedCapacityCollection collection = resourceGroupResource.GetDedicatedCapacities();

            // invoke the operation
            string dedicatedCapacityName = "azsdktest";
            DedicatedCapacityData data = new DedicatedCapacityData(new AzureLocation("West US"), new CapacitySku("A1")
            {
                Tier = CapacitySkuTier.PbieAzure,
            })
            {
                AdministrationMembers = { "azsdktest@microsoft.com", "azsdktest2@microsoft.com" },
                Tags =
{
["testKey"] = "testValue"
},
            };
            ArmOperation<DedicatedCapacityResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dedicatedCapacityName, data);
            DedicatedCapacityResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DedicatedCapacityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDetailsOfACapacity()
        {
            // Generated from example definition: specification/powerbidedicated/resource-manager/Microsoft.PowerBIdedicated/stable/2021-01-01/examples/getCapacity.json
            // this example is just showing the usage of "Capacities_GetDetails" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "613192d7-503f-477a-9cfe-4efc3ee2bd60";
            string resourceGroupName = "TestRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DedicatedCapacityResource
            DedicatedCapacityCollection collection = resourceGroupResource.GetDedicatedCapacities();

            // invoke the operation
            string dedicatedCapacityName = "azsdktest";
            DedicatedCapacityResource result = await collection.GetAsync(dedicatedCapacityName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DedicatedCapacityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListCapacitiesInResourceGroup()
        {
            // Generated from example definition: specification/powerbidedicated/resource-manager/Microsoft.PowerBIdedicated/stable/2021-01-01/examples/listCapacitiesInResourceGroup.json
            // this example is just showing the usage of "Capacities_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "613192d7-503f-477a-9cfe-4efc3ee2bd60";
            string resourceGroupName = "TestRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DedicatedCapacityResource
            DedicatedCapacityCollection collection = resourceGroupResource.GetDedicatedCapacities();

            // invoke the operation and iterate over the result
            await foreach (DedicatedCapacityResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DedicatedCapacityData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetDetailsOfACapacity()
        {
            // Generated from example definition: specification/powerbidedicated/resource-manager/Microsoft.PowerBIdedicated/stable/2021-01-01/examples/getCapacity.json
            // this example is just showing the usage of "Capacities_GetDetails" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "613192d7-503f-477a-9cfe-4efc3ee2bd60";
            string resourceGroupName = "TestRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DedicatedCapacityResource
            DedicatedCapacityCollection collection = resourceGroupResource.GetDedicatedCapacities();

            // invoke the operation
            string dedicatedCapacityName = "azsdktest";
            bool result = await collection.ExistsAsync(dedicatedCapacityName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetDetailsOfACapacity()
        {
            // Generated from example definition: specification/powerbidedicated/resource-manager/Microsoft.PowerBIdedicated/stable/2021-01-01/examples/getCapacity.json
            // this example is just showing the usage of "Capacities_GetDetails" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "613192d7-503f-477a-9cfe-4efc3ee2bd60";
            string resourceGroupName = "TestRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DedicatedCapacityResource
            DedicatedCapacityCollection collection = resourceGroupResource.GetDedicatedCapacities();

            // invoke the operation
            string dedicatedCapacityName = "azsdktest";
            NullableResponse<DedicatedCapacityResource> response = await collection.GetIfExistsAsync(dedicatedCapacityName);
            DedicatedCapacityResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DedicatedCapacityData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
