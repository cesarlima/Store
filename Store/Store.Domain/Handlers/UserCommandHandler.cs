using MediatR;
using Store.Commom.Core;
using Store.Commom.Handlers;
using Store.Domain.Commands.Users;
using Store.Domain.Entities;
using Store.Domain.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Store.Domain.Handlers
{
    public class UserCommandHandler
        : CommandHandler
        , IRequestHandler<RegisterUserCommand, Response>
        , IRequestHandler<LoginUserCommand, Response>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _uow;

        public UserCommandHandler(IUserRepository userRepository, IUnitOfWork uow)
        {
            _userRepository = userRepository;
            _uow = uow;
        }

        public Task<Response> Handle(RegisterUserCommand command, CancellationToken cancellationToken)
        {
            if (_userRepository.Exists(u => u.Username == command.Username))
                AddNotification($"O nome de usuário {command.Username} já está em uso.");

            if(IsValid)
            {
                var user = new User(command.Username, command.Password);
                _userRepository.Add(user);
                _uow.Commit();

                Response.AddResult(user.Id);
            }

            return Task.FromResult(Response);
        }

        public Task<Response> Handle(LoginUserCommand command, CancellationToken cancellationToken)
        {
            var user = _userRepository.GetByUsername(command.Username);

            if (user == null || user.Authenticate(command.Username, command.Password) == false)
                AddNotification("Login ou senha inválidos.");

            if (IsValid)
            {
                Response.AddResult("Logado com sucesso!");
            }

            return Task.FromResult(Response);
        }
    }
}
