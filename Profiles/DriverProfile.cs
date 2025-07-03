using F1API.Data.Dtos;
using F1API.Models;
using AutoMapper;

namespace F1API.Profiles;
    public class DriverProfile : Profile
    {
        public DriverProfile()
        {
            CreateMap<CreateDriverDto, Driver>();
        }
    }
