namespace CakeTest.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
#if DEBUG
            Assert.True(false);
#endif
#if RELEASE
            Assert.True(true);
#endif
        }
    }
}