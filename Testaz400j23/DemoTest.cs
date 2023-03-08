using Xunit;

namespace Testaz400j23
{
    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
           int i = 1;
            bool b = false;
            if (i == 1)
            {
                b = true;
            }

            Assert.True(b, "The values should be equal to 1");

        }
    }
}