namespace AOC2023
{ 
    public static class CubeBag
    {
        public static int GetPossibleGamesIdsSumPart1(List<string> lines)
        {
            var sum = 0;
            foreach (var line in lines)
            {
                if (IsGamePossible(line, out int gameId))
                    sum += gameId;
            }
            return sum;
        }

        public static bool IsGamePossible(string line, out int gameId)
        {
            var blueCubesNumber = 14;
            var redCubesNumber = 12;
            var greenCubesNumber = 13;

            var firstSplit = line.Split(':');
            var gameIdstring = firstSplit[0];
            var gameDetailsString = firstSplit[1];
            gameId = int.Parse(gameIdstring.Substring(5, gameIdstring.Length - 5));

            var colorCubeSets = gameDetailsString.Split(";");
            foreach (var colorCubeSet in colorCubeSets)
            {
                var colorCubes = colorCubeSet.Split(",");
                foreach (var colorCube in colorCubes)
                {
                    var details = colorCube.Split(" ");
                    var number = int.Parse(details[1]);
                    var color = details[2];
                    switch (color)
                    {
                        case "blue":
                            if (number > blueCubesNumber) return false;
                            break;
                        case "red":
                            if (number > redCubesNumber) return false; ;
                            break;
                        case "green":
                            if (number > greenCubesNumber) return false; ;
                            break;
                    }
                }
            }
            return true;
        }
        public static int GetMinimumCubeSetsPowerSumPart2(List<string> lines)
        {
            var sum = 0;
            foreach (var line in lines)
            {
                GetMinimumCubeSetsPower(line, out int minimumBlueSet, out int minimumRedSet, out int minimumGreenSet);
                sum += minimumBlueSet * minimumRedSet * minimumGreenSet;
            }
            return sum;
        }

        private static void GetMinimumCubeSetsPower(string line, out int minimumBlueSet, out int minimumRedSet, out int minimumGreenSet)
        {
            minimumBlueSet = 0;
            minimumRedSet = 0;
            minimumGreenSet = 0;

            var firstSplit = line.Split(':');
            var gameDetailsString = firstSplit[1];

            var colorCubeSets = gameDetailsString.Split(";");
            foreach (var colorCubeSet in colorCubeSets)
            {
                var colorCubes = colorCubeSet.Split(",");
                foreach (var colorCube in colorCubes)
                {
                    var details = colorCube.Split(" ");
                    var number = int.Parse(details[1]);
                    var color = details[2];
                    switch (color)
                    {
                        case "blue":
                            if (number > minimumBlueSet)
                                minimumBlueSet = number;
                            break;
                        case "red":
                            if (number > minimumRedSet)
                                minimumRedSet= number;
                            break;
                        case "green":
                            if (number > minimumGreenSet)
                                minimumGreenSet = number; 
                            break;
                    }
                }
            }
        }
    }
}