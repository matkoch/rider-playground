using Xunit;

namespace Tests
{
    public class SampleTests
    {
        [Fact]
        public void Test1()
        {
            RandomThrower.M();
        }

        [Fact]
        public void Test2()
        {
            PeoplePrinter.Print();
        }
    }
}
