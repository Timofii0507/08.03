using DecoratorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class MessageDecoratorBase : IMessage
    {
        protected IMessage _message;

        public MessageDecoratorBase(IMessage message)
        {
            _message = message;
        }

        public virtual string GetContent()
        {
            return _message.GetContent();
        }
    }
}