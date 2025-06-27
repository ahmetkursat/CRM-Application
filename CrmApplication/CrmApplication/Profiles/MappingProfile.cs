using AutoMapper;
using CRM.Domain.Entities;
using CrmApplication.DTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.NewFolder
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerCreateDto,Customer>();
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}
