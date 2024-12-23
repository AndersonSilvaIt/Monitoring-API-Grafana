using AutoMapper;
using Industry.Application.DTOs;
using Industry.Domain.Entities;

namespace Industry.Application.MappingConfiguration
{
    public class MachineMappingConfig : Profile
    {
        public MachineMappingConfig()
        {
            CreateMap<MachineDTO, Machine>().ReverseMap();
        }
    }
}