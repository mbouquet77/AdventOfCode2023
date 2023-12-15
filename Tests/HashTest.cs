using AOC2023Main.Day15;
using NFluent;

namespace AOC2023TestProject
{
    public class HashTest
    {
        [Fact]
        public void GetHashResultSumTest()
        {
            var lines = "rn=1,cm-,qp=3,cm=2,qp-,pc=4,ot=9,ab=5,pc-,pc=6,ot=7";
            Check.That(Hash.GetHashResultSum(lines)).IsEqualTo(1320);
        }

        [Fact]
        public void GetHastResultTest()
        {
            var line = "HASH";
            Check.That(Hash.GetHastResult(line)).IsEqualTo(52);
        }
    }
}
