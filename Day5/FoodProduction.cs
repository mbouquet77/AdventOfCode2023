namespace AOC2023Main
{
    public static class FoodProduction
    {
        public static Int64 GetLowestLocationNumberPart1(List<string> lines)
        {
            var line = lines[0];
            var subline = line.Substring(7);
            var seeds = subline.Split(' ').Select(s => Int64.Parse(s)).ToList();

            return LowestLocationNumber(lines, seeds);
        }

/*        public static Int64 GetLowestLocationNumberPart2(List<string> lines)
        {
            var line = lines[0];
            var subline = line.Substring(7);
            var seedsRange = subline.Split(' ').Select(s => Int64.Parse(s)).ToList();
            var i = 0;
            var seeds = new List<Int64>();
            while (i < seedsRange.Count)
            {
                var source = seedsRange[i];
                var range = seedsRange[i + 1];
                for (var j = 0; j < range; j++)
                    seeds.Add(source + j);
                i += 2;
            }

            return LowestLocationNumber(lines, seeds);
        }*/
        private static long LowestLocationNumber(List<string> lines, List<long> seeds)
        {
            var soilToFertilizer = "soil-to-fertilizer";
            var soils = GetDestinationList(seeds, lines, "seed-to-soil", soilToFertilizer);

            var fertilizerToWater = "fertilizer-to-water";
            var fertilizers = GetDestinationList(soils, lines, soilToFertilizer, fertilizerToWater);

            var waterToLight = "water-to-light";
            var waters = GetDestinationList(fertilizers, lines, fertilizerToWater, waterToLight);

            var lightToTemperature = "light-to-temperature";
            var lights = GetDestinationList(waters, lines, waterToLight, lightToTemperature);

            var temperatureToHumidity = "temperature-to-humidity";
            var temperatures = GetDestinationList(lights, lines, lightToTemperature, temperatureToHumidity);

            var humidityToLocation = "humidity-to-location";
            var humidities = GetDestinationList(temperatures, lines, temperatureToHumidity, humidityToLocation);

            var locations = GetDestinationList(humidities, lines, humidityToLocation);
            return locations.Min();
        }

        private static List<Int64> GetDestinationList(List<Int64> sources, List<string> lines, string firstLineLabel, string lastLineLabel = "")
        {
            var map = GetMap(lines, sources, firstLineLabel, lastLineLabel);

            var destinations = new List<Int64>();
            foreach (var source in sources)
            {
                var destination = source;
                if (map.ContainsKey(source))
                    destination = map[source];

                destinations.Add(destination);
            }
            return destinations;
        }

        private static Dictionary<Int64, Int64> GetMap(List<string> lines, List<Int64> sources, string firstLineLabel, string lastLineLabel = "")
        {
            var map = new Dictionary<Int64, Int64>();
            var firstLine = lines.IndexOf($"{firstLineLabel} map:") + 1;
            var lastLine = lines.Count;
            if (!string.IsNullOrEmpty(lastLineLabel))
                lastLine = lines.IndexOf($"{lastLineLabel} map:") - 1;

            for (var i = firstLine; i < lastLine; i++)
            {
                var line = lines[i];
                var array = line.Split(' ').Select(m => Int64.Parse(m)).ToArray();
                var destination = array[0];
                var source = array[1];
                var range = array[2];
                for (var j = 0; j < range; j++)
                {
                    if (sources.Contains(source + j))
                        map.Add(source + j, destination + j);
                }
            }
            return map;
        }
    }
}
