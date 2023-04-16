using User_Management.Models;

namespace User_Management.Data
{
    public class DataAccess : IDataAccess
    {
        private List<UserModel> _users = new();
        private List<EmployeeModel> _employees = new();

        public DataAccess()
        {

            // user data
            _users.Add(new UserModel { Id = 1, FirstName = "Raj", LastName = "kumar", EmailId = "Raj.Kumar@gmail.com", DateOfBirth = new DateTime(1998, 05, 15, 9, 15, 0)});
            _users.Add(new UserModel { Id = 2, FirstName = "Kushi", LastName = "Ravindra", EmailId = "Kushi.Ravindra@gmail.com", DateOfBirth = new DateTime(1999, 08, 09, 9, 15, 0) });
            _users.Add(new UserModel { Id = 3, FirstName = "Arya", LastName = "Arjun", EmailId = "Arya.Arjun@gmail.com", DateOfBirth = new DateTime(1995, 03, 06, 9, 15, 0) });
            _users.Add(new UserModel { Id = 4, FirstName = "Shivani", LastName = "S", EmailId = "Shivani@gmail.com", DateOfBirth = new DateTime(1993, 03, 29, 9, 15, 0) });
            _users.Add(new UserModel { Id = 5, FirstName = "Hitesh", LastName = "Kumar", EmailId = "Hitesh.Kumar@gmail.com", DateOfBirth = new DateTime(1992, 01, 09, 9, 15, 0) });
            _users.Add(new UserModel { Id = 6, FirstName = "Bhoj", LastName = "Raj", EmailId = "BhojRaj@gmail.com", DateOfBirth = new DateTime(1996, 11, 05, 9, 15, 0) });
            _users.Add(new UserModel { Id = 7, FirstName = "Chaitra", LastName = "Vs", EmailId = "Chaitra@gmail.com", DateOfBirth = new DateTime(1995, 10, 24, 9, 15, 0) });
            _users.Add(new UserModel { Id = 8, FirstName = "Aishwarya", LastName = "Rajendra", EmailId = "Aishwarya.Rajendra@gmail.com", DateOfBirth = new DateTime(2002, 06, 14, 9, 15, 0) });
            _users.Add(new UserModel { Id = 9, FirstName = "Dishanth", LastName = "Raj", EmailId = "Dishanth.Raj@gmail.com", DateOfBirth = new DateTime(2000, 02, 07, 9, 15, 0) });
            _users.Add(new UserModel { Id = 10, FirstName = "Sanjay", LastName = "Kumar", EmailId = "Sanjay.Kumar@gmail.com", DateOfBirth = new DateTime(1998, 05, 08, 9, 15, 0) });
            _users.Add(new UserModel { Id = 11, FirstName = "Abhishek", LastName = "Hatti", EmailId = "Abhishek@gmail.com", DateOfBirth = new DateTime(1999, 12, 09, 9, 15, 0) });
            _users.Add(new UserModel { Id = 12, FirstName = "Amulya", LastName = "Arjun", EmailId = "Amulya.Arjun@gmail.com", DateOfBirth = new DateTime(1995, 04, 11, 9, 15, 0) });

            // employee data

            _employees.Add(new EmployeeModel { Id = 1, UserId = 1, CompanyName = "Inferno Technology Private Limited", OfficeLocation = "Bangalore", Salary = 50000 });
            _employees.Add(new EmployeeModel { Id = 2, UserId = 2, CompanyName = "Inferno Technology Private Limited", OfficeLocation = "Bangalore", Salary = 50000 });
            _employees.Add(new EmployeeModel { Id = 3, UserId = 3, CompanyName = "Inferno Technology Private Limited", OfficeLocation = "Bangalore", Salary = 80000 });
            _employees.Add(new EmployeeModel { Id = 4, UserId = 4, CompanyName = "Jolt Technology Private Limited", OfficeLocation = "Bangalore", Salary = 75000 });
            _employees.Add(new EmployeeModel { Id = 5, UserId = 5, CompanyName = "Vaporeo Technology Private Limited", OfficeLocation = "Mysore", Salary = 43000 });
            _employees.Add(new EmployeeModel { Id = 6, UserId = 6, CompanyName = "Jolt Technology Private Limited", OfficeLocation = "Bangalore", Salary = 35000 });
            _employees.Add(new EmployeeModel { Id = 7, UserId = 7, CompanyName = "Inferno Technology Private Limited", OfficeLocation = "Bangalore", Salary = 90000 });
            _employees.Add(new EmployeeModel { Id = 8, UserId = 8, CompanyName = "Jolt Technology Private Limited", OfficeLocation = "Bangalore", Salary = 12000 });
            _employees.Add(new EmployeeModel { Id = 9, UserId = 9, CompanyName = "Inferno Technology Private Limited", OfficeLocation = "Bangalore", Salary = 20000 });
            _employees.Add(new EmployeeModel { Id = 10, UserId = 10, CompanyName = "Vaporeo Technology Private Limited", OfficeLocation = "Mysore", Salary = 25000 });
            _employees.Add(new EmployeeModel { Id = 11, UserId = 11, CompanyName = "Inferno Technology Private Limited", OfficeLocation = "Bangalore", Salary = 60000 });
            _employees.Add(new EmployeeModel { Id = 12, UserId = 12, CompanyName = "Jolt Technology Private Limited", OfficeLocation = "Bangalore", Salary = 40000 });
        }

        public List<UserModel> GetUsers()
        {
            return _users;
        }

        public List<EmployeeModel> GetEmployees()
        {
            return _employees;
        }

        public UserModel AddUser(string FirstName, string LastName , string mailId , DateTime date)
        {
            UserModel newUser = new() { FirstName = FirstName, LastName = LastName , EmailId = mailId , DateOfBirth = date };
            newUser.Id = _users.Count() + 1;
            _users.Add(newUser);
            return newUser;
        }
    }
}
