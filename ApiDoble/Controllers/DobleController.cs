using ApiDoble.Models;
using Azure.Messaging.ServiceBus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDoble.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DobleController : ControllerBase
    {
        [HttpPost]
        public async Task<bool> EnviarAsync([FromBody] Doble doble)
        {

            string connectionString = "Endpoint=sb://qimpar1.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=B8AJ5zfVsOdJ+5bl9wIn2WZSjOGFtnHMeipdkqcbHoI=";
            string queueName = "qImpar1";
            string mensaje = JsonConvert.SerializeObject(doble);

            // create a Service Bus client 
            await using (ServiceBusClient client = new ServiceBusClient(connectionString))
            {
                // create a sender for the queue 
                ServiceBusSender sender = client.CreateSender(queueName);

                // create a message that we can send
                ServiceBusMessage message = new ServiceBusMessage(mensaje);

                // send the message
                await sender.SendMessageAsync(message);
                Console.WriteLine($"Sent a single message to the queue: {queueName}");
            }

            return true;
        }






    }
}
