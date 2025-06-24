using CrmApplication.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.Interfaces
{
    public interface ICustomerService
    {
        Task<List<CustomerDto>> GetAllAsync();
        Task<CustomerDto> GetByIdAsync(Guid id);

        Task<CustomerDto> CreateAsync(CustomerCreateDto customerCreateDto);

        Task<bool> UpdateAsync (CustomerUpdateDto customerUpdateDto);

        Task<bool> DeleteAsync(Guid id);

    }
}
