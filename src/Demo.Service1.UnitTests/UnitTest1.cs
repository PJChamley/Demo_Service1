namespace Demo.Service1.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            IService1abc srvAbc = new Service1abc();
            srvAbc.ValuePassedIn = "V1";
            
            Assert.Equal(srvAbc.DoSomeWork(), "This is what is the the property 'ValuePassedIn':V1");
        }
    }
}