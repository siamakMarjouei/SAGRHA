using System.Linq;
using AutoMapper;
using SAGRHA.API.Dtos;
using SAGRHA.API.Models;

namespace SAGRHA.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                .ForMember(dest => dest.PhotoUrl,
                opt => opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(dest => dest.Age,
                opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

            CreateMap<User, UserForDetailedDto>()
                .ForMember(dest => dest.PhotoUrl,
                opt => opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(dest => dest.Age,
                opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

            CreateMap<Employee, EmployeesForListDto>()
                .ForMember(dest => dest.Age,
                opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

            CreateMap<Relative, RelativeToReturnDto>()
            .ForMember(dest => dest.Age,
            opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()))
            .ForMember(dest => dest.Relationship,
            opt => opt.MapFrom(src => src.RelationTypeCatalog));

            CreateMap<RelationTypeCatalog, RelationTypeDto>()
                .ForMember(dest => dest.RelationType,
                opt => opt.MapFrom(src => src.RelationType));

            CreateMap<Photo, PhotosForDetailedDto>();
            CreateMap<Photo, PhotoForReturnDto>();
            CreateMap<PhotoForCreationDto, Photo>();
            CreateMap<UserForUpdatesDto, User>();
            CreateMap<UserForRegisterDto, User>();
            CreateMap<EmployeeForRegisterDto, Employee>();
            CreateMap<RelativeToReturnDto, Relative>();
        }
    }
}