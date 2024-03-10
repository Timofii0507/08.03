using DecoratorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class BoldMessageDecorator : MessageDecoratorBase
    {
        public BoldMessageDecorator(IMessage message) : base(message) { }

        public override string GetContent()
        {
            return "<b>" + base.GetContent() + "</b>";
        }
    }
}