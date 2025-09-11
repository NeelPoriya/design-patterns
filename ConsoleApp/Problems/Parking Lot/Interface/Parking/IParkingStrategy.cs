using ConsoleApp.Problems.Parking_Lot.Models;

namespace ConsoleApp.Problems.Parking_Lot.Interface.Parking
{
    public interface IParkingStrategy
    {
        ParkingSpot? FindSpot(List<ParkingLevel> floors, Vehicle vehicle);
    }
}
