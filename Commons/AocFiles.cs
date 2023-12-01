namespace AOC2023
{
    public class AocFiles
    {
        public string[] GetArrayFromFile()
        {
            return File.ReadAllLines(@"..\..\..\input.txt");
        }
    }
}
