using AutoMapper;
using PessoaService.Application.DTOs;
using PessoaService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PessoaService.Infrastructure.Mappings
{
    public class PessoaMappingProfile : Profile
    {
        public PessoaMappingProfile()
        {
            CreateMap<Pessoa, PessoaDto>().ReverseMap();
        }
    }
}
