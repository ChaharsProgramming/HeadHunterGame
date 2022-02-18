using System;
using System.Runtime.Serialization;

namespace HeadHunterGame.RockScissorsPaper
{
    public class CustomGameException : Exception
    {
        public CustomGameException()
        {

        }

        public CustomGameException(string message) : base(message)
        {
        }

        public CustomGameException(string message, Exception exception) : base(message, exception)
        {
        }

        public CustomGameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
