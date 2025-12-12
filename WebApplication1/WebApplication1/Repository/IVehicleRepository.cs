using WebApplication1.Domain;
using WebApplication1.DTO;

namespace WebApplication1.Repository
{
    public interface IVehicleRepository : IRepositoryBase<Vehicle>
    {
        Task<VehicleDTO> CreateAsync(CreateVehicleDTO createVehiculoDto);
    }
}
