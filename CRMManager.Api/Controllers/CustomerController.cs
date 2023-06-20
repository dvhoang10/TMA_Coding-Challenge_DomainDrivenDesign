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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var query = _mapper.Map<GetCustomerByIdQuery>(id);
            var result = await _mediator.Send(query);

            if (result == null) return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CreateCustomerRequest createCustomerRequest)
        {
            var command = _mapper.Map<CreateCustomerCommand>(createCustomerRequest);
            var result = await _mediator.Send(command);

            if (result == null) return NotFound();

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCustomer(UpdateCustomerRequest updateCustomerRequest)
        {
            var command = _mapper.Map<UpdateCustomerCommand>(updateCustomerRequest);
            var result = await _mediator.Send(command);

            if (result == null) return NotFound();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var command = _mapper.Map<DeleteCustomerCommand>(id);
            var result = await _mediator.Send(command);

            if (result == null) return NotFound();

            return Ok(result);
        }
    }
}
