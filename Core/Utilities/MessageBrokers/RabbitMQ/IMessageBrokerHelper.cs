using Core.Utilities.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.MessageBrokers.RabbitMQ
{
    public interface IMessageBrokerHelper
    {
        void QueueMessage(string messageText);
        void QueueEmail(EmailMessage email);
    }
}
