namespace csharpTT.Tests.Delegates
{
    using csharpTT.Generics;
    using NUnit.Framework;

    [TestFixture]
    public class DeletegatesTests
    {
        private string[] names = { "Alice", "john", "Bobby", "Kyle", "Tod", "Armin", "George" };

        [Test]
        public void Delegates_Names_LessThanFive()
        {
            // Arrange
            var delegates = new DelegatesExample();

            // Assert
            var filteredNames = delegates.NamesFilter(names, delegates.LessThanFive);

            // Result
            Assert.AreEqual(filteredNames.Count, 3);
        }

        [Test]
        public void Delegates_Names_MoreThanFive()
        {
            // Arrange
            var delegates = new DelegatesExample();

            // Assert
            var filteredNames = delegates.NamesFilter(names, name => name.Length > 5);

            // Result
            Assert.AreEqual(filteredNames.Count, 1);
        }
    }
}
