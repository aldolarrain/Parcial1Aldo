using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using fncPar.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace fncPar
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task RunAsync([ServiceBusTrigger("qpar", Connection = "MyConn")] string myQueueItem,
            [CosmosDB(
                    databaseName:"dbImpar",
                    collectionName:"Events",
                    ConnectionStringSetting ="strCosmos"
                    )]IAsyncCollector<object> datos,
            ILogger log)
        {
            try
            {
                log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
                var data = JsonConvert.DeserializeObject<Doble>(myQueueItem);
                await datos.AddAsync(data);
            }
            catch (Exception ex)
            {
                log.LogError($"No fue posible insertar datos: {ex.Message}");
            }

        }
    }
}
