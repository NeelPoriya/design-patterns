using ConsoleApp.Problems.Parking_Lot.Enums;
using ConsoleApp.Problems.Parking_Lot.Models;

namespace ConsoleApp.Problems.Parking_Lot
{
    class Main
    {
        public static void main()
        {
            ParkingLot parkingLot = ParkingLot.Instance;

            Car car = new Car("GJ01AB1234");
            Bike bike = new Bike("GJ01AB1235");
            Truck truck = new Truck("GJ01BC1234");

            ParkingLevel level1 = new ParkingLevel(1);
            ParkingLevel level2 = new ParkingLevel(2);
            ParkingLevel level3 = new ParkingLevel(3);

            List<ParkingLevel> levels = new List<ParkingLevel> { level1, level2, level3 };

            for (int level = 0; level <= 2; ++level)
            {
                for (int spot = 1; spot <= 3; ++spot)
                {
                    ParkingSpot newSpot = new ParkingSpot($"Level{level+1}Spot{spot}", VehicleSize.SMALL + spot - 1);

                    levels[level].AddSpot(newSpot);
                }

                parkingLot.AddFloor(levels[level]);
            }

            parkingLot.ParkVehicle(car);
            parkingLot.ParkVehicle(bike);
            parkingLot.ParkVehicle(truck);

            double? carFee = parkingLot.UnparkVehicle(car.GetLicenseNumber());
            Console.WriteLine($"Parking fee for car {car.GetLicenseNumber()}: {carFee}");

            double? bikeFee = parkingLot.UnparkVehicle(bike.GetLicenseNumber());
            Console.WriteLine($"Parking fee for bike {bike.GetLicenseNumber()}: {bikeFee}");
        }
    }
}