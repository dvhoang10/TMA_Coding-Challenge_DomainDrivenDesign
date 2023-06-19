using CRMMager.Contracts.Requests.Customer;
using CRMManager.Application.Features.Customers.Commands;
using CRMManager.Application.Features.Customers.Queries;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CRMManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CustomerController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var query = new ListAllCustomersQuery();
            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CreateCustomerRequest createCustomerRequest)
        {
            var command = _mapper.Map<CreateCustomerCommand>(createCustomerRequest);
            await _mediator.Send(command);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCustomer(UpdateCustomerRequest updateCustomerRequest)
        {
            var command = _mapper.Map<UpdateCustomerCommand>(updateCustomerRequest);
            await _mediator.Send(command);
            return Ok();
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = _mapper.Map<DeleteCustomerCommand>(id);
            await _mediator.Send(command);
            return Ok();
        }
    }
}
