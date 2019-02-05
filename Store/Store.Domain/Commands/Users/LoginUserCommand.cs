using Store.Commom.Commands;

namespace Store.Domain.Commands.Users
{
    public class LoginUserCommand : Command
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
