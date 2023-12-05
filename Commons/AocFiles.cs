namespace AOC2023Files
{
    public class AocFiles
    {
        public List<string> GetLinesFromFile(string directory)
        {
            return File.ReadAllLines(@$"..\..\..\{directory}\input.txt").ToList();
        }
    }
}
