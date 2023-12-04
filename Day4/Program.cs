using AOC2023;
using AOC2023Day4;

var aocFile = new AocFiles();
var lines = aocFile.GetLinesFromFile();

var res = Scratchcard.GetWinningNumbersSum(lines);
Console.WriteLine($"star1={res}");

var res2 = Scratchcard.GetScratchcardTotal(lines);
Console.WriteLine($"star2={res2}");
