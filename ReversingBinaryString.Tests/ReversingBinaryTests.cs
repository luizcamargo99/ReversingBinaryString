namespace ReversingBinaryString.Tests;

public class ReversingBinaryTests
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(4, 1)]
    [InlineData(5, 5)]
    [InlineData(31, 31)]
    [InlineData(82, 37)]
    [InlineData(90, 45)]
    [InlineData(255, 255)]
    [InlineData(446, 251)]
    [InlineData(451, 391)]
    [InlineData(634, 377)]
    [InlineData(776, 67)]
    [InlineData(898, 263)]
    [InlineData(1103, 1937)]
    [InlineData(3801, 2487)]
    [InlineData(4096, 1)]
    [InlineData(8505, 10017)]
    [InlineData(428293, 328843)]
    [InlineData(547643, 904609)]
    [InlineData(612965, 681385)]
    [InlineData(999999, 1033263)]
    public void TestReverseToBinaryStringSuccess(int num, int resultExpected)
    {
        var result = num.ReverseToBinaryString();
        Assert.Equal(resultExpected, result);
    }
}