namespace ConsoleApp.OOPS.Inheritance
{
    public class Main
    {
        public static void main()
        {
            Bike bike = new Bike { Speed = 20, HasCarrier = false };
            bike.Drive();

            Car car = new Car { Speed = 30, Doors = 4 };
            car.Drive();
        }
    }
}
