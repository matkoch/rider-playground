using Library.Navigation;

namespace Library.Editing
{
    public class LiveTemplates
    {
        public void Test()
        {
            IVehicle vehicle = null;
            vehicle.Forward(1);
        }

        private static T CreateInstance<T>()
        {
            return default(T);
        }
    }
}
