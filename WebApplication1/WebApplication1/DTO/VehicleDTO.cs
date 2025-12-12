namespace WebApplication1.DTO
{
    public class VehicleDTO
    {
        public Guid VehicleId { get; set; }

        public string PlateNumber { get; set; } = null!;

        public string Model { get; set; } = null!;
    }
}
