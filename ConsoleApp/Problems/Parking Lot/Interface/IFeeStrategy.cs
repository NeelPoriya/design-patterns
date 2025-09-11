using ConsoleApp.Problems.Parking_Lot.Models;

namespace ConsoleApp.Problems.Parking_Lot.Interface
{
    interface IFeeStrategy
    {
        double CalculateFee(ParkingTicket parkingTicket);
    }
}
