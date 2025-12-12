using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain;
using WebApplication1.DTO;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/Vehicles")]
    public class VehicleController : ControllerBase
    {

        private readonly IVehicleRepository repository;
        public VehicleController(IVehicleRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<VehicleDTO>> Create(CreateVehicleDTO vehicle)
        {
            var VehicleCreated = await this.repository.CreateAsync(vehicle);
            return VehicleCreated;
        }
    }
}