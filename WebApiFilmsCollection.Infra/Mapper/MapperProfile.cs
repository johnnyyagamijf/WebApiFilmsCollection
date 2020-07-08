using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiFilmsCollection.Application.ViewModels;
using WebApiFilmsCollection.Core.Entities;

namespace WebApiFilmsCollection.Infra.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<FilmeEntity, FilmeViewModel>().ReverseMap();
        }
    }
}
