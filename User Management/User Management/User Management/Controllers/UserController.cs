using MediatR;
using Microsoft.AspNetCore.Mvc;
using User_Management.Commands;
using User_Management.Models;
using User_Management.Queries;

namespace User_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<UserModel>> GetUsersList()
        {
            return await _mediator.Send(new GetUsersListQuery());
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] AddUserCommand command)
        {
            var validate = new CreateUserValidator();
            var result = validate.Validate(command);
            if (result.IsValid)
            {
                UserModel response = await _mediator.Send(command);
                return new OkObjectResult(response); 
            }
            else
            {
                return new BadRequestObjectResult(result.Errors.Select(x => x.ErrorMessage));
            }
        }
    }
}
