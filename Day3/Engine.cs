namespace AOC2023
{
    public static class Engine
    {
        public static int GetEnginePartsNumbersSumPart1(List<string> lines)
        {
            var sum = 0;
            var linesArray = lines.ToArray();
            for (var i = 0; i < linesArray.Length; i++)
            {
                var dict = GetNumbersCoordinatesDictionary(i, linesArray[i]);
                foreach (var tuple in dict)
                {;
                    if (ExistsSymbolAdjacentToNumber(tuple.Key, linesArray))
                        sum += tuple.Value;
                }
            }
            return sum;
        }

        public static bool ExistsSymbolAdjacentToNumber(Coordinates coordinates, string[] linesArray)
        {
            for (var i = 0; i < coordinates.CharNumbers; i++)
            {
                if (ExistsSymbolAdjacentToCoordinates(coordinates.X, coordinates.Y+i, linesArray))
                    return true;
            }
            return false;
        }


        public static bool ExistsSymbolAdjacentToCoordinates(int x, int y, string[] linesArray)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int newX = x + i;
                    int newY = y + j;

                    if (newX >= 0 && newX < linesArray.Length && newY >= 0 && newY < linesArray[0].Length)
                    {
                        if (newX != x || newY != y)
                        {
                            if (IsSymbol(linesArray[newX][newY]))
                                return true;
                        }
                    }
                }
            }
            return false;
        }


        private static bool IsSymbol(char c)
        {
            return !char.IsDigit(c) && c != '.';
        }

        public static Dictionary<Coordinates, int> GetNumbersCoordinatesDictionary(int i, string line)
        {
            var dict = new Dictionary<Coordinates, int>();
            var j = 0;
            while (j < line.Length - 1)
            {
                var c = line[j];
                j++;
                if (!char.IsDigit(c))
                    continue;
                var nbCharNumbers = 1;
                var stringNumber = c.ToString();
                while (j < line.Length - 1 && char.IsDigit(line[j]))
                {
                    nbCharNumbers++;
                    stringNumber += line[j];
                    j++;
                }
                dict.Add(new Coordinates(i, j - nbCharNumbers, nbCharNumbers), int.Parse(stringNumber));
            }
            return dict;
        }
    }

    public record Coordinates
    {
        public Coordinates(int x, int y, int charNumbers)
        {
            X = x;
            Y = y;
            CharNumbers = charNumbers;
        }

        public int X { get; }
        public int Y { get; }
        public int CharNumbers { get; }
    }
}
