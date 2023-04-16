using User_Management.Models;

namespace User_Management.Data
{
    public interface IDataAccess
    {
        List<UserModel> GetUsers();

        List<EmployeeModel> GetEmployees();

        UserModel AddUser(string firstName, string lastName, string mailId, DateTime date);
    }
}
