using NUnit.Framework;

namespace Oware.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ResetHouse()
        {
            // ARRANGE:
            house h = new house(0,0)
            // ACT: 
            h.ResetHouse() // This method clears the seeds then adds 4 seeds to each house
            // ASSERT:
            Assert.areEqual(4, h.GetCount(), "Reset houses must have 4 seeds in them") // At the end, house must have 4 seeds
        }
    }
}