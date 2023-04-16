namespace User_Management.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public int Salary { get; set; }
        public string OfficeLocation { get; set; }
    }
}
