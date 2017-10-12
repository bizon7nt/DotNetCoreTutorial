using Xunit;
using Library;

namespace TestLibrary
{
    public class ThingGetTest
    {
        [Fact]
        public void TestGet() {
            Assert.Equal(55, new Thing().Get(11,44));
        }
    }
}
