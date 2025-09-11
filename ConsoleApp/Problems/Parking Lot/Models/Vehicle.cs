using ConsoleApp.Problems.Parking_Lot.Enums;

namespace ConsoleApp.Problems.Parking_Lot.Models
{
    abstract class Vehicle
    {
        protected readonly VehicleSize vehicleSize;
        protected readonly string licenseNumber = "";

        public Vehicle(VehicleSize vehicleSize, string licenseNumber)
        {
            this.vehicleSize = vehicleSize;
            this.licenseNumber = licenseNumber;
        }

        public string GetLicenseNumber()
        {
            return licenseNumber;
        }

        public VehicleSize GetVehicleSize()
        {
            return vehicleSize;
        }
    }
}
