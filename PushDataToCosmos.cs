using System;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;

public class PushDataToCosomos{
    internal static async Task DataToCosmos(string messageBoody){
        CosmosClient client= new CosmosClient("AccountEndpoint=https://eventcosmos1.documents.azure.com:443/;AccountKey=DdPaT5oUwbGBIuou1wGhzpl22omqpJ2Z5tB3GyX8SquOJFTlE7enMzZrLK7LGSheP8sC8RFKbvfLACDbU7xwUA==;");
        var container=client.GetContainer("eventhubdata","Container1");
        await container.CreateItemAsync(new {id = Guid.NewGuid(),data=messageBoody});
    }
}