using AutoMapper;
using BlazorMapper.Data;
using BlazorMapper.Models;

namespace BlazorMapper.Profiles
{
    public class PreOrderProfile : Profile
    {
        public PreOrderProfile()
        {
            CreateMap<PreOrder, PreOrderDto>();
            CreateMap<PreOrderDto, PreOrder>();
        }
    }
}
