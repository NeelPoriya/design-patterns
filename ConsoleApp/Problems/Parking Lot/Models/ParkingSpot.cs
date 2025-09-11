using ConsoleApp.Problems.Parking_Lot.Enums;

namespace ConsoleApp.Problems.Parking_Lot.Models
{
    class ParkingSpot
    {
        private readonly string id = "";
        private readonly VehicleSize size;
        private bool isOccupied;
        private Vehicle? parkedVehicle;

        public ParkingSpot(string id, VehicleSize size)
        {
            this.id = id;
            this.size = size;
            isOccupied = false;
            parkedVehicle = null;
        }

        public bool CanFitVehicle(Vehicle vehicle)
        {
            VehicleSize currentVehicleSize = vehicle.GetVehicleSize();

            switch (currentVehicleSize)
            {
                case VehicleSize.SMALL:
                    return true;
                case VehicleSize.MEDIUM:
                    return !Enum.Equals(VehicleSize.SMALL, currentVehicleSize);
                case VehicleSize.LARGE:
                    return Enum.Equals(VehicleSize.LARGE, currentVehicleSize);
            }

            return false;
        }
    }
}
