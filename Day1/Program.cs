using AOC2023;
using AOC2023Day1;

public class Program
{
    private static void Main(string[] args)
    {
        var aocFile = new AocFiles();
        var lines = aocFile.GetLinesFromFile();

        var res = Calibration.GetCalibrationSumPart1(lines);
        Console.WriteLine($"star1={res}");

        var res2 = Calibration.GetCalibrationSumPart2(lines);
        Console.WriteLine($"star2={res2}");
    }
}