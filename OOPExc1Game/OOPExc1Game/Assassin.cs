using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    class Assassin : Hero
    {
        public override int Attack()
        {
            int attack = base.Attack();
            double probability = randomDamageGenerator.NextDouble();

            if (probability <= 0.4)
            {
                attack *= 4;
            }
            return attack;
        }
    }
}
