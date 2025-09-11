using ConsoleApp.Problems.Parking_Lot.Models;

namespace ConsoleApp.Problems.Parking_Lot.Interface.Parking
{
    public class FarthestFirstParkingStrategy : IParkingStrategy
    {
        public ParkingSpot? FindSpot(List<ParkingLevel> floors, Vehicle vehicle)
        {
            var reversedFloors = floors.AsEnumerable().Reverse().ToList();

            foreach (var floor in reversedFloors)
            {
                ParkingSpot? spot = floor.FindAvailableSpot(vehicle);

                if (spot != null) { return spot; }
            }

            return null;
        }
    }
}
