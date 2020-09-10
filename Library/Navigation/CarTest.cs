using System;

namespace Library.Navigation
{
    // FEAT: Linked Types (requires TestLinker)
    public class CarTest
    {
        public void Test()
        {
            IVehicle car = new Car(4, 250);

            car.Move(50, 0);
            car.Forward(400).Move(new Position(x: 500, y: 0));

            dynamic dynamicCar = car;
//            dynamicCar.Move (1, 2);

            object objectCar = car;
            objectCar.Invoke("Move", 1, 2);


            Console.WriteLine($"MaximumVelocity: {car.MaximumVelocity}; Seats: {car.Seats}");
        }
    }
}