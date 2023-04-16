using MediatR;
using User_Management.Models;

namespace User_Management.Commands
{
    public class AddUserCommand : IRequest<UserModel>
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string EmailId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
