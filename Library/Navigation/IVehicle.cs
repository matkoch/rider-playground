namespace Library.Navigation
{
    // FEAT: Extensions Methods (Special -> General)
    // FEAT: Exposing APIs
    public interface IVehicle
    {
        // FEAT: Value Origin
        int Seats { get; }
        int MaximumVelocity { get; }
        Position Position { get; }

        // FEAT: Find Usages (Grouping, Remove, Export)
        // FEAT: Show Usages (Type to Filter)
        void Move (int xOffset, int yOffset);
        void Move (Position offset);
    }
}
