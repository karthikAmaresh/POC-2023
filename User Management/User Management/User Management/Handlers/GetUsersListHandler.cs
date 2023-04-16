using MediatR;
using User_Management.Data;
using User_Management.Models;
using User_Management.Queries;

namespace User_Management.Handlers
{
    public class GetUsersListHandler : IRequestHandler<GetUsersListQuery, List<UserModel>>
    {
        private readonly IDataAccess _dataAccess;
        public GetUsersListHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<List<UserModel>> Handle(GetUsersListQuery query, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetUsers());
        }
    }
}
