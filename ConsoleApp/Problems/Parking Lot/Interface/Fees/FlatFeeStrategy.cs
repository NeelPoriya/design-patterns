using ConsoleApp.Problems.Parking_Lot.Models;

namespace ConsoleApp.Problems.Parking_Lot.Interface.Fees
{
    public class FlatFeeStrategy : IFeeStrategy
    {
        private const double RATE_PER_HOUR = 60;

        public double CalculateFee(ParkingTicket parkingTicket)
        {
            TimeSpan timeDiff = parkingTicket.ExitTimestamp - parkingTicket.EntryTimestamp;
            double hours = timeDiff.Hours;
            return hours * RATE_PER_HOUR;
        }
    }
}
