using AutoMapper;
using CRM.Domain.Entities;
using CrmApplication.Data;
using CrmApplication.DTOs;
using CrmApplication.Interfaces;
using Microsoft.EntityFrameworkCore;
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
        private readonly IMapper _mapper;

        public CustomerService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public CustomerService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<CustomerDto> CreateAsync(CustomerCreateDto customerCreateDto)
        {
            var customerEntity = _mapper.Map<Customer>(customerCreateDto);

            await _context.Customers.AddAsync(customerEntity);

            await _context.SaveChangesAsync();

            return _mapper.Map<CustomerDto>(customerEntity);
        }

        public async Task<bool> DeleteAsync(Guid id) { 
        
        
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
                return false;

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return true;
        
        }

        public async Task<List<CustomerDto>> GetAllAsync()
        {
            var customers = await _context.Customers.ToListAsync();

            // AutoMapper ile entity listesi DTO listesine çevriliyor
            var customerDtos = _mapper.Map<List<CustomerDto>>(customers);

            return customerDtos;
        }

        public async Task<CustomerDto> GetByIdAsync(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);
            return customer is null ? null : _mapper.Map<CustomerDto>(customer);
        }

        public async Task<bool> UpdateAsync(CustomerUpdateDto customerUpdateDto)
        {
            var customer = await _context.Customers.FindAsync(customerUpdateDto.Id);
            if (customer == null)
                return false;

            // DTO'dan entity'ye veri aktarımı (AutoMapper ile)
            _mapper.Map(customerUpdateDto, customer);


            await _context.SaveChangesAsync();

            return true;
        }
    }
}
