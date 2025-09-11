namespace ConsoleApp.Problems.Parking_Lot.Models;

public class ParkingLevel
{
    private Dictionary<string, ParkingSpot> _spots = [];
    private int floorNumber;

    public ParkingSpot? FindAvailableSpot(Vehicle vehicle)
    {
        var availableSpots = _spots.Values.Where(p => )
    }
}
