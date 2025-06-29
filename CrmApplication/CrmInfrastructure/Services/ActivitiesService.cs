using AutoMapper;
using CRM.Domain.Entities;
using CrmApplication.Data;
using CrmApplication.DTOs;
using CrmApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Infrastructure.Services
{
    public class ActivityService : IActivitiesService
    {
        public Task<ActivitiesDto> CreateAsync(ActivitiesCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ActivitiesDto?> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ActivitiesDto>> GetByCustomerAsync(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(ActivitiesUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }


}

