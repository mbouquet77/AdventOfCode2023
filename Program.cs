using AOC2023;
using AOC2023Files;
using AOC2023Main;
using AOC2023Main.Day15;

var aocFile = new AocFiles();
var day = "Day1";
var lines = aocFile.GetLinesFromFile(day);

var res = Calibration.GetCalibrationSumPart1(lines);
Console.WriteLine($"{day} star1={res}");

res = Calibration.GetCalibrationSumPart2(lines);
Console.WriteLine($"{day} star2={res}");

Console.WriteLine("-------------------------------");
day = "Day2";
lines = aocFile.GetLinesFromFile(day);

res = CubeBag.GetPossibleGamesIdsSumPart1(lines);
Console.WriteLine($"{day} star1={res}");

res = CubeBag.GetMinimumCubeSetsPowerSumPart2(lines);
Console.WriteLine($"{day} star2={res}");

Console.WriteLine("-------------------------------");
/*day = "Day3";
lines = aocFile.GetLinesFromFile(day);

res = Engine.GetEnginePartsNumbersSumPart1(lines);
Console.WriteLine($"{day} star1={res}");*/

Console.WriteLine("-------------------------------");
day = "Day4";
lines = aocFile.GetLinesFromFile(day);

res = Scratchcard.GetWinningNumbersSum(lines);
Console.WriteLine($"{day} star1={res}");

res = Scratchcard.GetScratchcardTotal(lines);
Console.WriteLine($"{day} star2={res}");

//Console.WriteLine("-------------------------------");
//day = "Day5";
//lines = aocFile.GetLinesFromFile(day);

//var res2 = FoodProduction.GetLowestLocationNumberPart1(lines);
//Console.WriteLine($"{day} star1={res2}");
//var res2 = FoodProduction.GetLowestLocationNumberPart2(lines);
//Console.WriteLine($"{day} star2={res2}");

Console.WriteLine("-------------------------------");
day = "Day15";
lines = aocFile.GetLinesFromFile(day);

res = Hash.GetHashResultSum(lines[0]);
Console.WriteLine($"{day} star1={res}");
