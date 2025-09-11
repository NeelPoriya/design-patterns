using ConsoleApp.Problems.Parking_Lot.Models;

namespace ConsoleApp.Problems.Parking_Lot.Interface.Parking
{
    public class NearestFirstParkingStrategy : IParkingStrategy
    {
        public ParkingSpot? FindSpot(List<ParkingLevel> floors, Vehicle vehicle)
        {
            foreach (ParkingLevel floor in floors)
            {
                ParkingSpot? spot = floor.FindAvailableSpot(vehicle);

                if (spot != null) return spot;
            }

            return null;
        }
    }
}
