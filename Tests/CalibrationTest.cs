using AOC2023Day1;
using NFluent;

namespace AOC2023TestProject
{
    public class CalibrationTest
    {
        [Fact]
        public void GetNumbersPart1Test()
        {
            Check.That(Calibration.GetNumbersPart1("1abc2")).IsEqualTo(new List<int> { 1, 2 });
            Check.That(Calibration.GetNumbersPart1("pqr3stu8vwx")).IsEqualTo(new List<int> { 3, 8 });
            Check.That(Calibration.GetNumbersPart1("a1b2c3d4e5f")).IsEqualTo(new List<int> { 1, 2, 3, 4, 5 });
            Check.That(Calibration.GetNumbersPart1("treb7uchet")).IsEqualTo(new List<int> { 7 });
        }

        [Theory]
        [InlineData(["1abc2", 12])]
        [InlineData(["pqr3stu8vwx", 38])]
        [InlineData(["a1b2c3d4e5f", 15])]
        [InlineData(["treb7uchet", 77])]
        public void GetCalibrationPart1Test(string line, int result)
        {
            Check.That(Calibration.GetCalibrationPart1(line)).IsEqualTo(result);
        }

        [Fact]
        public void GetCalibrationSumPart1Test()
        {
            var lines = new List<string>()
            {
                "1abc2",
                "pqr3stu8vwx",
                "a1b2c3d4e5f",
                "treb7uchet"
            };
            Check.That(Calibration.GetCalibrationSumPart1(lines)).IsEqualTo(142);
        }

        [Theory]
        [InlineData(["two1nine", 2])]
        [InlineData(["eightwothree", 8])]
        [InlineData(["abcone2threexyz", 1])]
        [InlineData(["xtwone3four", 2])]
        [InlineData(["4nineeightseven2", 4])]
        [InlineData(["zoneight234", 1])]
        [InlineData(["7pqrstsixteen", 7])]
        public void GetFirstNumberPart2Test(string line, int result)
        {
            Check.That(Calibration.GetFirstNumberPart2(line)).IsEqualTo(result);
        }

        [Theory]
        [InlineData(["two1nine", 9])]
        [InlineData(["eightwothree", 3])]
        [InlineData(["abcone2threexyz", 3])]
        [InlineData(["xtwone3four", 4])]
        [InlineData(["4nineeightseven2", 2])]
        [InlineData(["zoneight234", 4])]
        [InlineData(["eighthree", 3])]
        public void GetLastNumberTest(string line, int result)
        {
            Check.That(Calibration.GetLastNumberPart2(line)).IsEqualTo(result);
        }

        [Fact]
        public void GetCalibrationPart2SumTest()
        {
            var lines = new List<string>()
            {
                "two1nine",
                "eightwothree",
                "abcone2threexyz",
                "xtwone3four",
                "4nineeightseven2",
                "zoneight234",
                "7pqrstsixteen"
            };
            Check.That(Calibration.GetCalibrationSumPart2(lines)).IsEqualTo(281);
        }
    }
}