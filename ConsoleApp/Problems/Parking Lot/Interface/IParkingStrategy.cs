using ConsoleApp.Problems.Parking_Lot.Models;

namespace ConsoleApp.Problems.Parking_Lot.Interface
{
    interface IParkingStrategy
    {
        ParkingSpot? FindSpot(List<ParkingLevel> floors, Vehicle vehicle);
    }
}
