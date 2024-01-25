using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    class Knight : Hero
    {
        public override int Attack()
        {
            int attack = base.Attack();
            double probability = randomDamageGenerator.NextDouble();

            if (probability <= 0.2)
            {
                attack *= 2;
            }

            return attack;
        }

        public override int Defend(int attackDamage)
        {
            double probability = randomDamageGenerator.NextDouble();

            return probability <= 0.2 ? 0 : base.Defend(attackDamage);
        }
    }
}
