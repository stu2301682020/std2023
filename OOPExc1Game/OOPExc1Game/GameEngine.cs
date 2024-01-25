using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    class NotificationArgs
    {
        public Hero Attacker { get; set; }
        public Hero Defender { get; set; }

        public int Attack;
        
        public int Damage;
    }
    class GameEngine
    {
        public Hero Winner { get; set; }
        public Hero HeroX { get; set; }
        public Hero HeroY { get; set; }

        public delegate void NotifyProgress(NotificationArgs args);

        public NotifyProgress progressNotifier { get; set; } = null;

        public void Fight()
        {
            Hero attacker = HeroX;
            Hero defender = HeroY;

            while (attacker.IsAlive)
            {
                int attack = attacker.Attack();
                int damage = defender.Defend(attack);

                if (progressNotifier != null)
                {
                    progressNotifier(new NotificationArgs()
                    {
                        Attacker = attacker,
                        Defender = defender,
                        Attack = attack,
                        Damage = damage
                    });
                }

                (defender, attacker) = (attacker, defender);
            }
            Winner = defender;
        }
    }
}