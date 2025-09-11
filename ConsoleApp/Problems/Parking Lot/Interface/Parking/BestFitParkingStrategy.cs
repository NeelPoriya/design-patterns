using ConsoleApp.Problems.Parking_Lot.Models;

namespace ConsoleApp.Problems.Parking_Lot.Interface.Parking
{
    public class BestFitParkingStrategy : IParkingStrategy
    {
        public ParkingSpot? FindSpot(List<ParkingLevel> floors, Vehicle vehicle)
        {
            ParkingSpot? bestSpot = null;

            foreach (var floor in floors)
            {
                ParkingSpot? currentSpot = floor.FindAvailableSpot(vehicle);

                if (currentSpot != null)
                {
                    if (bestSpot == null)
                    {
                        bestSpot = currentSpot;
                    }
                    else
                    {
                        if ((int)bestSpot.GetSpotSize() < (int)currentSpot.GetSpotSize())
                        {
                            bestSpot = currentSpot;
                        }
                    }
                }
            }

            return bestSpot;
        }
    }
}
