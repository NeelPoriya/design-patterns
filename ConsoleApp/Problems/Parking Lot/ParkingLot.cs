using ConsoleApp.Problems.Parking_Lot.Interface.Fees;
using ConsoleApp.Problems.Parking_Lot.Interface.Parking;
using ConsoleApp.Problems.Parking_Lot.Models;
using System.Collections.Concurrent;

namespace ConsoleApp.Problems.Parking_Lot;

public class ParkingLot
{
    private static readonly Lazy<ParkingLot> _instance = new Lazy<ParkingLot>(() => new ParkingLot());

    public static ParkingLot Instance => _instance.Value;

    private IParkingStrategy parkingStrategy = new NearestFirstParkingStrategy();

    private IList<ParkingLevel> floors = [];

    private ConcurrentDictionary<string, ParkingTicket> activeTickets = [];

    private IFeeStrategy feeStrategy = new FlatFeeStrategy();

    public static readonly object mainLock = new object();

    public void SetFeeStrategy(IFeeStrategy feeStrategy)
    {
        this.feeStrategy = feeStrategy;
    }

    public void SetParkingStrategy(IParkingStrategy parkingStrategy)
    {
        this.parkingStrategy = parkingStrategy;
    }

    public void AddFloor(ParkingLevel floor)
    {
        floors.Add(floor);
    }

    public ParkingTicket? ParkVehicle(Vehicle vehicle)
    {
        lock (mainLock)
        {
            ParkingSpot? spot = parkingStrategy.FindSpot([.. floors], vehicle);
            if (spot != null)
            {
                spot.ParkVehicle(vehicle);
                ParkingTicket ticket = new ParkingTicket(vehicle, spot);

                activeTickets.TryAdd(vehicle.GetLicenseNumber(), ticket);

                Console.WriteLine($"Vehicle {vehicle.GetLicenseNumber()} parked at {spot.GetId()}");
                return ticket;
            }
            else
            {
                Console.WriteLine($"Couldn't find parking spot for vehicle with license number: {vehicle.GetLicenseNumber()}");
                return null;
            }
        }
    }

    public double? UnparkVehicle(string licenseNumber)
    {
        lock (mainLock)
        {
            if (activeTickets.TryRemove(licenseNumber, out ParkingTicket? ticket))
            {
                ticket.Spot.UnparkVehicle();
                ticket.SetExitTimestamp();
                double fee = feeStrategy.CalculateFee(ticket);
                Console.WriteLine($"Vehicle {licenseNumber} unparked from spot id: {ticket.Spot.GetId()}");
                return fee;
            }
            else
            {
                Console.WriteLine($"Coundn't find vehicle with license number: {licenseNumber} in parking lot");
                return null;
            }
        }
    }
}
