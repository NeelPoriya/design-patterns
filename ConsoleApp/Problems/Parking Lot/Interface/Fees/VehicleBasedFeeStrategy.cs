using ConsoleApp.Problems.Parking_Lot.Enums;
using ConsoleApp.Problems.Parking_Lot.Models;

namespace ConsoleApp.Problems.Parking_Lot.Interface.Fees
{
    class VehicleBasedFeeStrategy : IFeeStrategy
    {
        private static readonly Dictionary<VehicleSize, double> HOURLY_RATE = new()
        {
            { VehicleSize.SMALL, 10 },
            { VehicleSize.MEDIUM, 20 },
            { VehicleSize.LARGE, 30 }
        };

        public double CalculateFee(ParkingTicket parkingTicket)
        {
            VehicleSize? vehicleSize = parkingTicket.Vehicle?.GetVehicleSize();
            
            if (vehicleSize == null)
            {
                throw new InvalidOperationException("Vehicle not found");
            }

            TimeSpan timeSpan = parkingTicket.ExitTimestamp - parkingTicket.EntryTimestamp;
            double hours = timeSpan.TotalHours;

            return HOURLY_RATE[(VehicleSize)vehicleSize] * hours;
        }
    }
}
