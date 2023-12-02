
namespace AOC2023
{
    public class AocFiles
    {
        public List<string> GetLinesFromFile()
        {
            return File.ReadAllLines(@"..\..\..\input.txt").ToList();
        }
    }
}
