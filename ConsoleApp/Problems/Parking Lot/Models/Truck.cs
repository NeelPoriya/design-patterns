using ConsoleApp.Problems.Parking_Lot.Enums;

namespace ConsoleApp.Problems.Parking_Lot.Models
{
    class Truck : Vehicle
    {
        public Truck(string licenseNumber) : base(VehicleSize.LARGE, licenseNumber) { }
    }
}
