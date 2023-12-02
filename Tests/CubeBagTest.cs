using AOC2023Day2;
using NFluent;

namespace AOC2023TestProject
{
    public class CubeBagTest
    {
        private readonly List<string> _lines =
            [
                "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
                "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue",
                "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red",
                "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red",
                "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green"
            ];

        [Fact]
        public void GetPossibleGamesIdsSumPart1Test()
        {
            Check.That(CubeBag.GetPossibleGamesIdsSumPart1(_lines)).IsEqualTo(8);
        }

        [Theory]
        [InlineData(["Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green", 1, true])]
        [InlineData(["Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue", 2, true])]
        [InlineData(["Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red", 3, false])]
        [InlineData(["Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red", 4, false])]
        [InlineData(["Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green", 5, true])]
        public void IsGamePossible(string line, int gameId, bool result)
        {
            Check.That(CubeBag.IsGamePossible(line, out int gameIdResult)).IsEqualTo(result);
            Check.That(gameId).IsEqualTo(gameIdResult);
        }

        [Fact]
        public void GetMinimumCubeSetsPowerSumPart2Test()
        {
            Check.That(CubeBag.GetMinimumCubeSetsPowerSumPart2(_lines)).IsEqualTo(2286);
        }
    }
}
