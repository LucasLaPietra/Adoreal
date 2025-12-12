using AutoMapper;
using WebApplication1.Domain;
using WebApplication1.DTO;

namespace WebApplication1.AutoMapperProfiles
{
    public class VehicleProfile: Profile
    {
        public VehicleProfile()
        {
            CreateMap<VehicleDTO, Vehicle>();
            CreateMap<Vehicle, VehicleDTO>();
            CreateMap<CreateVehicleDTO, Vehicle>();
        }
    }
}
