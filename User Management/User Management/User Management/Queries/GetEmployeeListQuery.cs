using MediatR;
using User_Management.Models;

namespace User_Management.Queries
{
    public record GetEmployeesListQuery() : IRequest<List<EmployeeModel>>;

}
