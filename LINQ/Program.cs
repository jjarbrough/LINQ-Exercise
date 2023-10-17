using System.Threading.Channels;
using System.Linq;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<String> gameNames = new List<String>();
            gameNames.Add("The Witcher");
            gameNames.Add("Baldurs Gate 3");
            gameNames.Add("CyberPunk 2077");
            gameNames.Add("Dragonage");
            gameNames.Add("Mass Effect");
            gameNames.Add("Call of Duty");
            gameNames.Add("Apex");
            gameNames.Add("Borderlands");
            gameNames.Add("Wonderlands");
            gameNames.Add("Assassins Creed");

            var temp = gameNames.OrderBy(x => x.Length).ToList();
            temp.ForEach(x => Console.WriteLine(x));
        }
    }
}
