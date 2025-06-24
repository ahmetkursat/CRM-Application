using CrmApplication.DTOs;
using CrmApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Infrastructure.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly AppDbContext _context;

        public CustomerService(AppDbContext context)
        {
            _context = context;
        }

        public Task<CustomerDto> CreateAsync(CustomerCreateDto customerCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CustomerDto>> GetAllAsync()
        {
            return await _context.Customers
                .Select(c => new CustomerDto
                {
                    Id = c.Id,
                    CompanyName = c.CompanyName,
                    ContactPerson = c.ContactPerson,
                    Email = c.Email,
                    Phone = c.Phone,
                    Address = c.Address
                })
                .ToListAsync();
        }

        public async Task<CustomerDto> GetByIdAsync(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);
            return customer is null ? null : MapToDto(customer);
        }

        public Task<bool> UpdateAsync(CustomerUpdateDto customerUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
