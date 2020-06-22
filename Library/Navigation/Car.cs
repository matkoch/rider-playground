using System;

namespace Library.Navigation
{
    // FEAT: Base Symbols
    // FEAT: Type Hierarchy
    // FEAT: Linked Types (requires TestLinker)
    public class Car : VehicleBase
    {
        public Car (int seats, int maximumVelocity)
            : base(seats, maximumVelocity)
        {
        }

        public override void Move (int xOffset, int yOffset)
        {
            throw new NotImplementedException();
        }
    }
}
