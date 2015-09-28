namespace TestRunnerTests
{
    using System.Collections.Generic;
    using System.Linq;

    using Xunit;

    public class DataDrivenTests
    {
        public static IEnumerable<object[]> GetNumbers()
        {
            const int Size = 10000;
            var numbers = new List<object[]>(Size);
            numbers.AddRange(Enumerable.Range(1, Size).Select(i => new object[] { i }));
            return numbers;
        }

        [Theory]
        [MemberData("GetNumbers")]
        public void Test(int x)
        {
            Assert.True(x > 0);
        }
    }
}