using AutoMapper;
using InvoiceManagmentSystem.Core.Entity.Concrete;
using InvoiceManagmentSystem.Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Core.Utilities.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegisterDto, User>();
        }
    }
}
