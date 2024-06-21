using Emissora_Radio_Api.DTOs;
using Emissora_Radio_Api.Interface;
using Emissora_Radio_Api.Repositories;
using Microsoft.Extensions.Hosting;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

namespace Emissora_Radio_Api.RabbitMQConsumer
{
    public class RabbitMQProgramaConsumer : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private IConnection _connection;
        private IModel _channel;

        public RabbitMQProgramaConsumer(IServiceProvider serviceProvider )
        {
            _serviceProvider = serviceProvider;
            var factory = new ConnectionFactory
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest"
            };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare(queue: "NovosOuvintesQueue", false, false, false, arguments: null);
        }
        public IServiceProvider Services { get; }

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                stoppingToken.ThrowIfCancellationRequested();
                var consumer = new EventingBasicConsumer(_channel);
                consumer.Received += (Chanel, evento) =>
                {
                    var content = Encoding.UTF8.GetString(evento.Body.ToArray());
                    ProgramaDTO programa = JsonSerializer.Deserialize<ProgramaDTO>(content);
                    CriarUsuario(programa).GetAwaiter().GetResult();
                    _channel.BasicAck(evento.DeliveryTag, false);
                };
                _channel.BasicConsume("NovosOuvintesQueue", false, consumer);

                Console.WriteLine("ping");

                await Task.Delay(1000);
            }
            


        }


        private async Task CriarUsuario(ProgramaDTO programa)
        {
            using(var scope = _serviceProvider.CreateScope())
            {
               var programaRepository = scope.ServiceProvider.GetRequiredService<IProgramaRepository>();
                programaRepository.Create(programa);
            }
             

        }
    }
}
