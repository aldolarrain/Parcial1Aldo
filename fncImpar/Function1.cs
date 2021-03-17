using System;
using System.Net;
using System.Net.Mail;
using fncImpar.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace fncImpar
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([ServiceBusTrigger("qimpar", Connection = "MyConn")]string myQueueItem,
            [CosmosDB(
                    databaseName:"dbUbicua",
                    collectionName:"Eventos",
                    ConnectionStringSetting ="strCosmos"
                    )]IAsyncCollector<object> datos,
            ILogger log)
        {
            


        }
    }
}
