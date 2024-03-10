using DecoratorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Message : IMessage
    {
        private string _content;

        public Message(string content)
        {
            _content = content;
        }

        public string GetContent()
        {
            return _content;
        }
    }
}