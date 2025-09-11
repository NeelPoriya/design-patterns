namespace ConsoleApp.Problems.Parking_Lot.Models
{
    public class ParkingTicket
    {
        public string Id { get; private set; }
        public Vehicle? Vehicle { get; private set; }
        public DateTimeOffset EntryTimestamp { get; private set; }
        public DateTimeOffset ExitTimestamp { get; private set; }
        public ParkingSpot Spot { get; private set; }

        public ParkingTicket(Vehicle vehicle, ParkingSpot parkingSpot)
        {
            Id = Guid.NewGuid().ToString();
            Vehicle = vehicle;
            Spot = parkingSpot;
            EntryTimestamp = DateTimeOffset.UtcNow;
        }

        public void SetExitTimestamp()
        {
            ExitTimestamp = DateTimeOffset.UtcNow;
        }
    }
}
