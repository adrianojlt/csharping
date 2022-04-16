namespace csharping.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Xunit;
    using Xunit.Abstractions;

    public class SampleTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        public SampleTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Temp()
        {
            testOutputHelper.WriteLine("test *************");
            Assert.IsTrue(true);
        }
    }
}