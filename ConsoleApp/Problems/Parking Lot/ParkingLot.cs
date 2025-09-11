namespace ConsoleApp.Problems.Parking_Lot;

public class ParkingLot
{
    private static readonly Lazy<ParkingLot> _instance = new Lazy<ParkingLot>(() => new ParkingLot());

    public static ParkingLot Instance => _instance.Value;
}
