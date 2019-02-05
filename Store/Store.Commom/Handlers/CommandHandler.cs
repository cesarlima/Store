using Store.Commom.Core;

namespace Store.Commom.Handlers
{
    public abstract class CommandHandler
    {
        protected readonly Response Response = new Response();

        protected void AddNotification(string message)
        {
            Response.AddNotification(message);
        }

        public bool IsValid => Response.IsValid;
        public bool IsInvalid => Response.IsInvalid;
    }
}
