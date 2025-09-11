namespace ConsoleApp.Problems.Parking_Lot.Models
{
    class Bike : Vehicle
    {
        public Bike(string licenseNumber) : base(Enums.VehicleSize.SMALL, licenseNumber) { }
    }
}
