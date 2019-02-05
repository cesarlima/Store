using Store.Commom.Commands;

namespace Store.Domain.Commands.Users
{
    public class RegisterUserCommand : Command
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
