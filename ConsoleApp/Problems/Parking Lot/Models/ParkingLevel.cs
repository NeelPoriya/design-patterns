using ConsoleApp.Problems.Parking_Lot.Enums;

namespace ConsoleApp.Problems.Parking_Lot.Models;

public class ParkingLevel
{
    private Dictionary<string, ParkingSpot> _spots = [];
    private int floorNumber;

    public ParkingLevel(int floorNumber)
    {
        this.floorNumber = floorNumber;
    }

    public ParkingSpot? FindAvailableSpot(Vehicle vehicle)
    {
        var availableSpots = _spots.Values
            .Where(p => p.CanFitVehicle(vehicle) && p.IsAvailable())
            .OrderBy(p => p.GetSpotSize())
            .ToList();

        return availableSpots.FirstOrDefault();
    }

    public void DisplayAvailability()
    {
        Console.WriteLine($"\n---Floor {floorNumber} Availability---");

        Dictionary<VehicleSize, int> count = new Dictionary<VehicleSize, int>();

        foreach(VehicleSize vehicleSize in Enum.GetValues<VehicleSize>())
        {
            count[vehicleSize] = 0;
        }

        foreach(ParkingSpot parkingSpot in _spots.Values)
        {
            if (parkingSpot.IsAvailable())
            {
                count[parkingSpot.GetSpotSize()]++;
            }
        }

        foreach (VehicleSize vehicleSize in Enum.GetValues<VehicleSize>())
        {
            Console.WriteLine($"Vehicle {vehicleSize} spots: {count[vehicleSize]}");
        }
    }

    public void AddSpot(ParkingSpot spot)
    {
        _spots[spot.GetId()] = spot;
    }
}
