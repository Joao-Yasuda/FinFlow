using System.Threading.Tasks;
namespace MarketData.Domain.Interfaces;

public class IKafkaProducer
{
    Task PublishAsync<T>(string topic, T message);
    Task PublishAsync<T>(string topic, string key, T message);

}