using MediatR;
using User_Management.Commands;
using User_Management.Data;
using User_Management.Models;

namespace User_Management.Handlers
{
    public class AddUserHandler : IRequestHandler<AddUserCommand, UserModel>
    {
        private readonly IDataAccess _dataAccess;

        public AddUserHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<UserModel> Handle(AddUserCommand command, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.AddUser(command.firstName, command.lastName, command.EmailId , command.DateOfBirth));
        }
    }
}
