
using System.Reflection;
using DataSync.Common.AxisMessages.Contract;
using NServiceBus;

namespace DataSync.HQ.HQStoreMessageProcessor
{
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Worker
    {

        public void Customize(BusConfiguration configuration)
        {
            configuration.AssembliesToScan(Assembly.GetExecutingAssembly(), typeof(ReportStoreMessage).Assembly, typeof(AzureStorageQueueTransport).Assembly);
            configuration.UseTransport<AzureStorageQueueTransport>();
            configuration.UsePersistence<InMemoryPersistence>();
        }
    }
}