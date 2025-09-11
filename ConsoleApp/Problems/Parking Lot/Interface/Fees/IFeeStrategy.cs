using ConsoleApp.Problems.Parking_Lot.Models;

namespace ConsoleApp.Problems.Parking_Lot.Interface.Fees
{
    public interface IFeeStrategy
    {
        double CalculateFee(ParkingTicket parkingTicket);
    }
}
