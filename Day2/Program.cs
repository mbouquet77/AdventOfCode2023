using AOC2023;
using AOC2023Day2;

var aocFile = new AocFiles();
var lines = aocFile.GetLinesFromFile();

var cubeBag = new CubeBag();
var res = cubeBag.GetPossibleGamesIdsSumPart1(lines);
Console.WriteLine($"star1={res}");

var res2 = CubeBag.GetMinimumCubeSetsPowerSumPart2(lines);
Console.WriteLine($"star2={res2}");