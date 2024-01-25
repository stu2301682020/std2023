using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero knight = new Knight()
            {
                Name = "Ivan",
                Health = 100,
                Armor = 20,
                Damage = 20
            };
            Hero assassin = new Assassin()
            {
                Name = "Petar",
                Health = 100,
                Armor = 10,
                Damage = 30
            };

            GameEngine.NotifyProgress consoleNotifier = delegate (NotificationArgs args)
            {
                Console.WriteLine($"{args.Attacker.Name} attacks " +
                    $"{args.Defender.Name} with " +
                    $"{args.Attack} and makes " +
                    $"{args.Damage} damage");
            };

            GameEngine engine = new GameEngine()
            {
                HeroX = knight,
                HeroY = assassin,

                progressNotifier = consoleNotifier
            };


            engine.Fight();

            Console.WriteLine(engine.Winner.Name);
        }
    }
}
