namespace ExampleLibrary.UnitTests
{
    using ExampleLibrary;
    using NUnit.Framework;

    public static class ExampleClassTests
    {
        [Test]
        public static void Returns_placeholder_string() =>
            Assert.That(ExampleClass.ExampleMethod(), Is.EqualTo("Example return value"));
    }
}