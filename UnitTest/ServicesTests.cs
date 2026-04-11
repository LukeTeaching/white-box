using ServicesLib;

namespace UnitTest
{
    public class Tests
    {
        private Services _services; // Removed readonly modifier

        [SetUp]
        public void Setup()
        {
            _services = new Services();
        }

        public static IEnumerable<TestCaseData> TestData()
        {
            yield return new TestCaseData(-1, "Invalid");
            yield return new TestCaseData(11, "Invalid");

            yield return new TestCaseData(8, "Excellent");
            yield return new TestCaseData(10, "Excellent");

            yield return new TestCaseData(5, "Pass");
            yield return new TestCaseData(7.9, "Pass");

            yield return new TestCaseData(0, "Fail");
            //yield return new TestCaseData(4.9, "Fail");


        }

        [Test]
        [TestCaseSource(nameof(TestData))]

        public void GetRank_ShouldReturnCorrectRank_BasedOnScore(double score, string expectedRank)
        {
            // Act: Gọi hàm cần kiểm tra
            var result = _services.GetRank(score);

            // Assert: Kiểm tra kết quả
            Assert.That(expectedRank, Is.EqualTo(result));
        }
    }
}
