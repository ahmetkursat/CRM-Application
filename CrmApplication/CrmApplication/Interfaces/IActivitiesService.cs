using CrmApplication.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.Interfaces
{
    public interface IActivitiesService
    {
        Task<List<ActivitiesDto>> GetByCustomerAsync(Guid customerId);
        Task<ActivitiesDto?> GetAsync(Guid id);
        Task<ActivitiesDto> CreateAsync(ActivitiesCreateDto dto);
        Task<bool> UpdateAsync(ActivitiesUpdateDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
