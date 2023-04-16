using MediatR;
using Microsoft.AspNetCore.Mvc;
using User_Management.Models;
using User_Management.Queries;

namespace User_Management.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Here's a small example of retrieving employeelist
        /// </summary>
        /// <returns>employees list</returns>

        [HttpGet]
        [Route("/Employee")]
        public async Task<List<EmployeeModel>> GetEmployeesList()
        {
            return await _mediator.Send(new GetEmployeesListQuery());
        }
      
    }
}
