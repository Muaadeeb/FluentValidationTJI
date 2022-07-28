using AutoMapper;
using FluentValidationTJI.Models;
using FluentValidationTJI.Models.Dto;

namespace FluentValidationTJI.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AlphaDto, Alpha>().ReverseMap();
        } 
    }
}
