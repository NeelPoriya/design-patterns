using ConsoleApp.Problems.Parking_Lot.Enums;

namespace ConsoleApp.Problems.Parking_Lot.Models
{
    class Car : Vehicle
    {
        public Car(string licenseNumber) : base(VehicleSize.MEDIUM, licenseNumber) { }
    }
}
