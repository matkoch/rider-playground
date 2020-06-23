using System;

namespace Library.Navigation
{
    // FEAT: Goto Everything (Double-Shift; Cmd+T)
    // FEAT: Assign Shortcuts to Actions (Cmd+Shift+A)
    // FEAT: Initial Letter Search (CryptoStreamMode) + Decompilation
    // FEAT: TODO Explorer
    // FEAT: Favorites

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

    // FEAT: Bookmarks
    // FEAT: Goto Recent Locations
    // FEAT: Goto Recent Files/Edits
}
