using System;

namespace Library.Navigation
{
    public class Plane : VehicleBase
    {
        public Plane (int seats, int maximumVelocity)
            : base(seats, maximumVelocity)
        {
        }

        public override void Move (int xOffset, int yOffset)
        {
            throw new NotImplementedException();
        }
    }
}