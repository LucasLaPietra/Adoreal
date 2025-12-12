using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Domain
{
    [Table("vehicle")]
    public class Vehicle
    {
        public Vehicle()
        {
        }

        public Vehicle(Guid idVehiculo, string plateNumber, string model)
        {
            VehicleId = idVehiculo;
            PlateNumber = plateNumber;
            Model = model;
        }

        [Key]
        public Guid VehicleId { get; set; }

        [Required(ErrorMessage = "Se requiere una patente para registrar un vehiculo")]
        [StringLength(7, ErrorMessage = "La patente debe tener 6 o 7 caracteres")]
        public string PlateNumber { get; set; } = null!;

        [Required(ErrorMessage = "Se requiere un modelo para registrar un vehiculo")]
        public string Model { get; set; } = null!;
    }
}
