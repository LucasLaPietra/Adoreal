using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain;
using WebApplication1.DTO;

namespace WebApplication1.Repository
{
    public class VehicleRepository : RepositoryBase<Vehicle>, IVehicleRepository
    {
        private readonly IMapper Mapper;
        internal VehicleContext Context;
        internal DbSet<Vehicle> DbSet;
        public VehicleRepository(VehicleContext context, IMapper mapper)
        : base(context)
        {
            Mapper = mapper;
            Context = context;
            DbSet = context.Set<Vehicle>();
        }

        public async Task<VehicleDTO> CreateAsync(CreateVehicleDTO createVehicleDTO)
        {
            var vehicle = Mapper.Map<Vehicle>(createVehicleDTO);
            var result = await Context.AddAsync(vehicle);
            await CommitAsync();
            var addedVehicle = result.Entity;
            return Mapper.Map<VehicleDTO>(addedVehicle);
        }

        public async Task CommitAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}
