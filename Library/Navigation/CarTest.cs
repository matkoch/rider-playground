using System;

namespace Library.Navigation
{
    // FEAT: Linked Types (requires TestLinker)
    public class CarTest
    {
        public void Test ()
        {
            IVehicle car = new Car (seats: 4, maximumVelocity: 250);

            car.Move (xOffset: 50, yOffset: 0);
            car.Forward (xOffset: 400).Move (new Position (x: 500, y: 0));

            dynamic dynamicCar = car;
//            dynamicCar.Move (1, 2);

            object objectCar = car;
            objectCar.Invoke ("Move", 1, 2);


            Console.WriteLine ($"MaximumVelocity: {car.MaximumVelocity}; Seats: {car.Seats}");
        }
    }
}
