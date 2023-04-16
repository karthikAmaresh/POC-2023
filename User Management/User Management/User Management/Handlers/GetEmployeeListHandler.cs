using MediatR;
using User_Management.Data;
using User_Management.Models;
using User_Management.Queries;

namespace User_Management.Handlers
{
    public class GetEmployeesListHandler : IRequestHandler<GetEmployeesListQuery, List<EmployeeModel>>
    {
        private readonly IDataAccess _dataAccess;
        public GetEmployeesListHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<List<EmployeeModel>> Handle(GetEmployeesListQuery query, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetEmployees());
        }
    }
}
