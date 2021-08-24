using AutoMapper;
using Dev.Application.ViewModels;
using Dev.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev.Application.AutoMapper
{
    public class ConfigProfile : Profile
    {
        public ConfigProfile()
        {
            CreateMap<Contato, ContatoViewModel>().ReverseMap();
        }

    }
}
