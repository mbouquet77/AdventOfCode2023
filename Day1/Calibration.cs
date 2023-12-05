namespace AOC2023
{
    public static class Calibration
    {
        public static readonly Dictionary<string, int> _numberDictionary = new Dictionary<string, int>
        {
            {"one", 1 },
            {"two", 2 },
            {"three", 3 },
            {"four", 4 },
            {"five", 5 },
            {"six", 6 },
            {"seven", 7 },
            {"eight", 8 },
            {"nine", 9 }
        };

        public static int GetFirstNumberPart2(string line)
        {
            foreach (var tuple in _numberDictionary)
            {
                if (line.StartsWith(tuple.Key))
                {
                    return tuple.Value;
                }
            }

            var c = line[0].ToString();
            if (int.TryParse(c, out int res))
            {
                return res;
            }

            var newLine = line.Substring(1);
            var newResult = GetFirstNumberPart2(newLine);
            return newResult;
        }

        public static int GetLastNumberPart2(string line)
        {
            foreach (var tuple in _numberDictionary)
            {
                if (line.EndsWith(tuple.Key))
                {
                    return tuple.Value;
                }
            }

            var c = line[line.Length - 1].ToString();
            if (int.TryParse(c, out int res))
            {
                return res;
            }

            var newLine = line.Substring(0, line.Length - 1);
            var newResult = GetLastNumberPart2(newLine);
            return newResult;
        }

        public static int GetCalibrationPart2(string line)
        {
            var firstDigit = GetFirstNumberPart2(line);
            var LastDigit = GetLastNumberPart2(line);
            return firstDigit * 10 + LastDigit;
        }

        public static int GetCalibrationSumPart2(List<string> lines)
        {
            var sum = 0;
            foreach (var line in lines)
            {
                sum += GetCalibrationPart2(line);
            }
            return sum;
        }

        public static int GetCalibrationPart1(string line)
        {
            var numbers = GetNumbersPart1(line);
            var firstDigit = numbers.FirstOrDefault();
            var LastDigit = numbers.LastOrDefault();
            return firstDigit * 10 + LastDigit;
        }

        public static int GetCalibrationSumPart1(List<string> lines)
        {
            var sum = 0;
            foreach (var line in lines)
            {
                sum += GetCalibrationPart1(line);
            }
            return sum;
        }

        public static List<int> GetNumbersPart1(string line)
        {
            var numbers = new List<int>();
            foreach (char c in line)
            {
                if (int.TryParse(c.ToString(), out int res))
                {
                    numbers.Add(res);
                }
            }
            return numbers;
        }
    }
}
