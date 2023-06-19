using CRMManager.Application.Features.Customers.Commands;
using CRMManager.Application.Features.Customers.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CRMManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var query = new ListAllCustomersQuery();
            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(string name, string taxNumber, string street)
        {
            var command = new CreateCustomerCommand(name, taxNumber, street);
            await _mediator.Send(command);
            return Ok();
        }

    }
}
