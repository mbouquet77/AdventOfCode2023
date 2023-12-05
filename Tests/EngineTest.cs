using AOC2023;
using NFluent;

namespace AOC2023TestProject
{
    public class EngineTest
    {
        private readonly List<string> _lines = new List<string>
            {
               "467..114..",
               "...*......",
               "..35..633.",
               "......#...",
               "617*......",
               ".....+.58.",
               "..592.....",
               "......755.",
               "...$.*....",
               ".664.598.."
            };

        [Fact]
        public void GetEnginePartsNumbersSumPart1Test()
        {
            Check.That(Engine.GetEnginePartsNumbersSumPart1(_lines)).IsEqualTo(4361);
        }

        [Fact]
        public void GetNumbersCoordinatesDictionaryTest()
        {
            var dict = new Dictionary<Coordinates, int>()
            {
                { new Coordinates(0, 0, 3), 467 },
                { new Coordinates(0, 5, 3), 114 }
            };
            Check.That(Engine.GetNumbersCoordinatesDictionary(0, _lines[0])).IsEqualTo(dict);

            dict = new Dictionary<Coordinates, int>()
            {
            };
            Check.That(Engine.GetNumbersCoordinatesDictionary(1, _lines[1])).IsEqualTo(dict);

            dict = new Dictionary<Coordinates, int>()
            {
                { new Coordinates(2, 2, 2), 35 },
                { new Coordinates(2, 6, 3), 633 }
            };
            Check.That(Engine.GetNumbersCoordinatesDictionary(2, _lines[2])).IsEqualTo(dict);
        }

        [Theory]
        [InlineData([0, 0, false])]
        [InlineData([0, 1, false])]
        [InlineData([0, 2, true])]
        [InlineData([0, 5, false])]
        [InlineData([0, 6, false])]
        [InlineData([0, 7, false])]
        [InlineData([2, 2, true])]
        [InlineData([2, 3, true])]
        [InlineData([2, 6, true])]
        [InlineData([2, 7, true])]
        [InlineData([2, 8, false])]
        public void ExistsSymbolAdjacentToCoordinatesTest(int x, int y, bool result)
        {
            Check.That(Engine.ExistsSymbolAdjacentToCoordinates(x, y, _lines.ToArray())).IsEqualTo(result);
        }

        [Fact]
        public void ExistsSymbolAdjacentToNumberTest()
        {
            Check.That(Engine.ExistsSymbolAdjacentToNumber(new Coordinates(0, 0, 3), _lines.ToArray())).IsTrue();
            Check.That(Engine.ExistsSymbolAdjacentToNumber(new Coordinates(0, 5, 3), _lines.ToArray())).IsFalse();
        }
    }
}
