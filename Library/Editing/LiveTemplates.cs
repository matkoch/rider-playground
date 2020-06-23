using FakeItEasy;
using Library.Navigation;

namespace Library.Editing
{
    public class LiveTemplates
    {
        public void Test()
        {
            IVehicle vehicle = A.Fake<IVehicle>();
            vehicle.Forward(1);
        }
    }
}
