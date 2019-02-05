using Store.Commom.Entities;

namespace Store.Domain.Entities
{
    public class User : Entity
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public bool Active { get; private set; }

        protected User() { }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            Active = true;
        }

        public bool Authenticate(string username, string password)
            => Username == username && Password == password;

        public void SetAsActive() => Active = true;
        public void SetAsInactive() => Active = false;
    }
}
