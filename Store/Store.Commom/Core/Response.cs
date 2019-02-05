using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Store.Commom.Core
{
    public class Response
    {
        private readonly IList<string> _messages;
        public IEnumerable<string> Notifications { get; }
        public object Result { get; private set; }

        public Response()
        {
            _messages = new List<string>();
            Notifications = new ReadOnlyCollection<string>(_messages);
        }

        public Response AddNotification(string message)
        {
            _messages.Add(message);
            return this;
        }

        public void AddResult(object result)
        {
            if (IsValid)
                Result = result;
        }

        public bool IsValid => _messages.Any() == false;
        public bool IsInvalid => _messages.Any();
    }
}
