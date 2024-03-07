using Xunit;
using WebApplication.Controllers;

namespace UnitTestProject
{

    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            var controller = new ValuesController();
            Assert.Equal(controller.Get()[0],"value1");
        }

    }
}
