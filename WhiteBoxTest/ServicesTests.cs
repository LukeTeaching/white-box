using ServicesLib;

namespace WhiteBoxTest
{
    public class ServicesTests
    {
        private readonly Services _services;
        public ServicesTests()
        {
            // Khởi tạo đối tượng cần test
            _services = new Services();
        }
        [Theory]
        // Đường cơ bản 1: score < 0 hoặc score > 10 (Biên ngoài)
        [InlineData(-1, "Invalid")]
        [InlineData(11, "Invalid")]
        // Đường cơ bản 2: score >= 8 (Giỏi)
        [InlineData(8, "Excellent")]
        [InlineData(10, "Excellent")]
        // Đường cơ bản 3: score >= 5 (Trung bình/Khá)
        [InlineData(5, "Pass")]
        [InlineData(7.9, "Pass")]
        // Đường cơ bản 4: Các trường hợp còn lại (Yếu)
        [InlineData(0, "Fail")]
        [InlineData(4.9, "Fail")]
        public void GetRank_ShouldReturnCorrectRank_BasedOnScore(double score, string expectedRank)
        {
            // Act: Gọi hàm cần kiểm tra
            var result = _services.GetRank(score);

            // Assert: Kiểm tra kết quả
            Assert.Equal(expectedRank, result);
        }
    }
}
