namespace AOC2023Day4
{
    public static class Scratchcard
    {
        public static int GetScratchcardTotal(List<string> lines)
        {
            var ScratchcardArray = new List<int>();
            for (int i = 0; i < lines.Count; i++)
                ScratchcardArray.Add(1);

            var j = 0;
            foreach (var line in lines)
            {
                var multiplicator = ScratchcardArray[j];
                var numberResult = GetNumberResultArray(line).Count();
                for (int m = 0; m < multiplicator; m++)
                {
                    for (int k = 0; k < numberResult; k++)
                    {
                        var index = j + k + 1;
                        if (index < lines.Count - 1)
                            ScratchcardArray[index]++;
                    }
                }
                j++;
            }
            return ScratchcardArray.Sum();
        }

        public static int GetWinningNumbersSum(List<string> lines)
        {
            var sum = 0;
            foreach (var line in lines)
            {
                sum += GetWinningNumbers(line);
            }
            return sum;
        }

        private static int GetWinningNumbers(string line)
        {
            var numberResult = GetNumberResultArray(line);
            if (numberResult.Any())
            {
                var i = 1;
                var result = 1;
                foreach (var number in numberResult)
                {
                    if (i > 1)
                        result *= 2;
                    i++;
                }
                return result;
            };

            return 0;
        }

        private static IEnumerable<string> GetNumberResultArray(string line)
        {
            var subLine = line.Substring(line.IndexOf(": ") + 1);
            var numbers = subLine.Split(" | ");
            var winningNumbers = numbers[0].Split(' ').Where(w => int.TryParse(w, out int int1));
            var numbersYouHave = numbers[1].Split(' ').Where(n => int.TryParse(n, out int int2));

            var numberResult = numbersYouHave.Where(number => winningNumbers.Contains(number));
            return numberResult;
        }
    }
}
