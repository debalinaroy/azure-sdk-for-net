// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.EdgeOrder.Samples
{
    public partial class Sample_EdgeOrderResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetOrderByName()
        {
            // Generated from example definition: specification/edgeorder/resource-manager/Microsoft.EdgeOrder/stable/2021-12-01/examples/GetOrderByName.json
            // this example is just showing the usage of "GetOrderByName" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EdgeOrderResource created on azure
            // for more information of creating EdgeOrderResource, please refer to the document of EdgeOrderResource
            string subscriptionId = "fa68082f-8ff7-4a25-95c7-ce9da541242f";
            string resourceGroupName = "TestRG";
            AzureLocation location = new AzureLocation("%7B%7B%7Blocation%7D%7D");
            string orderName = "TestOrderItemName901";
            ResourceIdentifier edgeOrderResourceId = EdgeOrderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, location, orderName);
            EdgeOrderResource edgeOrder = client.GetEdgeOrderResource(edgeOrderResourceId);

            // invoke the operation
            EdgeOrderResource result = await edgeOrder.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EdgeOrderData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
