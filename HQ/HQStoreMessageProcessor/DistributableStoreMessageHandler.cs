using DataSync.Common.AxisMessages.Contract;
using NServiceBus;
using NServiceBus.Logging;

namespace DataSync.HQ.HQStoreMessageProcessor
{
    public class DistributableStoreMessageHandler : IHandleMessages<AxisStoreDistributableOutboundMessage>
    {
        public IBus Bus { get; set; }
        private ILog logger = LogManager.GetLogger<AxisStoreDistributableOutboundMessage>();

        public void Handle(AxisStoreDistributableOutboundMessage message)
        {
            logger.Info("Distribute message that was started at " + message.Timestamp);
            logger.Info("and throwing exception");
            Bus.Send("507A4549-DD24-470B-9F14-E205BAC562F", message);
        }

    }
}