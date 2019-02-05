using MediatR;
using Store.Commom.Core;

namespace Store.Commom.Commands
{
    public abstract class Command : IRequest<Response>
    {
    }
}
