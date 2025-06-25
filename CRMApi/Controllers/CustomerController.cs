using CrmApplication.DTOs;
using CrmApplication.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        
        
            private readonly ICustomerService _service;

            public CustomerController(ICustomerService service)
            {
                _service = service;
            }

            [HttpGet]
            public async Task<IActionResult> GetAll()
            {
                var customers = await _service.GetAllAsync();
                return Ok(customers);
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetById(Guid id)
            {
                var customer = await _service.GetByIdAsync(id);
                return customer == null ? NotFound() : Ok(customer);
            }

            [HttpPost]
            public async Task<IActionResult> Create([FromBody] CustomerCreateDto dto)
            {
                var created = await _service.CreateAsync(dto);
                return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
            }

            [HttpPut]
            public async Task<IActionResult> Update([FromBody] CustomerUpdateDto dto)
            {
                var result = await _service.UpdateAsync(dto);
                return result ? NoContent() : NotFound();
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(Guid id)
            {
                var result = await _service.DeleteAsync(id);
                return result ? NoContent() : NotFound();
            }
        }
    }
